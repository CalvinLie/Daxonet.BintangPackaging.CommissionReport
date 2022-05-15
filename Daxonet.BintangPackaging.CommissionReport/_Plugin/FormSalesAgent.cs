using AutoCount;
using AutoCount.ActivityStream;
using AutoCount.ARAP;
using AutoCount.ARAP.CommissionByCollection;
using AutoCount.Authentication;
using AutoCount.Controls.FilterUI;
using AutoCount.Data;
using AutoCount.Report;
using AutoCount.SearchFilter;
using AutoCount.XtraUtils.SearchLookupEditBuilder;
using Daxonet.BintangPackaging.CommissionReport._Plugin.NewReportType;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daxonet.BintangPackaging.CommissionReport._Plugin
{
    [AutoCount.PlugIn.MenuItem("Sales Agent", 1, false, "DAXONET_COMMISSION_REPORT_MAINTENANCESETTING", "DAXONET_COMMISSION_REPORT_MAINTENANCESETTING")]
    [AutoCount.Application.SingleInstanceThreadForm]

    public partial class FormSalesAgent : XtraForm
    {
        protected UserSession myUserSession;
        protected DBSetting myDBSetting;
        private CommissionReportCriteria myCommissionReportCriteria;

        public FormSalesAgent(UserSession userSession)
        {
            myUserSession = userSession;
            myDBSetting = userSession.DBSetting;
            InitializeComponent();
            Navigator();
            gridControl1.DataSource = null;
            myCommissionReportCriteria = new CommissionReportCriteria(myDBSetting);
            this.ucSalesAgentSelector1.Initialize(this.myUserSession, this.myCommissionReportCriteria.SalesAgentFilter, true);
            FromDateEdit.EditValue = "2020-01-01";
            ToDateEdit.EditValue = "2022-05-14";
            //this.mySearchLookupEditBuilderFrom = (ISearchLookupEditBuilder)new SalesAgentSearchLookupEditBuilder(userSession, ActiveDataOption.ActiveOnly);
            //this.mySearchLookupEditBuilderTo = (ISearchLookupEditBuilder)new SalesAgentSearchLookupEditBuilder(userSession, ActiveDataOption.ActiveOnly);
        }

        private void Navigator()
        {
            //Bottom part of the report page
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Remove.Visible = false;
        }

        private void BtnInquiry_Click(object sender, EventArgs e)
        {
            if (DateInquiry() == true)
            {
                var sbError = new StringBuilder();
                DataTable SalesAgent, Commission, Incentive;
                SetupDataSource(out SalesAgent, out Commission, out Incentive);
                if (SalesAgent.Rows.Count > 0)
                {
                    var ds = new DataSet();
                    ds.Tables.Add("Master");
                    ds.Tables.Add("Detail");
                    ds.Tables.Add("Detail2");
                    BtnInquiry.Enabled = true;
                    gridControl1.DataSource = SalesAgent;
                    if (sbError.Length > 0)
                    {
                        AutoCount.AppMessage.ShowMessage(sbError.ToString());
                        return;
                    }
                }
                else
                {
                    AppMessage.ShowMessage("No record found.");
                    BtnInquiry.Enabled = false;
                    gridControl1.DataSource = null;
                }
            }
        }

        private bool DateInquiry()
        {
            DateTime actualDataStartDate = FiscalYear.GetOrCreate(this.myDBSetting).ActualDataStartDate;
            if (this.FromDateEdit.DateTime < actualDataStartDate)
            {
                AppMessage.ShowErrorMessage("Date value incorrect. Please try again.");
                this.FromDateEdit.DateTime = actualDataStartDate;
                this.FromDateEdit.Focus();
                return false;
            }
            if (this.FromDateEdit.DateTime > this.ToDateEdit.DateTime)
            {
                AppMessage.ShowErrorMessage("Date range incorrect. Please try again.");
                this.FromDateEdit.Focus();
                return false;
            }
            return true;
        }

        private void SetupDataSource(out DataTable SalesAgent, out DataTable Commission, out DataTable Incentive)
        {
            #region Datatable
            DataSet ds = new DataSet();
            SalesAgent = ds.Tables.Add("Master");
            SalesAgent.Columns.Add("Month", typeof(DateTime));
            SalesAgent.Columns.Add("SalesAgent", typeof(string));
            SalesAgent.Columns.Add("MonthlySalesTarget", typeof(decimal));
            SalesAgent.Columns.Add("MonthlySalesAchieved", typeof(decimal));
            SalesAgent.Columns.Add("SalesResult", typeof(string));
            var sales = SalesAgent.NewRow();

            Commission = ds.Tables.Add("Detail");
            Commission.Columns.Add("SalesAgent", typeof(string));
            Commission.Columns.Add("CommissionFromDay", typeof(DateTime));
            Commission.Columns.Add("CommissionToDay", typeof(DateTime));
            Commission.Columns.Add("TotalPaymentReceived", typeof(decimal));
            Commission.Columns.Add("Percentage", typeof(decimal));
            Commission.Columns.Add("Commission", typeof(decimal));
            var commrow = Commission.NewRow();

            Incentive = ds.Tables.Add("Detail2");
            Incentive.Columns.Add("SalesAgent", typeof(string));
            Incentive.Columns.Add("IncentiveFromDay", typeof(DateTime));
            Incentive.Columns.Add("IncentiveToDay", typeof(DateTime));
            Incentive.Columns.Add("TotalSalesReceived", typeof(decimal));
            Incentive.Columns.Add("Percentage2", typeof(decimal));
            Incentive.Columns.Add("Incentive", typeof(decimal));
            var incrow = Incentive.NewRow();

            DataRelation relation = new DataRelation("MasterDetail", new DataColumn[] { SalesAgent.Columns["SalesAgent"] }, new DataColumn[] { Commission.Columns["SalesAgent"] });
            ds.Relations.Add(relation);
            Commission.AcceptChanges();

            DataRelation relation2 = new DataRelation("MasterDetail2", new DataColumn[] { SalesAgent.Columns["SalesAgent"] }, new DataColumn[] { Incentive.Columns["SalesAgent"] });
            ds.Relations.Add(relation2);
            Incentive.AcceptChanges();
            #endregion

            myCommissionReportCriteria.SalesAgentFilter.Clear();
            myCommissionReportCriteria.SalesAgentFilter.Type = FilterType.None;

            #region Sales Agent
            var agent = myDBSetting.GetDataTable("Select a.SalesAgent, a.Month, b.SalesTarget, a.SalesAchieved, a.Result from DaxSalesAgent a left join " +
                "(Select SalesAgent, UDF_SalesTarget as SalesTarget from SalesAgent group by SalesAgent, UDF_SalesTarget) b on a.SalesAgent = b.SalesAgent", true);
            var srow = agent.NewRow();

            myCommissionReportCriteria.SalesAgentFilter.Type = FilterType.ByIndividual;
            sales["SalesAgent"] = srow["SalesAgent"];
            sales["Month"] = srow["Month"];

            var salestarget = myDBSetting.GetDataTable("Select UDF_SalesTarget from SalesAgent where SalesAgent = ?", true, sales["SalesAgent"]);
            if (salestarget != null && salestarget.Rows.Count > 0)
            {                    
                sales["MonthlySalesTarget"] = AutoCount.Converter.ToDecimal(salestarget);
                if (FromDateEdit.EditValue.ToString() != null && ToDateEdit.EditValue.ToString() != null)
                {
                    var invoice = myDBSetting.ExecuteScalar("Select TOP 1 sum(IV.Total) as TotalInvoice from IV where DocDate >= ? and DocDate <= ? and SalesAgent = ? group by SalesAgent", true, FromDateEdit.EditValue.ToString(), ToDateEdit.EditValue.ToString(), ucSalesAgentSelector1.ToString());
                    if (invoice != null && invoice.ToString() != "")
                    {
                        var debit = myDBSetting.ExecuteScalar("Select TOP 1 sum(DN.Total) as TotalDN from DN where DocDate >= ? and DocDate <= ? and SalesAgent = ? group by SalesAgent", true, FromDateEdit.EditValue.ToString(), ToDateEdit.EditValue.ToString(), ucSalesAgentSelector1.ToString());
                        if (debit != null && debit.ToString() != "")
                        {
                            var credit = myDBSetting.ExecuteScalar("Select TOP 1 sum(CN.Total) as TotalCN from CN where DocDate >= ? and DocDate <= ? and SalesAgent = ? group by SalesAgent", true, FromDateEdit.EditValue.ToString(), ToDateEdit.EditValue.ToString(), ucSalesAgentSelector1.ToString());
                            if (credit != null && credit.ToString() != "")
                            {
                                //calculate total sales achieved
                                var totalsalesachieved = (AutoCount.Converter.ToDecimal(invoice) + AutoCount.Converter.ToDecimal(debit)) - AutoCount.Converter.ToDecimal(credit);
                                if (totalsalesachieved.ToString() != null && totalsalesachieved.ToString() != "")
                                {
                                    sales["MonthlySalesAchieved"] = AutoCount.Converter.ToDecimal(totalsalesachieved.ToString());
                                    if (AutoCount.Converter.ToDecimal(sales["MonthlySalesTarget"]) >= AutoCount.Converter.ToDecimal(sales["MonthlySalesAchieved"]))
                                    {
                                        sales["SalesResult"] = "Disqualified";
                                    }
                                    else if (AutoCount.Converter.ToDecimal(sales["MonthlySalesTarget"]) < AutoCount.Converter.ToDecimal(sales["MonthlySalesAchieved"]))
                                    {
                                        sales["SalesResult"] = "Qualified";
                                    }
                                }
                            }
                        }
                    }
                }
            }
            SalesAgent.Rows.Add(sales);
            myDBSetting.SimpleSaveDataTable(SalesAgent, "Select a.SalesAgent, a.Month, b.SalesTarget, a.SalesAchieved, a.Result from DaxSalesAgent a left join " +
                " (Select SalesAgent, UDF_SalesTarget as SalesTarget from SalesAgent group by SalesAgent, UDF_SalesTarget) b on a.SalesAgent = b.SalesAgent");
            #endregion

            #region  Commission
            var commission = myDBSetting.GetDataTable("Select KPIFrom, KPITo, Percentage from DaxCommission", true);
            var crow = commission.NewRow();

            commrow["SalesAgent"] = sales["SalesAgent"];
            commrow["CommissionFromDay"] = crow["KPIFrom"];
            commrow["CommissionToDay"] = crow["KPITo"];
            commrow["Percentage"] = crow["Percentage"];

            //calculate total payment
            myCommissionReportCriteria.SalesAgentFilter.Type = FilterType.ByIndividual;
            var arpayment = myDBSetting.ExecuteScalar("Select TOP 1 sum(a.PaymentAmt) as TotalARPayment from ARPayment a join Debtor b on a.DebtorCode = b.AccNo where a.DocDate >= ? and a.DocDate <= ? and b.SalesAgent = ? group by b.SalesAgent", true, FromDateEdit.EditValue.ToString(), ToDateEdit.EditValue.ToString(), ucSalesAgentSelector1.ToString());
            if (arpayment != null && arpayment.ToString() != "")
            {
                commrow["TotalPaymentReceived"] = AutoCount.Converter.ToDecimal(arpayment);
            }

            //calculate commission
            var calculation = AutoCount.Converter.ToDecimal(arpayment) * (AutoCount.Converter.ToDecimal(commrow["Percentage"]) / 100);
            if (calculation.ToString() != null && calculation.ToString() != "")
            {
                commrow["Commission"] = AutoCount.Converter.ToDecimal(calculation);
            }
            Commission.Rows.Add(commrow);
            #endregion

            #region Incentive
            var incentive = myDBSetting.GetDataTable("Select IncentiveFrom, IncentiveTo, Percentage from DaxIncentive", true);
            var irow = incentive.NewRow();

            incrow["SalesAgent"] = sales["SalesAgent"];
            incrow["IncentiveFromDay"] = irow["IncentiveFrom"];
            incrow["IncentiveToDay"] = irow["IncentiveTo"];
            incrow["Percentage2"] = irow["Percentage"];

            if (FromDateEdit.EditValue.ToString() != null && ToDateEdit.EditValue.ToString() != null)
            {
                myCommissionReportCriteria.SalesAgentFilter.Type = FilterType.ByIndividual;
                var invoice = myDBSetting.ExecuteScalar("Select TOP 1 sum(IV.Total) as TotalInvoice from IV where DocDate >= ? and DocDate <= ? and SalesAgent = ? group by SalesAgent", true, FromDateEdit.EditValue.ToString(), ToDateEdit.EditValue.ToString(), ucSalesAgentSelector1.ToString());
                if (invoice != null && invoice.ToString() != "")
                {
                    var debit = myDBSetting.ExecuteScalar("Select TOP 1 sum(DN.Total) as TotalDN from DN where DocDate >= ? and DocDate <= ? and SalesAgent = ? group by SalesAgent", true, FromDateEdit.EditValue.ToString(), ToDateEdit.EditValue.ToString(), ucSalesAgentSelector1.ToString());
                    if (debit != null && debit.ToString() != "")
                    {
                        var credit = myDBSetting.ExecuteScalar("Select TOP 1 sum(CN.Total) as TotalCN from CN where DocDate >= ? and DocDate <= ? and SalesAgent = ? group by SalesAgent", true, FromDateEdit.EditValue.ToString(), ToDateEdit.EditValue.ToString(), ucSalesAgentSelector1.ToString());
                        if (credit != null && credit.ToString() != "")
                        {
                            //calculate total sales achieved
                            var totalsalesachieved = (AutoCount.Converter.ToDecimal(invoice) + AutoCount.Converter.ToDecimal(debit)) - AutoCount.Converter.ToDecimal(credit);
                            if (totalsalesachieved.ToString() != null && totalsalesachieved.ToString() != "")
                            {
                                //calculate total sales
                                incrow["TotalSalesReceived"] = AutoCount.Converter.ToDecimal(totalsalesachieved);

                                //calculate incentive
                                var calculation2 = AutoCount.Converter.ToDecimal(incrow["TotalSalesReceived"]) * (AutoCount.Converter.ToDecimal(incrow["Percentage"]) / 100);
                                if (calculation2.ToString() != null && calculation2.ToString() != "")
                                {
                                    incrow["Incentive"] = AutoCount.Converter.ToDecimal(calculation2);
                                }
                            }
                        }
                    }
                }
            }
            Incentive.Rows.Add(incrow);
            #endregion
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            gridView1.RefreshData();
            BtnInquiry.Enabled = true;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void previewButton1_Preview(object sender, AutoCount.Controls.PrintEventArgs e)
        {
            DataSet ds = new DataSet();

            DataTable IVtable = new DataTable();
            IVtable.TableName = "Invoice";

            DataTable DNtable = new DataTable();
            DNtable.TableName = "Debit Note";

            DataTable CNtable = new DataTable();
            CNtable.TableName = "Credit Note";

            IVtable.Columns.Add("DocNo");
            IVtable.Columns.Add("CreatedTimeStamp", typeof(DateTime));
            IVtable.Columns.Add("CreatedUserID");
            IVtable.Columns.Add("DocDate", typeof(DateTime));
            IVtable.Columns.Add("DebtorCode");
            IVtable.Columns.Add("DebtorName");
            IVtable.Columns.Add("Description");
            IVtable.Columns.Add("SalesAgent");
            IVtable.Columns.Add("InvAddr1");
            IVtable.Columns.Add("InvAddr2");
            IVtable.Columns.Add("InvAddr3");
            IVtable.Columns.Add("InvAddr4");
            IVtable.Columns.Add("BranchCode");
            IVtable.Columns.Add("Total", typeof(decimal));
            IVtable.Columns.Add("CurrencyCode");
            IVtable.Columns.Add("SalesLocation");

            DNtable.Columns.Add("DocNo");
            DNtable.Columns.Add("CreatedTimeStamp", typeof(DateTime));
            DNtable.Columns.Add("CreatedUserID");
            DNtable.Columns.Add("DocDate", typeof(DateTime));
            DNtable.Columns.Add("DebtorCode");
            DNtable.Columns.Add("DebtorName");
            DNtable.Columns.Add("Description");
            DNtable.Columns.Add("SalesAgent");
            DNtable.Columns.Add("InvAddr1");
            DNtable.Columns.Add("InvAddr2");
            DNtable.Columns.Add("InvAddr3");
            DNtable.Columns.Add("InvAddr4");
            DNtable.Columns.Add("BranchCode");
            DNtable.Columns.Add("Total", typeof(decimal));
            DNtable.Columns.Add("CurrencyCode");
            DNtable.Columns.Add("SalesLocation");

            CNtable.Columns.Add("DocNo");
            CNtable.Columns.Add("CreatedTimeStamp", typeof(DateTime));
            CNtable.Columns.Add("CreatedUserID");
            CNtable.Columns.Add("DocDate", typeof(DateTime));
            CNtable.Columns.Add("DebtorCode");
            CNtable.Columns.Add("DebtorName");
            CNtable.Columns.Add("Description");
            CNtable.Columns.Add("SalesAgent");
            CNtable.Columns.Add("InvAddr1");
            CNtable.Columns.Add("InvAddr2");
            CNtable.Columns.Add("InvAddr3");
            CNtable.Columns.Add("InvAddr4");
            CNtable.Columns.Add("BranchCode");
            CNtable.Columns.Add("Total", typeof(decimal));
            CNtable.Columns.Add("CurrencyCode");
            CNtable.Columns.Add("SalesLocation");

            ds.Tables.Add(IVtable);
            ds.Tables.Add(DNtable);
            ds.Tables.Add(CNtable);

            ReportInfo reportInfo = new ReportInfo("Commission By Sales Agent Report", "", "", "");
            ReportTool.PreviewReport("Commission By Sales Agent Report", ds, myUserSession, e.DefaultReport, false, new BasicReportOption(), reportInfo);
        }

        private void printButton1_Print(object sender, AutoCount.Controls.PrintEventArgs e)
        {
            Cursor current = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                ReportInfo reportInfo = new ReportInfo("Commission By Sales Agent Report", "", "", "");
                //ReportTool.PrintReport("Commission By Sales Agent Report", ds, myUserSession, e.DefaultReport, new BasicReportOption(), reportInfo);
            }
            finally
            {
                Cursor.Current = current;
            }
        }
    }
}
