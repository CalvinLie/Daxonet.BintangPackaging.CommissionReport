using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daxonet.BintangPackaging.CommissionReport._Plugin.NewReportType
{
    [Serializable]
    public class CommissionReportCriteria: AutoCount.SearchFilter.ReportCriteria
    {
        public CommissionReportCriteria(AutoCount.Data.DBSetting dBSetting)
        {
            this.DBSetting = dBSetting;

            this.SalesAgentFilter = new AutoCount.SearchFilter.Filter("A", "SalesAgent", "Sales Agent", AutoCount.SearchFilter.FilterControlType.SalesAgent);
            this.AddFilter(SalesAgentFilter);

            FromDate = DateTime.Today;
            ToDate = FromDate;
        }

        public AutoCount.Data.DBSetting DBSetting { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }

        public AutoCount.SearchFilter.Filter SalesAgentFilter { get; private set; }
    }
}
