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
    [AutoCount.PlugIn.MenuItem("Monthly Payment Received and Commission", 2, false, "DAXONET_COMMISSION_REPORT_MAINTENANCESETTING", "DAXONET_COMMISSION_REPORT_MAINTENANCESETTING")]
    [AutoCount.Application.SingleInstanceThreadForm]

    public partial class FormCommissionMaintenance : XtraForm
    {
        private DBSetting myDBSetting;
        private UserSession myUserSession;

        public FormCommissionMaintenance(UserSession userSession)
        {
            InitializeComponent();
            this.myUserSession = userSession;
            this.myDBSetting = userSession.DBSetting;
            var commission = myDBSetting.GetDataTable("Select * from DaxCommission", true);
            gridControl1.DataSource = commission;
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
                    myDBSetting.SimpleSaveDataTable(table, "Select * from DaxCommission");
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var table = gridControl1.DataSource == null ? null : gridControl1.DataSource as DataTable;
            if (table != null && table.Rows.Count > 0)
            {
                var selectedrow = GetSelectedDoc();
                if (selectedrow["KPIFrom"] != null && selectedrow["KPIFrom"].ToString() != "" && selectedrow["KPITo"] != null && selectedrow["KPITo"].ToString() != "" && selectedrow["Percentage"] != null && selectedrow["Percentage"].ToString() != "")
                {
                    myDBSetting.SimpleSaveDataTable(table, "Select * from DaxCommission");                    
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
            if (e.Column.FieldName == "KPIFrom")
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
                                if (AutoCount.Converter.ToDecimal(selectedrow["KPIFrom"]) < AutoCount.Converter.ToDecimal(row["KPITo"]) && AutoCount.Converter.ToDecimal(selectedrow["KPIFrom"]) > AutoCount.Converter.ToDecimal(row["KPIFrom"]))
                                {
                                    AutoCount.AppMessage.ShowMessage("Input has been set in the previous range. Please try again.");
                                    selectedrow["KPIFrom"] = DBNull.Value;
                                }
                            }
                        }
                    }
                }
            }
            if (e.Column.FieldName == "KPITo")
            {
                var table = gridControl1.DataSource == null ? null : gridControl1.DataSource as DataTable;
                if (table != null)
                {
                    var selectedrow = GetSelectedDoc();
                    if (selectedrow != null)
                    {
                        if (AutoCount.Converter.ToDecimal(selectedrow["KPIFrom"]) > AutoCount.Converter.ToDecimal(selectedrow["KPITo"]))
                        {
                            AutoCount.AppMessage.ShowMessage("To (Day) cannot be smaller than From (Day)");
                            selectedrow["KPITo"] = DBNull.Value;
                        }

                        var select = table.AsEnumerable().Where(r => r["DocKey"].ToString() != selectedrow["DocKey"].ToString()).ToArray();
                        if (select != null)
                        {
                            foreach (DataRow row in select)
                            {
                                if (AutoCount.Converter.ToDecimal(selectedrow["KPITo"]) < AutoCount.Converter.ToDecimal(row["KPITo"]) && AutoCount.Converter.ToDecimal(selectedrow["KPITo"]) > AutoCount.Converter.ToDecimal(selectedrow["KPIFrom"]))
                                {
                                    AutoCount.AppMessage.ShowMessage("Input has been set in the previous range. Please try again.");
                                    selectedrow["KPITo"] = DBNull.Value;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
