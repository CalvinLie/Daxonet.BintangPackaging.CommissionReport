using System;

namespace Daxonet.BintangPackaging.CommissionReport
{
    /// <summary>
    /// CashPurchaseScript contains all event handler which will be called from CashPurchase.
    /// </summary>
    public class CashPurchaseScript
    {
        #region Logic events

        /// <summary>
		/// Occurs when any of the detail column changed
		/// </summary>
		/// <param name="e">The event argument</param>
		public void OnDetailColumnChanged(AutoCount.Invoicing.Purchase.CashPurchase.CashPurchaseDetailColumnChangedEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when any of the master column changed
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnMasterColumnChanged(AutoCount.Invoicing.Purchase.CashPurchase.CashPurchaseMasterColumnChangedEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to initialize a new document
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewDocument(AutoCount.Invoicing.Purchase.CashPurchase.CashPurchaseEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to initialize a new detail row
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewDetail(AutoCount.Invoicing.Purchase.CashPurchase.CashPurchaseNewDetailEventArgs e)
        {
        }

        /// <summary>
        /// Occurs while a detail item is deleting, e.CurrentDetailRecord is the detail record going to be deleted
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnDetailDeleting(AutoCount.Invoicing.Purchase.CashPurchase.CashPurchaseDetailDeletingEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a detail item is deleted
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnDetailDeleted(AutoCount.Invoicing.Purchase.CashPurchase.CashPurchaseDetailDeletedEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to initialize a new item package row
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewItemPackage(AutoCount.Invoicing.Purchase.CashPurchase.CashPurchaseNewItemPackageEventArgs e)
        {
        }

        public void OnAssignNewItemPackageDetail(AutoCount.Invoicing.Purchase.CashPurchase.CashPurchaseAssignNewItemPackageDetailEventArgs e)
        {
        }

        public void OnPackageDetailColumnChanged(AutoCount.Invoicing.Purchase.CashPurchase.CashPurchasePackageDetailColumnChangedEventArgs e)
        {
        }

        public void BeforeNewDetail(AutoCount.Invoicing.Purchase.CashPurchase.CashPurchaseBeforeNewDetailEventArgs e)
        {
        }

        public void BeforeNewPackageDetail(AutoCount.Invoicing.Purchase.CashPurchase.CashPurchaseBeforeNewPackageDetailEventArgs e)
        {
        }

        public void OnNewPackageDetail(AutoCount.Invoicing.Purchase.CashPurchase.CashPurchaseNewPackageDetailEventArgs e)
        {
        }

        public void OnPackageDetailDeleting(AutoCount.Invoicing.Purchase.CashPurchase.CashPurchasePackageDetailDeletingEventArgs e)
        {
        }

        public void OnPackageDetailDeleted(AutoCount.Invoicing.Purchase.CashPurchase.CashPurchasePackageDetailDeletedEventArgs e)
        {
        }

        /// <summary>
		/// Use this event to validate the data before save, if the data is invalid, you can assign your error message to e.ErrorMessage.
		/// </summary>
		/// <param name="e">The event argument</param>
		public void BeforeSave(AutoCount.Invoicing.Purchase.CashPurchase.CashPurchaseBeforeSaveEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to update data to database through the e.DBSetting, which will make your update in transaction control.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnSave(AutoCount.Invoicing.Purchase.CashPurchase.CashPurchaseOnSaveEventArgs e)
        {
        }

        public void OnGetNewDocumentNo(AutoCount.Invoicing.Purchase.CashPurchase.CashPurchaseEventArgs e)
        {
        }

        /// <summary>
		/// Occurs after a document is successfully saved.
		/// </summary>
		/// <param name="e">The event argument</param>
		public void AfterSave(AutoCount.Invoicing.Purchase.CashPurchase.CashPurchaseEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do checking before delete, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeDelete(AutoCount.Invoicing.Purchase.CashPurchase.CashPurchaseOnDeleteEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to update/delete data to database through the e.DBSetting, which will make your update in transaction control.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnDelete(AutoCount.Invoicing.Purchase.CashPurchase.CashPurchaseOnDeleteEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a document is successfully deleted.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterDelete(AutoCount.Invoicing.Purchase.CashPurchase.CashPurchaseEventArgs e)
        {
        }

        public void BeforeEdit(AutoCount.Invoicing.Purchase.CashPurchase.CashPurchaseBeforeEditEventArgs e)
        {
        }

        /// <summary>
		/// Occurs whenever a detail needs to recalculate iteself because of bulk insert
		/// </summary>
		/// <param name="e">The event argument</param>
		public void OnRecalculateDetail(AutoCount.Invoicing.Purchase.CashPurchase.CashPurchaseRecalculateDetailEventArgs e)
        {
        }

        /// <summary>
        /// Occurs whenever partial transfer occur
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnPartialTransfer(AutoCount.Invoicing.Purchase.CashPurchase.CashPurchasePartialTransferEventArgs e)
        {
        }

        /// <summary>
        /// Occurs whenever a document is full transfer using option 1
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFullTransferOption1(AutoCount.Invoicing.Purchase.CashPurchase.CashPurchaseFullTransferOption1EventArgs e)
        {
        }

        /// <summary>
        /// Occurs whenever a document is full transfer using option 2
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFullTransferOption2(AutoCount.Invoicing.Purchase.CashPurchase.CashPurchaseFullTransferOption2EventArgs e)
        {
        }

        public void OnFullTransferOption3(AutoCount.Invoicing.Purchase.CashPurchase.CashPurchaseFullTransferOption3EventArgs e)
        {
        }

        /// <summary>
        /// Occurs when SubTotal needs to be recalculated
        /// </summary>
        /// <param name="e">The event argument, if you have handled this event, set e.Handled to true</param>
        public void CalcSubTotal(AutoCount.Invoicing.Purchase.CashPurchase.CashPurchaseCalcSubTotalEventArgs e)
        {
        }

        #endregion

        #region Edit Form events

        /// <summary>
        /// Use this event to do form initialization
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormInitialize(AutoCount.Invoicing.Purchase.CashPurchase.FormCashPurchaseEntry.FormInitializeEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when the form data binding occurred
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnDataBinding(AutoCount.Invoicing.Purchase.CashPurchase.FormCashPurchaseEntry.FormDataBindingEventArgs e)
        {
        }


        /// <summary>
        /// Occurs when the form is shown
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormShow(AutoCount.Invoicing.Purchase.CashPurchase.FormCashPurchaseEntry.FormShowEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do form finalization
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormClosed(AutoCount.Invoicing.Purchase.CashPurchase.FormCashPurchaseEntry.FormClosedEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when the edit is switch from View mode to Edit mode
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnSwitchToEditMode(AutoCount.Invoicing.Purchase.CashPurchase.FormCashPurchaseEntry.FormEventArgs e)
        {
        }

        public void OnGetCashAccount(AutoCount.Invoicing.Purchase.CashPurchase.CashPurchaseEventArgs e)
        {
        }

        /// <summary>
        /// Occurs before a detail item is added, you can set Cancel to true to prevent detail item from added.
        /// </summary>
        /// <param name="e"></param>
        public void BeforeAddDetail(AutoCount.Invoicing.Purchase.CashPurchase.FormCashPurchaseEntry.FormBeforeAddDetailEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after copy to a document.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterCopyToNewDocument(AutoCount.Invoicing.Purchase.CashPurchase.FormCashPurchaseEntry.AfterCopyToNewDocumentEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after copy from other document.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterCopyFromOtherDocument(AutoCount.Invoicing.Purchase.CashPurchase.FormCashPurchaseEntry.AfterCopyFromOtherDocumentEventArgs e)
        {
        }

        /// <summary>
        /// Occurs before Serial Number Entry form is prompted. If you don't want the Serial Number Entry form to prompt, just set the e.Handled to true.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforePromptSerialNumberEntry(AutoCount.Invoicing.Purchase.CashPurchase.FormCashPurchaseEntry.BeforePromptSerialNumberEntryEventArgs e)
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
        public void BeforeSave(AutoCount.Invoicing.Purchase.CashPurchase.FormCashPurchaseEntry.FormBeforeSaveEventArgs e)
        {
        }

        #endregion
    }
}
