using AutoCount.Authentication;
using AutoCount.Controls.FilterUI;
using AutoCount.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Daxonet.BintangPackaging.CommissionReport
{
    public class CommissionByCollection
    {
        //private GridView defaultview;
        //protected UserSession myUserSession;

        /// <summary>
        /// Use this event to do form initialization
        /// </summary>
        /// <param name="sender">The form itself</param>
        /// <param name="e">The event argument</param>
        public void OnFormInitialize(AutoCount.ARAP.CommissionByCollection.FormCommissionByCollection.FormInitializeEventArgs e)
        {
            //var ctrl = e.PanelCriteria.Controls.Find("groupBoxReportOptions", true);
            //if (ctrl != null)
            //{
            //    var groupBoxReportOptions = ctrl[0] as GroupControl;
            //    var gbplugin = new GroupControl();
            //    e.PanelCriteria.Controls.Add(gbplugin);
            //    gbplugin.Name = "gbroplugin";
            //    gbplugin.Text = "Commission Report Options";
            //    gbplugin.Location = new System.Drawing.Point(groupBoxReportOptions.Right + 10, groupBoxReportOptions.Top);
            //    gbplugin.Height = 100;
            //    gbplugin.Width = 600;

            //    var CRbySA = new CheckEdit();
            //    gbplugin.Controls.Add(CRbySA);
            //    CRbySA.Name = "CommissionReportbySalesAgent";
            //    CRbySA.Text = "Commission Report by Sales Agent";
            //    CRbySA.Width = gbplugin.Width;
            //    CRbySA.Location = new System.Drawing.Point(10, 30);

            //    var labelAgentFilter = new LabelControl();
            //    gbplugin.Controls.Add(labelAgentFilter);
            //    labelAgentFilter.Text = "Sales Agent: ";
            //    labelAgentFilter.Location = new System.Drawing.Point(10, 70);

            //    var ucSalesAgentSelector = new UCSalesAgentSelector();
            //    gbplugin.Controls.Add(ucSalesAgentSelector);
            //    ucSalesAgentSelector.Name = "SelectCommissionBySalesAgent";
            //    ucSalesAgentSelector.Text = "Select Commission By Sales Agent";
            //    ucSalesAgentSelector.Location = new System.Drawing.Point(labelAgentFilter.Width + 10, 70);

            //    FieldInfo pi = e.Command.GetType().GetField("myDBSetting", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            //    var myDBSetting = ((DBSetting)pi.GetValue(e.Command));
            //    var myUserSession = new UserSession(myDBSetting);
            //    ucSalesAgentSelector.Initialize(myUserSession, new AutoCount.SearchFilter.Filter("", ""));
            //}
            //defaultview = (GridView)e.GridControl.MainView;
        }

        /// <summary>
        /// Occurs when inquiry function is executed
        /// </summary>
        /// <param name="sender">The form itself</param>
        /// <param name="e">The event argument</param>
        public void OnFormInquiry(AutoCount.ARAP.CommissionByCollection.FormCommissionByCollection.FormInquiryEventArgs e)
        {
            //var ctrl = e.PanelCriteria.Controls.Find("CommissionReportbySalesAgent", true);
            //if (ctrl.Length > 0 && ((CheckEdit)ctrl[0]).Checked)
            //{
            //    if (PlugInsInfo.Registered)
            //    {
                    
            //    }
            //}
        }
    }
}
