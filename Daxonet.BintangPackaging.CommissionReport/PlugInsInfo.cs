using AutoCount.Authentication;
using AutoCount.PlugIn;
using Daxonet.Autocount.Plugin.Licensing;
using Daxonet.BintangPackaging.CommissionReport._Plugin.NewReportType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Daxonet.BintangPackaging.CommissionReport
{
    internal class PlugInsInfo : BasePlugIn
    {
        public readonly static Guid PlugInsGuid = new Guid("49e13134-cc01-4a2e-82e2-cd09de71e961");

        public static bool Registered { get; private set; }

        public PlugInsInfo()
            : base(
                PlugInsGuid,
                  "Daxonet.BintangPackaging.CommissionReport", "-debug", "ac2support@daxonet.com")
        {
            SetManufacturer("Credential Daxonet Solutions Sdn Bhd");
            SetManufacturerUrl("www.daxonet.com");
            SetCopyright("Copyright 2022 © Credential Daxonet Solutions Sdn Bhd");
            SetSalesPhone("0163860090");
            SetSupportPhone("0163860090");
            SetMinimumAccountingVersionRequired("2.0.0.55");
            SetDevExpressComponentVersionRequired("19.2.10");
            SetIsFreeLicense(false);

            LicesingController.PublicKey = "AMUFCgAIZ8kMufl9HJySALBF765tIo0lcRh7BSx342uPDAI=";
            LicesingController.NoLicenseExpiryDate = DateTime.Parse("5/11/2022 2:22:17 PM", System.Globalization.CultureInfo.InvariantCulture).AddMonths(1);
        }

        public override bool BeforeLoad(BeforeLoadArgs e)
        {
            e.SystemReportFilename = "report.dat";
            var dbSetting = e.DBSetting;
            DBSetup db = DBSetup.Create(dbSetting);
            db.RegisterCommonSetupTable();
            db.RegisterTable("DaxIncentive", @"CREATE TABLE DaxIncentive(
            DocKey bigint not Null,
			IncentiveFrom decimal(20,2) Null,
			IncentiveTo decimal(20,2) Null,
			Percentage decimal(5,2) Null,
            CONSTRAINT [DaxIncentive_DocKey_PK] PRIMARY KEY CLUSTERED 
             (
             [DocKey] ASC
             )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
             )");

            db.RegisterTable("DaxCommission", @"CREATE TABLE DaxCommission(
            DocKey bigint not Null,
			KPIFrom int Null,
			KPITo int Null,
			Percentage decimal(5,2) Null,
            CONSTRAINT [DaxCommission_DocKey_PK] PRIMARY KEY CLUSTERED 
             (
             [DocKey] ASC
             )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
             )");

            db.RegisterTable("DaxSalesAgent", @"CREATE TABLE DaxSalesAgent(
            DocKey bigint not Null,
			SalesAgent varchar(50) Null,
            Month date,
            SalesTarget decimal(20,2) not Null,
            SalesAchieved decimal(20,2) not Null,
            Result text,
            CONSTRAINT [DaxSalesAgent_DocKey_PK] PRIMARY KEY CLUSTERED 
             (
             [DocKey] ASC
             )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
            )");

            e.MainMenuCaption = "Commission Report";
            AccessRightMap.AddAccessRightRecord(new AccessRightRecord("DAXONET_COMMISSION_REPORT", "", "Commission Report"));
            AccessRightMap.AddAccessRightRecord(new AccessRightRecord("DAXONET_COMMISSION_REPORT_MAINTENANCESETTING", "DAXONET_COMMISSION_REPORT", "Commission Report Setting"));

            //db.RegisterDecimalField("SalesAgent", "UDF_SalesTarget", "Sales Target", 2, 18);
            AutoCount.Report.AutoCountReport.RegisterReportType("Commission By Sales Agent Report", typeof(CommissionReportType));

            //var myDBSetup = DBSetup.Create(e.UserSession.DBSetting);
            //if (!myDBSetup.SetupDatabase(Name))
            //    return false;
            return base.BeforeLoad(e);
        }

        public override void AfterLogin(AfterLoginArgs e)
        {
            if (!Registered)
            {
                AutoCount.AppMessage.ShowErrorMessage("Plugin Daxonet.BintangPackaging.CommissionReport had expired and stop working, kindly extend it before continue to use.");
                e.Visible = false;
            }
            //e.Visible = false;
            base.AfterLogin(e);
        }

        public override void GetLicenseStatus(LicenseStatusArgs e)
        {
            LicesingController.GetLicenseStatus(e);
            Registered = e.IsRegistered();
            if (Registered && e.LicenseStatus == LicenseStatus.TemporaryLicense && DateTime.Today.AddDays(7) > LicesingController.NoLicenseExpiryDate)
            {
                AutoCount.AppMessage.ShowWarningMessage("Plugin Daxonet.BintangPackaging.CommissionReport will license expire on " + LicesingController.NoLicenseExpiryDate.ToString("yyyy-MMM-dd") + ", kindly extend it before the license expires.");
            }
        }


        /*In order to use AutoCount API to let debtor which set credit control to block when over creadit limit to create sales invoice,
         * you need manually add event as below to handle credit control, either a default event or a custom event, ortherwise will hit violate credit limit error
         
        public void NewSaleInvoice(AutoCount.Authentication.UserSession userSession, SaleInvoiceSource source)
        {
            AutoCount.Invoicing.Sales.Invoice.InvoiceCommand cmd =
                AutoCount.Invoicing.Sales.Invoice.InvoiceCommand.Create(userSession, userSession.DBSetting);
            AutoCount.Invoicing.Sales.Invoice.Invoice doc = cmd.AddNew();

	    //use below either one method
	    //default event (can prompt those default violate credit limit and overdue limit form when over limit)
            doc.ViolateCreditLimitEvent += new AutoCount.Invoicing.Sales.ViolateCreditLimitEventHandler(AutoCount.Invoicing.Sales.FormViolateCreditLimit.DefaultCreditLimitControlEvent);
            doc.ViolateOverdueLimitEvent += new AutoCount.Invoicing.Sales.ViolateOverdueLimitEventHandler(AutoCount.Invoicing.Sales.FormViolateOverdueLimit.DefaultOverdueLimitControlEvent);
	    
	    //custom event
            doc.ViolateCreditLimitEvent += Doc_ViolateCreditLimitEvent;
            doc.ViolateOverdueLimitEvent += Doc_ViolateOverdueLimitEvent;
        }

        private bool Doc_ViolateOverdueLimitEvent(AutoCount.Invoicing.Sales.CreditControl creditcontrol, AutoCount.Invoicing.InvoicingDocument doc)
        {
            return creditcontrol.OverdueLimitExceed <= 0;
        }

        private bool Doc_ViolateCreditLimitEvent(AutoCount.Invoicing.Sales.CreditControl creditcontrol, AutoCount.Invoicing.InvoicingDocument doc)
        {
            return creditcontrol.CreditLimitExceed <= 0;
        }
         
         */

        private void RegisterScript(AutoCount.Data.DBSetting dbSetting)
        {
            #region AP Scripts
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("APAnalysisByDocument", typeof(APAnalysisByDocumentScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("CreditorAgingByAgentReport", typeof(CreditorAgingByAgentScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("CreditorAgingReport", typeof(CreditorAgingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("CreditorStatementReport", typeof(CreditorStatementScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("OutstandingAPDepositReport", typeof(OutstandingAPDepositScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("OutstandingAPInvoiceReport", typeof(OutstandingAPInvoiceScript));

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("APCN", typeof(APCNScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("APCNCommandForm", typeof(APCNCommandFormScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("APCNPrintListingReport", typeof(APCNListingScript));

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("APDeposit", typeof(APDepositScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("APDepositCommandForm", typeof(APDepositCommandFormScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("APDepositPrintListingReport", typeof(APDepositListingScript));

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("APDN", typeof(APDNScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("APDNCommandForm", typeof(APDNCommandFormScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("APDNPrintListingReport", typeof(APDNListingScript));

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("APInvoice", typeof(APInvoiceScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("APInvoiceCommandForm", typeof(APInvoiceCommandFormScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("APInvoicePrintListingReport", typeof(APInvoiceListingScript));

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("APPayment", typeof(APPaymentScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("APPaymentCommandForm", typeof(APPaymentCommandFormScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("APPaymentPrintListingReport", typeof(APPaymentListingScript));
            //AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("SimpleAPPayment", typeof(SimpleAPPaymentScript));

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("APRefund", typeof(APRefundScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("APRefundCommandForm", typeof(APRefundCommandFormScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("APRefundPrintListingReport", typeof(APRefundListingScript));

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("CreditorCommandForm", typeof(CreditorCommandFormScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("Creditor", typeof(CreditorScript));

            #endregion

            #region AR Scripts

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ARAnalysisByDocument", typeof(ARAnalysisByDocumentScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("CommissionByCollectionReport", typeof(CommissionByCollection));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("DebtorAgingByAgentReport", typeof(DebtorAgingByAgentScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("DebtorAgingReport", typeof(DebtorAgingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("DebtorStatementReport", typeof(DebtorStatementScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("OutstandingARDepositReport", typeof(OutstandingARDepositScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("OutstandingARInvoiceReport", typeof(OutstandingARInvoiceScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("OverdueLetterReport", typeof(OverdueLetterScript));

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ARCN", typeof(ARCNScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ARCNCommandForm", typeof(ARCNCommandFormScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ARCNPrintListingReport", typeof(ARCNListingScript));

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ARDeposit", typeof(ARDepositScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ARDepositCommandForm", typeof(ARDepositCommandFormScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ARDepositPrintListingReport", typeof(ARDepositListingScript));

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ARDN", typeof(ARDNScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ARDNCommandForm", typeof(ARDNCommandFormScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ARDNPrintListingReport", typeof(ARDNListingScript));

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ARInvoice", typeof(ARInvoiceScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ARInvoiceCommandForm", typeof(ARInvoiceCommandFormScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ARInvoicePrintListingReport", typeof(ARInvoiceListingScript));

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ARPayment", typeof(ARPaymentScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ARPaymentCommandForm", typeof(ARPaymentCommandFormScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ARPaymentPrintListingReport", typeof(ARPaymentListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("SimpleARPaymentPrintListingReport", typeof(SimpleARPaymentScript));

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ARRefund", typeof(ARRefundScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ARRefundCommandForm", typeof(ARRefundCommandFormScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ARRefundPrintListingReport", typeof(ARRefundListingScript));

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ARAPContra", typeof(ContraScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ARAPContraCommandForm", typeof(ContraCommandFormScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ARAPContraPrintListingReport", typeof(ContraListingScript));

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("DebtorCommandForm", typeof(DebtorCommandFormScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("Debtor", typeof(DebtorScript));

            #endregion

            #region GL Scripts

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("BankRecon", typeof(BankReconScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("BankReconCommandForm", typeof(BankReconCommandFormScript));
            //AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("BankReconEditForm", typeof(BankReconEditFormScript));

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("CB", typeof(CashBookScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("CashBookListing", typeof(CashBookListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("CashBookCommandForm", typeof(CashBookCommandFormScript));
            //AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("CashBookEditForm", typeof(CashBookEditFormScript));

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("JE", typeof(JournalEntryScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("JournalEntryListing", typeof(JournalEntryListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("JournalEntryCommandForm", typeof(JournalEntryCommandFormScript));
            //AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("JournalEntryEditForm", typeof(JournalEntryEditFormScript));

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ChequeListingReport", typeof(ChequeListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("Ledger", typeof(LedgerScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ReturnedChequeListingReport", typeof(ReturnedChequeListingScript));

            #endregion

            #region Inquiry Scripts

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("AccountInquiry", typeof(AccountInquiryScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("BackOrderByUOM", typeof(BackOrderByUOMScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("BackOrder", typeof(BackOrderScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ItemBatchBalanceByLocation", typeof(ItemBatchBalanceByLocationScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ItemBatchBalance", typeof(ItemBatchBalanceScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("Pricing", typeof(PricingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockImage", typeof(StockImageScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockImageInfo", typeof(StockImageInfoScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockItemInquiry", typeof(StockItemInquiryScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockItemReplacement", typeof(StockItemReplacementScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockLevelByUOM", typeof(StockLevelByUOMScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockLevel", typeof(StockLevelScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("UCInquiry", typeof(UCInquiryScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("UCInquiryCSGN", typeof(UCInquiryCSGNScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("UCInquiryStock", typeof(UCInquiryStockScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("UCStockImage", typeof(UCStockImageScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("UTDCosting", typeof(UTDCostingScript));

            #endregion

            #region Invoicing Scripts

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ItemPackageCommandForm", typeof(ItemPackageCommandFormScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ItemPackagePrintListing", typeof(ItemPackageListing));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ItemPackage", typeof(ItemPackageScript));

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("RemoteCreditControl", typeof(ApproveCreditControlScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("FormConfirmInvalidItemQty", typeof(ConfirmInvalidItemQtyScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("PastRecordsEditForm", typeof(PastRecordsEditFormScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("PriceHistory", typeof(PriceHistoryScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("PurchasePriceHistory", typeof(PurchasePriceHistoryScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("SerialNoEntryForm", typeof(SerialNoEntryScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("SerialNoEntrySAForm", typeof(SerialNoEntrySAScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("SerialNoEntryTransferForm", typeof(SerialNoEntryTransferScript));

            #endregion

            #region Maintenance Scripts

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("Accountant", typeof(AccountantMaintenanceScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("Address", typeof(AddressScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("Area", typeof(AreaScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("CNType", typeof(CNTypeScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("CreditorType", typeof(CreditorTypeScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("CurrencyRate", typeof(CurrencyRateScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("Currency", typeof(CurrencyScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("DebtorType", typeof(DebtorTypeScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("DNType", typeof(DNTypeScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("JournalType", typeof(JournalTypeScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("MemberCommand", typeof(MemberCommandFormScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("Member", typeof(MemberScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("PaymentMethod", typeof(PaymentMethodScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("PostingAccountGroup", typeof(PostingAccountGroupScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("PriceCategory", typeof(PriceCategoryScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("Project", typeof(ProjectScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("Department", typeof(DepartmentScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("PurchaseAgent", typeof(PurchaseAgentScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("SalesAgent", typeof(SalesAgentScript));
            //AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("SalesAgentEditForm", typeof(SalesAgentEditFormScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ShippingMethod", typeof(ShippingMethodScripts));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("WithholdingTax", typeof(WithholdingTaxScript));

            #endregion

            #region GST Scripts

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("TaxType", typeof(TaxTypeScript));

            #endregion

            #region Manufacturing Scripts

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("BOMOptional", typeof(BOMOptionalScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("BOMOptionalCommandForm", typeof(BOMOptionalCommandFormScript));

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("CheckBOMMaterial", typeof(CheckBOMMaterialScript));

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ASM", typeof(StockAssemblyScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockAssemblyDetailListing", typeof(StockAssemblyDetailListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockAssemblyListing", typeof(StockAssemblyListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockAssemblyCommandForm", typeof(StockAssemblyCommandFormScript));
            //AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockAssemblyEditForm", typeof(StockAssemblyEditFormScript));

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ASMORDER", typeof(StockAssemblyOrderScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockAssemblyOrderDetailListing", typeof(StockAssemblyOrderDetailListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockAssemblyOrderListing", typeof(StockAssemblyOrderListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockAssemblyOrderCommandForm", typeof(StockAssemblyOrderCommandFormScript));
            //AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockAssemblyOrderEditForm", typeof(StockAssemblyOrderEditFormScript));

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockDisassembly", typeof(StockDisassemblyScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockDisassemblyDetailListing", typeof(StockDisassemblyDetailListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockDisassemblyListing", typeof(StockDisassemblyListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockDisassemblyCommandForm", typeof(StockDisassemblyCommandFormScript));
            //AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockAssemblyOrderEditForm", typeof(StockAssemblyOrderEditFormScript));

            #endregion

            #region Other Scripts

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("DecimalSetting", typeof(DecimalSettingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("MainForm", typeof(MainFormScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ReportTool", typeof(ReportToolScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ScanBarCodeControl", typeof(ScanBarCodeControlScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("Startup", typeof(StartupScript));

            #endregion

            #region Purchase Scripts

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("XP", typeof(CancelPOScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("CancelPODetailListing", typeof(CancelPODetailListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("CancelPOListing", typeof(CancelPOListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("CancelPOCommandForm", typeof(CancelPOCommandFormScript));
            //AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("CancelPOEditForm", typeof(CancelPOEditFormScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("CancelPOFind", typeof(CancelPOFindScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("CancelPOSearch", typeof(CancelPOSearchScript));

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("CP", typeof(CashPurchaseScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("CashPurchaseDetailListing", typeof(CashPurchaseDetailListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("CashPurchaseListing", typeof(CashPurchaseListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("CashPurchaseCommandForm", typeof(CashPurchaseCommandFormScript));
            //AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("CashPurchaseEditForm", typeof(CashPurchaseEditFormScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("CashPurchaseFind", typeof(CashPurchaseFindScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("CashPurchaseSearch", typeof(CashPurchaseSearchScript));

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("GR", typeof(GoodsReceivedNoteScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("GoodsReceivedNoteDetailListing", typeof(GoodsReceivedNoteDetailListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("GoodsReceivedNoteListing", typeof(GoodsReceivedNoteListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("GoodsReceivedNoteCommandForm", typeof(GoodsReceivedNoteCommandFormScript));
            //AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("GoodsReceivedNoteEditForm", typeof(GoodsReceivedNoteEditFormScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("GoodsReceivedNoteFind", typeof(GoodsReceivedNoteFindScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("GoodsReceivedNoteSearch", typeof(GoodsReceivedNoteSearchScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("OutstandingGoodsReceivedNoteDetailListing", typeof(OutstandingGoodsReceivedNoteDetailListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("OutstandingGoodsReceivedNoteListing", typeof(OutstandingGoodsReceivedNoteListingScript));

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("GT", typeof(GoodsReturnScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("GoodsReturnDetailListing", typeof(GoodsReturnDetailListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("GoodsReturnListing", typeof(GoodsReturnListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("GoodsReturnCommandForm", typeof(GoodsReturnCommandFormScript));
            //AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("GoodsReturnEditForm", typeof(GoodsReturnEditFormScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("GoodsReturnFind", typeof(GoodsReturnFindScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("GoodsReturnSearch", typeof(GoodsReturnSearchScript));

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("PI", typeof(PurchaseInvoiceScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("PurchaseInvoiceDetailListing", typeof(PurchaseInvoiceDetailListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("PurchaseInvoiceListing", typeof(PurchaseInvoiceListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("PurchaseInvoiceCommandForm", typeof(PurchaseInvoiceCommandFormScript));
            //AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("PurchaseInvoiceEditForm", typeof(PurchaseInvoiceEditFormScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("PurchaseInvoiceFind", typeof(PurchaseInvoiceFindScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("PurchaseInvoiceSearch", typeof(PurchaseInvoiceSearchScript));

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("PO", typeof(PurchaseOrderScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("PurchaseOrderDetailListing", typeof(PurchaseOrderDetailListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("PurchaseOrderListing", typeof(PurchaseOrderListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("PurchaseOrderCommandForm", typeof(PurchaseOrderCommandFormScript));
            //AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("PurchaseOrderEditForm", typeof(PurchaseOrderEditFormScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("PurchaseOrderFind", typeof(PurchaseOrderFindScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("PurchaseOrderSearch", typeof(PurchaseOrderSearchScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("OutstandingPurchaseOrderDetailListing", typeof(OutstandingPurchaseOrderDetailListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("OutstandingPurchaseOrderListing", typeof(OutstandingPurchaseOrderListingScript));

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("PurchaseRequest", typeof(PurchaseRequestScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("PurchaseRequestDetailListing", typeof(PurchaseRequestDetailListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("PurchaseRequestListing", typeof(PurchaseRequestListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("PurchaseRequestCommandForm", typeof(PurchaseRequestCommandFormScript));
            //AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("PurchaseRequestEditForm", typeof(PurchaseRequestEditFormScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("PurchaseRequestFind", typeof(PurchaseRequestFindScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("PurchaseRequestSearch", typeof(PurchaseRequestSearchScript));

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("PR", typeof(PurchaseReturnScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("PurchaseReturnDetailListing", typeof(PurchaseReturnDetailListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("PurchaseReturnListing", typeof(PurchaseReturnListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("PurchaseReturnCommandForm", typeof(PurchaseReturnCommandFormScript));
            //AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("PurchaseReturnEditForm", typeof(PurchaseReturnEditFormScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("PurchaseReturnFind", typeof(PurchaseReturnFindScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("PurchaseReturnSearch", typeof(PurchaseReturnSearchScript));

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("RQ", typeof(RequestQuotationScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("RequestQuotationDetailListing", typeof(RequestQuotationDetailListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("RequestQuotationListing", typeof(RequestQuotationListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("RequestQuotationCommandForm", typeof(RequestQuotationCommandFormScript));
            //AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("RequestQuotationEditForm", typeof(RequestQuotationEditFormScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("RequestQuotationFind", typeof(RequestQuotationFindScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("RequestQuotationSearch", typeof(RequestQuotationSearchScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("OutstandingRequestQuotationDetailListing", typeof(OutstandingRequestQuotationDetailListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("OutstandingRequestQuotationListing", typeof(OutstandingRequestQuotationListingScript));

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("PurchaseConsignment", typeof(PurchaseConsignmentScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("PurchaseConsignmentDetailListing", typeof(PurchaseConsignmentDetailListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("PurchaseConsignmentListing", typeof(PurchaseConsignmentListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("PurchaseConsignmentCommandForm", typeof(PurchaseConsignmentCommandFormScript));
            //AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("PurchaseConsignmentEditForm", typeof(PurchaseConsignmentEditFormScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("PurchaseConsignmentFind", typeof(PurchaseConsignmentFindScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("PurchaseConsignmentSearch", typeof(PurchaseConsignmentSearchScript));

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("OutstandingSupplierConsignment", typeof(OutstandingPurchaseConsignmentScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("OutstandingPurchaseConsignmentListing", typeof(OutstandingPurchaseConsignmentListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("OutstandingPurchaseConsignmentDetailListing", typeof(OutstandingPurchaseConsignmentDetailListingScript));

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("PurchaseConsignmentReturn", typeof(PurchaseConsignmentReturnScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("PurchaseConsignmentReturnDetailListing", typeof(PurchaseConsignmentReturnDetailListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("PurchaseConsignmentReturnListing", typeof(PurchaseConsignmentReturnListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("PurchaseConsignmentReturnCommandForm", typeof(PurchaseConsignmentReturnCommandFormScript));
            //AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("PurchaseConsignmentReturnEditForm", typeof(PurchaseConsignmentReturnEditFormScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("PurchaseConsignmentReturnFind", typeof(PurchaseConsignmentReturnFindScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("PurchaseConsignmentReturnSearch", typeof(PurchaseConsignmentReturnSearchScript));

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("MonthlyPurchaseAnalysis", typeof(MonthlyPurchaseAnalysisScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("MultiDimensionalPurchaseAnalysis", typeof(MultiDimensionalPurchaseAnalysisScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("PurchaseAnalysisByDocument", typeof(PurchaseAnalysisByDocumentScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("SupplierPriceList", typeof(SupplierPriceListScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("TopBottomPurchaseRanking", typeof(TopBottomPurchaseRankingScript));

            #endregion

            #region Sales Scripts

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("BonusPointAdjustmentDetailListing", typeof(BonusPointAdjustmentDetailListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("BonusPointAdjustmentListing", typeof(BonusPointAdjustmentListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("BonusPointAdjustmentCommandForm", typeof(BonusPointAdjustmentCommandFormScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("BonusPointAdjustmentFind", typeof(BonusPointAdjustmentFindScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("BonusPointAdjustmentSearch", typeof(BonusPointAdjustmentSearchScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("BonusPointADJ", typeof(BonusPointAdjustmentScript));

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("BonusPointRedemptionDetailListing", typeof(BonusPointRedemptionDetailListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("BonusPointRedemptionListing", typeof(BonusPointRedemptionListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("BonusPointRedemptionCommandForm", typeof(BonusPointRedemptionCommandFormScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("BonusPointRedemptionFind", typeof(BonusPointRedemptionFindScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("BonusPointRedemptionSearch", typeof(BonusPointRedemptionSearchScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("BonusPointRedemption", typeof(BonusPointRedemptionScript));

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("XS", typeof(CancelSOScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("CancelSODetailListing", typeof(CancelSODetailListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("CancelSOListing", typeof(CancelSOListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("CancelSOCommandForm", typeof(CancelSOCommandFormScript));
            //AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("CancelSOEditForm", typeof(CancelSOEditFormScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("CancelSOFind", typeof(CancelSOFindScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("CancelSOSearch", typeof(CancelSOSearchScript));

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("CS", typeof(CashSaleScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("CashSaleDetailListing", typeof(CashSaleDetailListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("CashSaleListing", typeof(CashSaleListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("CashSaleCommandForm", typeof(CashSaleCommandFormScript));
            //AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("CashSaleEditForm", typeof(CashSaleEditFormScript));
            //AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("POSCashSaleEditForm", typeof(POSCashSaleEditFormScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("CashSaleFind", typeof(CashSaleFindScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("CashSaleSearch", typeof(CashSaleSearchScript));

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("CSGN", typeof(ConsignmentScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ConsignmentDetailListing", typeof(ConsignmentDetailListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ConsignmentListing", typeof(ConsignmentListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ConsignmentCommandForm", typeof(ConsignmentCommandFormScript));
            //AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ConsignmentEditForm", typeof(ConsignmentEditFormScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ConsignmentFind", typeof(ConsignmentFindScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ConsignmentSearch", typeof(ConsignmentSearchScript));

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("OutstandingConsignment", typeof(OutstandingConsignmentScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("OutstandingConsignmentListing", typeof(OutstandingConsignmentListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("OutstandingConsignmentDetailListing", typeof(OutstandingConsignmentListingScript));

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ConsignmentReturn", typeof(ConsignmentReturnScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ConsignmentReturnDetailListing", typeof(ConsignmentReturnDetailListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ConsignmentReturnListing", typeof(ConsignmentReturnListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ConsignmentReturnCommandForm", typeof(ConsignmentReturnCommandFormScript));
            //AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ConsignmentReturnEditForm", typeof(ConsignmentReturnEditFormScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ConsignmentReturnFind", typeof(ConsignmentReturnFindScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ConsignmentReturnSearch", typeof(ConsignmentReturnSearchScript));

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("CN", typeof(CreditNoteScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("CreditNoteDetailListing", typeof(CreditNoteDetailListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("CreditNoteListing", typeof(CreditNoteListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("CreditNoteCommandForm", typeof(CreditNoteCommandFormScript));
            //AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("CreditNoteEditForm", typeof(CreditNoteEditFormScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("CreditNoteFind", typeof(CreditNoteFindScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("CreditNoteSearch", typeof(CreditNoteSearchScript));

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("DN", typeof(DebitNoteScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("DebitNoteDetailListing", typeof(DebitNoteDetailListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("DebitNoteListing", typeof(DebitNoteListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("DebitNoteCommandForm", typeof(DebitNoteCommandFormScript));
            //AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("DebitNoteEditForm", typeof(DebitNoteEditFormScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("DebitNoteFind", typeof(DebitNoteFindScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("DebitNoteSearch", typeof(DebitNoteSearchScript));

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("DO", typeof(DeliveryOrderScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("DeliveryOrderDetailListing", typeof(DeliveryOrderDetailListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("DeliveryOrderListing", typeof(DeliveryOrderListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("DeliveryOrderCommandForm", typeof(DeliveryOrderCommandFormScript));
            //AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("DeliveryOrderEditForm", typeof(DeliveryOrderEditFormScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("DeliveryOrderFind", typeof(DeliveryOrderFindScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("DeliveryOrderSearch", typeof(DeliveryOrderSearchScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("OutstandingDeliveryOrderDetailListing", typeof(OutstandingDeliveryOrderDetailListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("OutstandingDeliveryOrderListing", typeof(OutstandingDeliveryOrderListingScript));

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("DR", typeof(DeliveryReturnScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("DeliveryReturnDetailListing", typeof(DeliveryReturnDetailListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("DeliveryReturnListing", typeof(DeliveryReturnListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("DeliveryReturnCommandForm", typeof(DeliveryReturnCommandFormScript));
            //AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("DeliveryReturnEditForm", typeof(DeliveryReturnEditFormScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("DeliveryReturnFind", typeof(DeliveryReturnFindScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("DeliveryReturnSearch", typeof(DeliveryReturnSearchScript));

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("IV", typeof(InvoiceScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("InvoiceDetailListing", typeof(InvoiceDetailListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("InvoiceListing", typeof(InvoiceListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("InvoiceCommandForm", typeof(InvoiceCommandFormScript));
            //AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("InvoiceEditForm", typeof(InvoiceEditFormScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("InvoiceFind", typeof(InvoiceFindScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("InvoiceSearch", typeof(InvoiceSearchScript));

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("QT", typeof(QuotationScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("QuotationDetailListing", typeof(QuotationDetailListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("QuotationListing", typeof(QuotationListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("QuotationCommandForm", typeof(QuotationCommandFormScript));
            //AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("QuotationEditForm", typeof(QuotationEditFormScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("QuotationFind", typeof(QuotationFindScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("QuotationSearch", typeof(QuotationSearchScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("OutstandingQuotationDetailListing", typeof(OutstandingQuotationDetailListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("OutstandingQuotationListing", typeof(OutstandingQuotationListingScript));

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("SO", typeof(SalesOrderScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("SalesOrderDetailListing", typeof(SalesOrderDetailListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("SalesOrderListing", typeof(SalesOrderListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("SalesOrderCommandForm", typeof(SalesOrderCommandFormScript));
            //AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("SalesOrderEditForm", typeof(SalesOrderEditFormScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("SalesOrderFind", typeof(SalesOrderFindScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("SalesOrderSearch", typeof(QuotationSearchScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("OutstandingSalesOrderDetailListing", typeof(OutstandingSalesOrderDetailListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("OutstandingSalesOrderListing", typeof(SalesOrderOutstandingListingScript));

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("CustomerPriceList", typeof(CustomerPriceListScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("FocQuantityAnalysisByDocument", typeof(FocQuantityAnalysisByDocumentScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("MonthlySalesAnalysis", typeof(MonthlySalesAnalysisScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("MultiDimensionalSalesAnalysis", typeof(MultiDimensionalSalesAnalysisScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("PriceHistoryReport", typeof(PriceHistoryReportScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ProfitLossOfDocument", typeof(ProfitLossOfDocumentScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("SalesAnalysisByDocument", typeof(SalesAnalysisByDocumentScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("SalesProfitCalculator", typeof(SalesProfitCalculatorScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("TopBottomSalesRanking", typeof(TopBottomSalesRankingScript));

            #endregion

            #region Stock Script

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("Item", typeof(ItemMaintenanceScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("OldItemDataAccess", typeof(OldItemDataAccessScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ItemDataAccess", typeof(ItemDataAccessScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("OldItemCommand", typeof(OldItemCommandScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ItemCommand", typeof(ItemCommandScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ItemListing", typeof(ItemListingScript));
            //AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ItemEditForm", typeof(ItemEditFormScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ItemSearch", typeof(ItemSeachScript));

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ItemBOM", typeof(ItemBOMScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ItemBOMCommandForm", typeof(ItemBOMCommandFormScript));
            //AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ItemBOMEditForm", typeof(ItemBOMEditFormScript));

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ItemBrand", typeof(ItemBrandScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ItemBrandCommand", typeof(ItemBrandCommandFormScript));

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ItemCategory", typeof(ItemCategoryScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ItemCategoryCommand", typeof(ItemCategoryCommandFormScript));

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ItemClass", typeof(ItemClassScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ItemClassCommand", typeof(ItemClassCommandFormScript));

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ItemGroup", typeof(ItemGroupScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ItemGroupCommand", typeof(ItemGroupCommand));
            //AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ItemGroupEditForm", typeof(ItemGroupEditFormScript));

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ItemType", typeof(ItemTypeScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ItemTypeCommand", typeof(ItemTypeCommand));
            //AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ItemTypeEditForm", typeof(ItemTypeEditFormScript));

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("Location", typeof(LocationScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("LocationCommandForm", typeof(LocationCommandFormScript));

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ADJ", typeof(StockAdjustmentScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockAdjustmentDetailListing", typeof(StockAdjustmentDetailListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockAdjustmentListing", typeof(StockAdjustmentListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockAdjustmentCommandForm", typeof(StockAdjustmentCommandFormScript));
            //AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockAdjustmentEditForm", typeof(StockAdjustmentEditFormScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockAdjustmentFind", typeof(StockAdjustmentFindScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockAdjustmentSearch", typeof(StockAdjustmentSearchScript));

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ISS", typeof(StockIssueScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockIssueDetailListing", typeof(StockIssueDetailListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockIssueListing", typeof(StockIssueListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockIssueCommandForm", typeof(StockIssueCommandFormScript));
            //AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockIssueEditForm", typeof(StockIssueEditFormScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockIssueFind", typeof(StockIssueFindScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockIssueSearch", typeof(StockIssueSearchScript));

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("RCV", typeof(StockReceiveScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockReceiveDetailListing", typeof(StockReceiveDetailListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockReceiveListing", typeof(StockReceiveListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockReceiveCommandForm", typeof(StockReceiveCommandFormScript));
            //AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockReceiveEditForm", typeof(StockReceiveEditFormScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockReceiveFind", typeof(StockReceiveFindScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockReceiveSearch", typeof(StockReceiveSearchScript));

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockTake", typeof(StockTakeScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockTakeDetailListing", typeof(StockTakeDetailListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockTakeListing", typeof(StockTakeListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockTakeCommandForm", typeof(StockTakeCommandFormScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockTakeFind", typeof(StockTakeFindScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockTakeSearch", typeof(StockTakeSearchScript));

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("XFER", typeof(StockTransferScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockTransferDetailListing", typeof(StockTransferDetailListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockTransferListing", typeof(StockTransferListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockTransferCommandForm", typeof(StockTransferCommandFormScript));
            //AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockTransferEditForm", typeof(StockTransferEditFormScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockTransferFind", typeof(StockTransferFindScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockTransferSearch", typeof(StockTransferSearchScript));

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("UOMConv", typeof(StockUOMConversionScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockUOMConversionDetailListing", typeof(StockUOMConversionDetailListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockUOMConversionListing", typeof(StockUOMConversionListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockUOMConversionCommandForm", typeof(StockUOMConversionCommandFormScript));
            //AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockUOMConversionEditForm", typeof(StockUOMConversionEditFormScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockUOMConversionFind", typeof(StockUOMConversionFindScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockUOMConversionSearch", typeof(StockUOMConversionSearchScript));

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("UpdateCost", typeof(StockUpdateCostScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockUpdateCostDetailListing", typeof(StockUpdateCostDetailListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockUpdateCostListing", typeof(StockUpdateCostListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockUpdateCostCommandForm", typeof(StockUpdateCostCommandFormScript));
            //AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockUpdateCostEditForm", typeof(StockUpdateCostEditFormScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockUpdateCostFind", typeof(StockUpdateCostFindScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockUpdateCostSearch", typeof(StockUpdateCostSearchScript));

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("WOFF", typeof(StockWriteOffScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockWriteOffDetailListing", typeof(StockWriteOffDetailListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockWriteOffListing", typeof(StockWriteOffListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockWriteOffCommandForm", typeof(StockWriteOffCommandFormScript));
            //AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockWriteOffEditForm", typeof(StockWriteOffEditFormScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockWriteOffFind", typeof(StockWriteOffFindScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockWriteOffSearch", typeof(StockWriteOffSearchScript));

            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("DocumentItemTransactionListing", typeof(DocumentItemTransactionListingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ExpiredItemBatch", typeof(ExpiredItemBatchScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("InventoryPhysicalWorksheet", typeof(InventoryPhysicalWorksheetScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("InventoryPhysicalWorksheetByConsignment", typeof(InventoryPhysicalWorksheetByConsignmentScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ItemProfitMargin", typeof(ItemProfitMarginScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("PrintBarCode", typeof(PrintBarCodeScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("ReorderAdvice", typeof(ReorderAdviceScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockAging", typeof(StockAgingScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockBalanceByLocation", typeof(StockBalanceByLocationScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockBalance", typeof(StockBalanceScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockCard", typeof(StockCardScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockMovement", typeof(StockMovementScript));
            AutoCount.Scripting.ScriptManager.GetOrCreate(dbSetting).RegisterByType("StockStatus", typeof(StockStatusScript));

            #endregion                
        }
    }
}
