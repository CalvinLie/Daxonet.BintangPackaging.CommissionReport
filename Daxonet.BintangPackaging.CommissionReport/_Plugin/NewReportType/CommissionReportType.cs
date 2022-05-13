using AutoCount.Authentication;
using AutoCount.Report;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daxonet.BintangPackaging.CommissionReport._Plugin.NewReportType
{
    //class CommissionReportType : BaseReportTypeHandler
    //{
    //    public override void BeforePrint(XtraReport report, PrintEventArgs e)
    //    {
    //        ReportFormatter formatter = new ReportFormatter(((BaseReport)report).DBSetting);
    //        formatter.AddColumnFormat("DocDate", FormatStringType.Date);
    //        formatter.InitReport(report);
    //        base.BeforePrint(report, e);
    //    }

    //    public override object GetDesignerDataSource(UserSession userSession)
    //    {
    //        return CollectionReportCmd.Create(userSession).GetReportDesignerDataSource();
    //    }
    //}
}
