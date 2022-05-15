using AutoCount.Authentication;
using AutoCount.Data;
using AutoCount.Report;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daxonet.BintangPackaging.CommissionReport._Plugin.NewReportType
{
    public class CommissionReportCmd
    {
        DBSetting myDBSetting;
        UserSession myUserSession;

        public static CommissionReportCmd Create(UserSession userSession)
        {
            return new CommissionReportCmd() { myDBSetting = userSession.DBSetting, myUserSession = userSession };
        }

        private CommissionReportCmd()
        { }

        public object GetReportDesignerDataSource()
        {
            DataTable SalesAgent = new DataTable();
            SalesAgent.TableName = "Sales Agent";

            DataTable Commission = new DataTable();
            Commission.TableName = "Commission";

            DataTable Incentive = new DataTable();
            Incentive.TableName = "Incentive";

            DataTable IVtable = new DataTable();
            IVtable.TableName = "Invoice";

            DataTable DNtable = new DataTable();
            DNtable.TableName = "Debit Note";

            DataTable CNtable = new DataTable();
            CNtable.TableName = "Credit Note";

            SalesAgent.Columns.Add("Month", typeof(DateTime));
            SalesAgent.Columns.Add("SalesAgent", typeof(string));
            SalesAgent.Columns.Add("MonthlySalesTarget", typeof(decimal));
            SalesAgent.Columns.Add("MonthlySalesAchieved", typeof(decimal));
            SalesAgent.Columns.Add("SalesResult", typeof(string));

            Commission.Columns.Add("SalesAgent", typeof(string));
            Commission.Columns.Add("CommissionFromDay", typeof(DateTime));
            Commission.Columns.Add("CommissionToDay", typeof(DateTime));
            Commission.Columns.Add("TotalPaymentReceived", typeof(decimal));
            Commission.Columns.Add("Percentage", typeof(decimal));
            Commission.Columns.Add("Commission", typeof(decimal));

            Incentive.Columns.Add("SalesAgent", typeof(string));
            Incentive.Columns.Add("IncentiveFromDay", typeof(DateTime));
            Incentive.Columns.Add("IncentiveToDay", typeof(DateTime));
            Incentive.Columns.Add("TotalSalesReceived", typeof(decimal));
            Incentive.Columns.Add("Percentage2", typeof(decimal));
            Incentive.Columns.Add("Incentive", typeof(decimal));

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



            DocumentReportDataSet dsReport = new DocumentReportDataSet(myUserSession, "Commission By Sales Agent Report", "Master");
            dsReport.Tables.Add(IVtable);
            dsReport.Tables.Add(DNtable);
            dsReport.Tables.Add(CNtable);
            dsReport.AddDefaultTables();
            return dsReport;
        }
    }
}
