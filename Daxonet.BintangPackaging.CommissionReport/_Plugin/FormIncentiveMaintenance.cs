using AutoCount.Authentication;
using AutoCount.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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
    [AutoCount.PlugIn.MenuItem("Monthly Sales Received and Incentive", 2, false, "DAXONET_COMMISSION_REPORT_MAINTENANCESETTING", "DAXONET_COMMISSION_REPORT_MAINTENANCESETTING")]
    [AutoCount.Application.SingleInstanceThreadForm]

    public partial class FormIncentiveMaintenance : XtraForm
    {
        private DBSetting myDBSetting;
        private UserSession myUserSession;

        public FormIncentiveMaintenance(UserSession userSession)
        {
            InitializeComponent();
            this.myUserSession = userSession;
            this.myDBSetting = userSession.DBSetting;
            var incentive = myDBSetting.GetDataTable("Select * from DaxIncentive", true);
            gridControl1.DataSource = incentive;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var table = gridControl1.DataSource == null ? null : gridControl1.DataSource as DataTable;
            var nrow = table.NewRow();
            nrow["DocKey"] = DBRegistry.NewGlobalUniqueKey(myDBSetting);
            table.Rows.Add(nrow);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var table = gridControl1.DataSource == null ? null : gridControl1.DataSource as DataTable;
            if (table != null && table.Rows.Count > 0)
            {
                if (gridView1.FocusedRowHandle >= 0)
                {
                    AutoCount.AppMessage.ShowWarningMessage("Do you want to delete the current row?");
                    gridView1.DeleteSelectedRows();
                    myDBSetting.SimpleSaveDataTable(table, "Select * from DaxIncentive");
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var table = gridControl1.DataSource == null ? null : gridControl1.DataSource as DataTable;
            if (table != null && table.Rows.Count > 0)
            {
                var selectedrow = GetSelectedDoc();
                if (selectedrow["IncentiveFrom"] != null && selectedrow["IncentiveFrom"].ToString() != "" && selectedrow["IncentiveTo"] != null && selectedrow["IncentiveTo"].ToString() != "" && selectedrow["Percentage"] != null && selectedrow["Percentage"].ToString() != "")
                {
                    myDBSetting.SimpleSaveDataTable(table, "Select * from DaxIncentive");
                    AutoCount.AppMessage.ShowMessage("Record saved.");
                }
                else
                    AutoCount.AppMessage.ShowMessage("Null record cannot be saved.");
            }
        }

        private void BtnClose_Click(object sender, EventArgs e) => this.Close();

        protected DataRow GetSelectedDoc()
        {
            if (gridView1.FocusedRowHandle >= 0)
            {
                DataRow selectedrow = ((GridView)gridControl1.FocusedView).GetFocusedDataRow();
                if (selectedrow == null)
                    return null;
                else
                    return selectedrow;
            }
            return null;
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "IncentiveFrom")
            {
                var table = gridControl1.DataSource == null ? null : gridControl1.DataSource as DataTable;
                if (table != null)
                {
                    var selectedrow = GetSelectedDoc();
                    if (selectedrow != null)
                    {
                        var select = table.AsEnumerable().Where(r => r["DocKey"].ToString() != selectedrow["DocKey"].ToString()).ToArray();
                        if (select != null)
                        {
                            foreach (DataRow row in select)
                            {
                                if (AutoCount.Converter.ToDecimal(selectedrow["IncentiveFrom"]) < AutoCount.Converter.ToDecimal(row["IncentiveTo"]) && AutoCount.Converter.ToDecimal(selectedrow["IncentiveFrom"]) > AutoCount.Converter.ToDecimal(row["IncentiveFrom"]))
                                {
                                    AutoCount.AppMessage.ShowMessage("Input has been set in the previous range. Please try again.");
                                    selectedrow["IncentiveFrom"] = DBNull.Value;
                                }
                            }
                        }
                    }
                }
            }
            if (e.Column.FieldName == "IncentiveTo")
            {
                var table = gridControl1.DataSource == null ? null : gridControl1.DataSource as DataTable;
                if (table != null)
                {
                    var selectedrow = GetSelectedDoc();
                    if (selectedrow != null)
                    {
                        if (AutoCount.Converter.ToDecimal(selectedrow["IncentiveFrom"]) > AutoCount.Converter.ToDecimal(selectedrow["IncentiveTo"]))
                        {
                            AutoCount.AppMessage.ShowMessage("To (Day) cannot be smaller than From (Day)");
                            selectedrow["IncentiveTo"] = DBNull.Value;
                        }

                        var select = table.AsEnumerable().Where(r => r["DocKey"].ToString() != selectedrow["DocKey"].ToString()).ToArray();
                        if (select != null)
                        {
                            foreach (DataRow row in select)
                            {
                                if (AutoCount.Converter.ToDecimal(selectedrow["IncentiveTo"]) < AutoCount.Converter.ToDecimal(row["IncentiveTo"]) && AutoCount.Converter.ToDecimal(selectedrow["IncentiveTo"]) > AutoCount.Converter.ToDecimal(selectedrow["IncentiveFrom"]))
                                {
                                    AutoCount.AppMessage.ShowMessage("Input has been set in the previous range. Please try again.");
                                    selectedrow["IncentiveTo"] = DBNull.Value;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
