using System;

namespace Daxonet.BintangPackaging.CommissionReport
{
    /// <summary>
    /// CashSaleScript contains all event handler which will be called from CashSale.
    /// </summary>
    public class CashSaleScript
    {
        #region Logic events

        /// <summary>
        /// Occurs when any of the detail column changed
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnDetailColumnChanged(AutoCount.Invoicing.Sales.CashSale.CashSaleDetailColumnChangedEventArgs e)
        {

        }

        /// <summary>
        /// Occurs when any of the master column changed
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnMasterColumnChanged(AutoCount.Invoicing.Sales.CashSale.CashSaleMasterColumnChangedEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to initialize a new document
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewDocument(AutoCount.Invoicing.Sales.CashSale.CashSaleEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to initialize a new detail row
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewDetail(AutoCount.Invoicing.Sales.CashSale.CashSaleNewDetailEventArgs e)
        {
        }

        /// <summary>
        /// Occurs while a detail item is deleting, e.CurrentDetailRecord is the detail record going to be deleted
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnDetailDeleting(AutoCount.Invoicing.Sales.CashSale.CashSaleDetailDeletingEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a detail item is deleted
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnDetailDeleted(AutoCount.Invoicing.Sales.CashSale.CashSaleDetailDeletedEventArgs e)
        {
        }

        /// <summary>
		/// Use this event to initialize a new item package row
		/// </summary>
		/// <param name="e">The event argument</param>
		public void OnNewItemPackage(AutoCount.Invoicing.Sales.CashSale.CashSaleNewItemPackageEventArgs e)
        {
        }

        /// <summary>
		/// Use this event to initialize a new item package row
		/// </summary>
		/// <param name="e">The event argument</param>
		public void OnAssignNewItemPackageDetail(AutoCount.Invoicing.Sales.CashSale.CashSaleAssignNewItemPackageDetailEventArgs e)
        {
        }

        /// <summary>
		/// Use this event to initialize a new item package row
		/// </summary>
		/// <param name="e">The event argument</param>
		public void OnPackageDetailColumnChanged(AutoCount.Invoicing.Sales.CashSale.CashSalePackageDetailColumnChangedEventArgs e)
        {
        }

        /// <summary>
		/// Use this event to initialize a new item package row
		/// </summary>
		/// <param name="e">The event argument</param>
		public void BeforeNewDetail(AutoCount.Invoicing.Sales.CashSale.CashSaleBeforeNewDetailEventArgs e)
        {
        }

        /// <summary>
		/// Use this event to initialize a new item package row
		/// </summary>
		/// <param name="e">The event argument</param>
		public void BeforeNewPackageDetail(AutoCount.Invoicing.Sales.CashSale.CashSaleBeforeNewPackageDetailEventArgs e)
        {
        }

        /// <summary>
		/// Use this event to initialize a new item package row
		/// </summary>
		/// <param name="e">The event argument</param>
		public void OnNewPackageDetail(AutoCount.Invoicing.Sales.CashSale.CashSaleNewPackageDetailEventArgs e)
        {
        }

        /// <summary>
		/// Use this event to initialize a new item package row
		/// </summary>
		/// <param name="e">The event argument</param>
		public void OnPackageDetailDeleting(AutoCount.Invoicing.Sales.CashSale.CashSalePackageDetailDeletingEventArgs e)
        {
        }

        /// <summary>
		/// Use this event to initialize a new item package row
		/// </summary>
		/// <param name="e">The event argument</param>
		public void OnPackageDetailDeleted(AutoCount.Invoicing.Sales.CashSale.CashSalePackageDetailDeletedEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to validate the data before save, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeSave(AutoCount.Invoicing.Sales.CashSale.CashSaleBeforeSaveEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to update data to database through the e.DBSetting, which will make your update in transaction control.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnSave(AutoCount.Invoicing.Sales.CashSale.CashSaleOnSaveEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to update data to database through the e.DBSetting, which will make your update in transaction control.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnGetNewDocumentNo(AutoCount.Invoicing.Sales.CashSale.CashSaleEventArgs e)
        {
        }

        /// <summary>
		/// Occurs after a document is successfully saved.
		/// </summary>
		/// <param name="e">The event argument</param>
		public void AfterSave(AutoCount.Invoicing.Sales.CashSale.CashSaleEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do checking before delete, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeDelete(AutoCount.Invoicing.Sales.CashSale.CashSaleBeforeDeleteEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to update/delete data to database through the e.DBSetting, which will make your update in transaction control.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnDelete(AutoCount.Invoicing.Sales.CashSale.CashSaleOnDeleteEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a document is successfully deleted.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterDelete(AutoCount.Invoicing.Sales.CashSale.CashSaleEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a document is successfully deleted.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeEdit(AutoCount.Invoicing.Sales.CashSale.CashSaleBeforeEditEventArgs e)
        {
        }

        /// <summary>
		/// Occurs whenever a detail needs to recalculate iteself because of bulk insert
		/// </summary>
		/// <param name="e">The event argument</param>
		public void OnRecalculateDetail(AutoCount.Invoicing.Sales.CashSale.CashSaleRecalculateDetailEventArgs e)
        {
        }

        /// <summary>
        /// Occurs in POS entry when cash payment is paid, the system will get a cash account
        /// </summary>
        /// <param name="e">The event argument</param>
        public string OnGetCashAccount(AutoCount.Invoicing.Sales.CashSale.CashSaleEventArgs e)
        {
            return "";
        }

        /// <summary>
        /// Occurs whenever partial transfer occur
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnPartialTransfer(AutoCount.Invoicing.Sales.CashSale.CashSalePartialTransferEventArgs e)
        {
        }

        /// <summary>
        /// Occurs whenever a document is full transfer using option 1
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFullTransferOption1(AutoCount.Invoicing.Sales.CashSale.CashSaleFullTransferOption1EventArgs e)
        {
        }

        /// <summary>
        /// Occurs whenever a document is full transfer using option 2
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFullTransferOption2(AutoCount.Invoicing.Sales.CashSale.CashSaleFullTransferOption2EventArgs e)
        {
        }

        /// <summary>
        /// Occurs whenever a document is full transfer using option 2
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFullTransferOption3(AutoCount.Invoicing.Sales.CashSale.CashSaleFullTransferOption3EventArgs e)
        {
        }

        /// <summary>
        /// Occurs when SubTotal needs to be recalculated
        /// </summary>
        /// <param name="e">The event argument, if you have handled this event, set e.Handled to true</param>
        public void CalcSubTotal(AutoCount.Invoicing.Sales.CashSale.CashSaleCalcSubTotalEventArgs e)
        {
        }

        #endregion

        #region Edit Form events

        /// <summary>
        /// Use this event to do form initialization
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormInitialize(AutoCount.Invoicing.Sales.CashSale.FormCashSaleEntry.FormInitializeEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when the form data binding occurred
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnDataBinding(AutoCount.Invoicing.Sales.CashSale.FormCashSaleEntry.FormDataBindingEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when the form data binding occurred
        /// </summary>
        /// <param name="e">The event argument</param>
        public void SetCreditControl(AutoCount.Invoicing.Sales.CashSale.FormCashSaleEntry.SetCreditControlEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when the form is shown
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormShow(AutoCount.Invoicing.Sales.CashSale.FormCashSaleEntry.FormShowEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do form finalization
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormClosed(AutoCount.Invoicing.Sales.CashSale.FormCashSaleEntry.FormClosedEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when the edit is switch from View mode to Edit mode
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnSwitchToEditMode(AutoCount.Invoicing.Sales.CashSale.FormCashSaleEntry.FormEventArgs e)
        {
        }

        /// <summary>
        /// Occurs before a detail item is added, you can set Cancel to true to prevent detail item from added.
        /// </summary>
        /// <param name="e"></param>
        public void BeforeAddDetail(AutoCount.Invoicing.Sales.CashSale.FormCashSaleEntry.FormBeforeAddDetailEventArgs e)
        {
        }

        /// <summary>
        /// Occurs before a detail item is added, you can set Cancel to true to prevent detail item from added.
        /// </summary>
        /// <param name="e"></param>
        public void OnValidateItemQty(AutoCount.Invoicing.Sales.CashSale.CashSaleValidateItemQtyEventArgs e)
        {
        }

        /// <summary>
        /// Occurs before a detail item is added, you can set Cancel to true to prevent detail item from added.
        /// </summary>
        /// <param name="e"></param>
        public void OnValidateMinMaxSalesPrice(AutoCount.Invoicing.Sales.CashSale.CashSaleValidateMinMaxSalesPriceEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after copy to a document.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterCopyToNewDocument(AutoCount.Invoicing.Sales.CashSale.FormCashSaleEntry.AfterCopyToNewDocumentEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after copy from other document.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterCopyFromOtherDocument(AutoCount.Invoicing.Sales.CashSale.FormCashSaleEntry.AfterCopyFromOtherDocumentEventArgs e)
        {
        }

        /// <summary>
        /// Occurs before Serial Number Entry form is prompted. If you don't want the Serial Number Entry form to prompt, just set the e.Handled to true.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforePromptSerialNumberEntry(AutoCount.Invoicing.Sales.CashSale.FormCashSaleEntry.BeforePromptSerialNumberEntryEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to control whether allow to print or preview or export before preview is executed.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforePreviewDocument(AutoCount.Report.BeforePreviewDocumentEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do something before save
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeSave(AutoCount.Invoicing.Sales.CashSale.FormCashSaleEntry.FormBeforeSaveEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do something before save
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforePromptPaymentScreen(AutoCount.Invoicing.Sales.CashSale.BeforePromptPaymentScreenEventArgs e)
        {
        }



        #endregion


        //#region POS Edit Form events

        ///// <summary>
        ///// Use this event to do form initialization
        ///// </summary>
        ///// <param name="e">The event argument</param>
        //public void OnFormInitialize(AutoCount.Invoicing.Sales.CashSale.FormPOSCashSaleEntry.FormInitializeEventArgs e)
        //{
        //}

        ///// <summary>
        ///// Occurs when the form data binding occurred
        ///// </summary>
        ///// <param name="e">The event argument</param>
        //public void OnDataBinding(AutoCount.Invoicing.Sales.CashSale.FormPOSCashSaleEntry.FormDataBindingEventArgs e)
        //{
        //}

        ///// <summary>
        ///// Occurs when the form data binding occurred
        ///// </summary>
        ///// <param name="e">The event argument</param>
        //public void SetCreditControl(AutoCount.Invoicing.Sales.CashSale.FormPOSCashSaleEntry.SetCreditControlEventArgs e)
        //{
        //}

        ///// <summary>
        ///// Occurs when the form is shown
        ///// </summary>
        ///// <param name="e">The event argument</param>
        //public void OnFormShow(AutoCount.Invoicing.Sales.CashSale.FormPOSCashSaleEntry.FormShowEventArgs e)
        //{

        //}

        ///// <summary>
        ///// Use this event to do form finalization
        ///// </summary>
        ///// <param name="e">The event argument</param>
        //public void OnFormClosed(AutoCount.Invoicing.Sales.CashSale.FormPOSCashSaleEntry.FormClosedEventArgs e)
        //{
        //}

        ///// <summary>
        ///// Occurs when the edit is switch from View mode to Edit mode
        ///// </summary>
        ///// <param name="e">The event argument</param>
        //public void OnSwitchToEditMode(AutoCount.Invoicing.Sales.CashSale.FormPOSCashSaleEntry.FormEventArgs e)
        //{
        //}

        ///// <summary>
        ///// Occurs before a detail item is added, you can set Cancel to true to prevent detail item from added.
        ///// </summary>
        ///// <param name="e"></param>
        //public void BeforeAddDetail(AutoCount.Invoicing.Sales.CashSale.FormPOSCashSaleEntry.FormBeforeAddDetailEventArgs e)
        //{
        //}

        ///// <summary>
        ///// Occurs after copy to a document.
        ///// </summary>
        ///// <param name="e">The event argument</param>
        //public void AfterCopyToNewDocument(AutoCount.Invoicing.Sales.CashSale.FormPOSCashSaleEntry.AfterCopyToNewDocumentEventArgs e)
        //{
        //}

        ///// <summary>
        ///// Occurs after copy from other document.
        ///// </summary>
        ///// <param name="e">The event argument</param>
        //public void AfterCopyFromOtherDocument(AutoCount.Invoicing.Sales.CashSale.FormPOSCashSaleEntry.AfterCopyFromOtherDocumentEventArgs e)
        //{
        //}

        ///// <summary>
        ///// Occurs before Serial Number Entry form is prompted. If you don't want the Serial Number Entry form to prompt, just set the e.Handled to true.
        ///// </summary>
        ///// <param name="e">The event argument</param>
        //public void BeforePromptSerialNumberEntry(AutoCount.Invoicing.Sales.CashSale.FormPOSCashSaleEntry.BeforePromptSerialNumberEntryEventArgs e)
        //{
        //}

        ///// <summary>
        ///// Use this event to control whether allow to print or preview or export before preview is executed.
        ///// </summary>
        ///// <param name="e">The event argument</param>
        //public void BeforePreviewDocument(AutoCount.Invoicing.Sales.CashSale.FormPOSCashSaleEntry.BeforePreviewDocumentEventArgs e)
        //{
        //}

        ///// <summary>
        ///// Use this event to do something before save
        ///// </summary>
        ///// <param name="e">The event argument</param>
        //public void BeforeSave(AutoCount.Invoicing.Sales.CashSale.FormPOSCashSaleEntry.FormBeforeSaveEventArgs e)
        //{
        //}

        //#endregion
    }
}
