using AutoCount;
using AutoCount.ARAP;
using AutoCount.ARAP.CommissionByCollection;
using AutoCount.Authentication;
using AutoCount.Controls.FilterUI;
using AutoCount.Data;
using AutoCount.Report;
using AutoCount.SearchFilter;
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
            else
            {
                AppMessage.ShowErrorMessage("Incorrect date input! Please try again");
                BtnInquiry.Enabled = false;
                gridControl1.DataSource = null;
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
            else
            {
                return true;
            }
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

            Commission = ds.Tables.Add("Detail");
            Commission.Columns.Add("SalesAgent", typeof(string));
            Commission.Columns.Add("CommissionFromDay", typeof(DateTime));
            Commission.Columns.Add("CommissionToDay", typeof(DateTime));
            Commission.Columns.Add("TotalPaymentReceived", typeof(decimal));
            Commission.Columns.Add("Percentage", typeof(decimal));
            Commission.Columns.Add("Commission", typeof(decimal));

            Incentive = ds.Tables.Add("Detail2");
            Incentive.Columns.Add("SalesAgent", typeof(string));
            Incentive.Columns.Add("IncentiveFromDay", typeof(DateTime));
            Incentive.Columns.Add("IncentiveToDay", typeof(DateTime));
            Incentive.Columns.Add("TotalSalesReceived", typeof(decimal));
            Incentive.Columns.Add("Percentage2", typeof(decimal));
            Incentive.Columns.Add("Incentive", typeof(decimal));

            DataRelation relation = new DataRelation("MasterDetail", new DataColumn[] { SalesAgent.Columns["SalesAgent"] }, new DataColumn[] { Commission.Columns["SalesAgent"] });
            ds.Relations.Add(relation);
            Commission.AcceptChanges();

            DataRelation relation2 = new DataRelation("Detail", new DataColumn[] { Commission.Columns["SalesAgent"] }, new DataColumn[] { Incentive.Columns["SalesAgent"] });
            ds.Relations.Add(relation2);
            Incentive.AcceptChanges();
            #endregion

            var incrow = Incentive.NewRow();
            var commrow = Commission.NewRow();
            var sales = SalesAgent.NewRow();

            #region Sales Agent
            //sql to extract total iv, total dn and total cn
            var agent = myDBSetting.GetDataTable("Select * from DaxSalesAgent", true);
            var srow = agent.NewRow();

            sales["SalesAgent"] = srow["SalesAgent"];
            sales["Month"] = srow["Month"];

            var salestarget = myDBSetting.GetDataTable("Select SalesTarget from SalesAgent where SalesAgent = ?", true, sales["SalesAgent"]);
            if (salestarget != null && salestarget.Rows.Count > 0)
            {
                sales["SalesTarget"] = AutoCount.Converter.ToDecimal(salestarget.ToString());
                if (FromDateEdit.EditValue.ToString() != null && ToDateEdit.EditValue.ToString() != null)
                {
                    myCommissionReportCriteria.SalesAgentFilter.Clear();
                    myCommissionReportCriteria.SalesAgentFilter.Type = FilterType.None;
                    var invoice = myDBSetting.ExecuteScalar("Select sum(IV.Total) as TotalInvoice from IV where DocDate >= ? and DocDate <= ? and SalesAgent = ? group by SalesAgent", FromDateEdit.EditValue.ToString(), ToDateEdit.EditValue.ToString(), ucSalesAgentSelector1.ToString());
                    if (invoice != null && invoice.ToString() != "")
                    {
                        myCommissionReportCriteria.SalesAgentFilter.Type = FilterType.ByIndividual;
                        var debit = myDBSetting.ExecuteScalar("Select sum(DN.Total) as TotalDN from DN where DocDate >= ? and DocDate <= ? and SalesAgent = ? group by SalesAgent", FromDateEdit.EditValue.ToString(), ToDateEdit.EditValue.ToString(), ucSalesAgentSelector1.ToString());
                        if (debit != null && debit.ToString() != "")
                        {
                            var credit = myDBSetting.ExecuteScalar("Select sum(CN.Total) as TotalCN from CN where DocDate >= ? and DocDate <= ? and SalesAgent = ? group by SalesAgent", FromDateEdit.EditValue.ToString(), ToDateEdit.EditValue.ToString(), ucSalesAgentSelector1.ToString());
                            if (credit != null && credit.ToString() != "")
                            {
                                //calculate total sales achieved
                                var totalsalesachieved = (AutoCount.Converter.ToDecimal(invoice) + AutoCount.Converter.ToDecimal(debit)) - AutoCount.Converter.ToDecimal(credit);
                                if (totalsalesachieved.ToString() != null && totalsalesachieved.ToString() != "")
                                {
                                    sales["SalesAchieved"] = AutoCount.Converter.ToDecimal(totalsalesachieved.ToString());
                                    if (AutoCount.Converter.ToDecimal(sales["SalesTarget"]) >= AutoCount.Converter.ToDecimal(sales["SalesAchieved"]))
                                    {
                                        sales["Result"] = "Disqualified";
                                    }
                                    else if (AutoCount.Converter.ToDecimal(sales["SalesTarget"]) < AutoCount.Converter.ToDecimal(sales["SalesAchieved"]))
                                    {
                                        sales["Result"] = "Qualified";
                                    }
                                }
                            }
                        }
                    }
                }
            }
            SalesAgent.Rows.Add(sales);
            #endregion

            #region  Commission
            var commission = myDBSetting.GetDataTable("Select KPIFrom, KPITo, TotalPaymentReceived, Percentage, Commission from DaxCommission where SalesAgent = ?", true, sales["SalesAgent"]);
            var crow = commission.NewRow();

            commrow["Percentage"] = crow["Percentage"];
            commrow["CommissionFromDay"] = crow["KPIFrom"];
            commrow["CommissionToDay"] = crow["KPITo"];

            //calculate total payment
            var arpayment = myDBSetting.ExecuteScalar("Select sum(a.PaymentAmt) as TotalARPayment from ARPayment a join Debtor b on a.DebtorCode = b.AccNo where a.DocDate >= ? and a.DocDate <= ? and b.SalesAgent = ? group by b.SalesAgent", true, FromDateEdit.EditValue.ToString(), ToDateEdit.EditValue.ToString(), ucSalesAgentSelector1.ToString());
            if (arpayment != null && arpayment.ToString() != "")
            {
                commrow["TotalPaymentReceived"] = AutoCount.Converter.ToDecimal(arpayment.ToString());
            }

            //calculate commission
            var calculation = AutoCount.Converter.ToDecimal(crow["TotalPaymentReceived"]) * (AutoCount.Converter.ToDecimal(crow["Percentage"]) / 100);
            if (calculation.ToString() != null && calculation.ToString() != "")
            {
                commrow["Commission"] = AutoCount.Converter.ToDecimal(calculation.ToString());
            }
            Commission.Rows.Add(commrow);
            #endregion

            #region Incentive
            var incentive = myDBSetting.GetDataTable("select IncentiveFrom, IncentiveTo, TotalSalesReceived, Percentage, Incentive from DaxIncentive where a.SalesAgent = ?", true, sales["SalesAgent"]);
            var irow = incentive.NewRow();

            incrow["Percentage2"] = irow["Percentage2"];
            incrow["IncentiveFromDay"] = irow["IncentiveFrom"];
            incrow["IncentiveToDay"] = irow["IncentiveTo"];

            if (FromDateEdit.EditValue.ToString() != null && ToDateEdit.EditValue.ToString() != null)
            {
                var invoice = myDBSetting.ExecuteScalar("Select sum(IV.Total) as TotalInvoice from IV where DocDate >= ? and DocDate <= ? and SalesAgent = ? group by SalesAgent", FromDateEdit.EditValue.ToString(), ToDateEdit.EditValue.ToString(), ucSalesAgentSelector1.ToString());
                if (invoice != null && invoice.ToString() != "")
                {
                    var debit = myDBSetting.ExecuteScalar("Select sum(DN.Total) as TotalDN from DN where DocDate >= ? and DocDate <= ? and SalesAgent = ? group by SalesAgent", FromDateEdit.EditValue.ToString(), ToDateEdit.EditValue.ToString(), ucSalesAgentSelector1.ToString());
                    if (debit != null && debit.ToString() != "")
                    {
                        var credit = myDBSetting.ExecuteScalar("Select sum(CN.Total) as TotalCN from CN where DocDate >= ? and DocDate <= ? and SalesAgent = ? group by SalesAgent", FromDateEdit.EditValue.ToString(), ToDateEdit.EditValue.ToString(), ucSalesAgentSelector1.ToString());
                        if (credit != null && credit.ToString() != "")
                        {
                            //calculate total sales achieved
                            var totalsalesachieved = (AutoCount.Converter.ToDecimal(invoice) + AutoCount.Converter.ToDecimal(debit)) - AutoCount.Converter.ToDecimal(credit);
                            if (totalsalesachieved.ToString() != null && totalsalesachieved.ToString() != "")
                            {
                                //calculate total sales
                                incrow["TotalSalesReceived"] = AutoCount.Converter.ToDecimal(totalsalesachieved.ToString());

                                //calculate incentive
                                var calculation2 = AutoCount.Converter.ToDecimal(irow["TotalSalesReceived"]) * (AutoCount.Converter.ToDecimal(irow["Percentage"]) / 100);
                                if (calculation2.ToString() != null && calculation2.ToString() != "")
                                {
                                    incrow["Incentive"] = AutoCount.Converter.ToDecimal(calculation2.ToString());
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

        private void BtnPreview_Click(object sender, EventArgs e)
        {
            //myFormCommissionByCollection = CommissionByCollectionFormHelper();
            //if (!AccessRightUI.GetOrCreate(this.myUserSession).IsAccessible("AR_REPORT_COMMISSION_PREVIEW", (IWin32Window)this))
            //    return;
            //if (this.gridControl1.DataSource == null)
            //{
            //    if (!await this.PerformInquiry())
            //        return;
            //}
            //Cursor current = Cursor.Current;
            //Cursor.Current = Cursors.WaitCursor;
            //try
            //{
            //    ReportInfo reportInfo = new ReportInfo(AutoCount.Localization.Localizer.GetString((Enum)ARAPStringId.CommissionByCollectionReport), "AR_REPORT_COMMISSION_PRINT", "AR_REPORT_COMMISSION_EXPORT", this.myCommissionByCollectionFormHelper.Criteria.ReadableText);
            //    ReportTool.PreviewReport("Commission By Collection", this.myCommissionByCollectionFormHelper.GetReportDesignerDataSource(), this.myUserSession, e.DefaultReport, false, this.myCommissionByCollectionFormHelper.ReportOption, reportInfo);
            //}
            //finally
            //{
            //    Cursor.Current = current;
            //}
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            //myFormCommissionByCollection = CommissionByCollectionFormHelper();
            //if (!AccessRightUI.GetOrCreate(this.myUserSession).IsAccessible("AR_REPORT_COMMISSION_PRINT", (IWin32Window)this))
            //    return;
            //if (this.gridControl1.DataSource == null)
            //{
            //    if (!await owner.PerformInquiry())
            //        return;
            //}
            //Cursor current = Cursor.Current;
            //Cursor.Current = Cursors.WaitCursor;
            //try
            //{
            //    ReportInfo reportInfo = new ReportInfo(AutoCount.Localization.Localizer.GetString((Enum)ARAPStringId.CommissionByCollectionReport), "AR_REPORT_COMMISSION_PRINT", "AR_REPORT_COMMISSION_EXPORT", owner.myCommissionByCollectionFormHelper.Criteria.ReadableText);
            //    ReportTool.PrintReport("Commission By Collection", owner.myCommissionByCollectionFormHelper.GetReportDesignerDataSource(), this.myUserSession, e.DefaultReport, owner.myCommissionByCollectionFormHelper.ReportOption, reportInfo);
            //}
            //finally
            //{
            //    Cursor.Current = current;
            //}
        }
    }
}
