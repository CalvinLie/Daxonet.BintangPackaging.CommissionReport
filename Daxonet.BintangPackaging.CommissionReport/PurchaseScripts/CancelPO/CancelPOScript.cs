using System;

namespace Daxonet.BintangPackaging.CommissionReport
{
    /// <summary>
    /// CancelPOScript contains all event handler which will be called from CancelPO.
    /// </summary>
    public class CancelPOScript
    {
        #region Logic events

        /// <summary>
		/// Occurs when any of the detail column changed
		/// </summary>
		/// <param name="e">The event argument</param>
		public void OnDetailColumnChanged(AutoCount.Invoicing.Purchase.CancelPO.CancelPODetailColumnChangedEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when any of the master column changed
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnMasterColumnChanged(AutoCount.Invoicing.Purchase.CancelPO.CancelPOMasterColumnChangedEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to initialize a new document
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewDocument(AutoCount.Invoicing.Purchase.CancelPO.CancelPOEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to initialize a new detail row
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewDetail(AutoCount.Invoicing.Purchase.CancelPO.CancelPONewDetailEventArgs e)
        {
        }

        /// <summary>
        /// Occurs while a detail item is deleting, e.CurrentDetailRecord is the detail record going to be deleted
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnDetailDeleting(AutoCount.Invoicing.Purchase.CancelPO.CancelPODetailDeletingEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a detail item is deleted
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnDetailDeleted(AutoCount.Invoicing.Purchase.CancelPO.CancelPODetailDeletedEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to initialize a new item package row
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewItemPackage(AutoCount.Invoicing.Purchase.CancelPO.CancelPONewItemPackageEventArgs e)
        {
        }

        public void OnAssignNewItemPackageDetail(AutoCount.Invoicing.Purchase.CancelPO.CancelPOAssignNewItemPackageDetailEventArgs e)
        {
        }

        public void OnPackageDetailColumnChanged(AutoCount.Invoicing.Purchase.CancelPO.CancelPOPackageDetailColumnChangedEventArgs e)
        {
        }

        public void BeforeNewDetail(AutoCount.Invoicing.Purchase.CancelPO.CancelPOBeforeNewDetailEventArgs e)
        {
        }

        public void BeforeNewPackageDetail(AutoCount.Invoicing.Purchase.CancelPO.CancelPOBeforeNewPackageDetailEventArgs e)
        {
        }

        public void OnNewPackageDetail(AutoCount.Invoicing.Purchase.CancelPO.CancelPONewPackageDetailEventArgs e)
        {
        }

        public void OnPackageDetailDeleting(AutoCount.Invoicing.Purchase.CancelPO.CancelPOPackageDetailDeletingEventArgs e)
        {
        }

        public void OnPackageDetailDeleted(AutoCount.Invoicing.Purchase.CancelPO.CancelPOPackageDetailDeletedEventArgs e)
        {
        }

        /// <summary>
		/// Use this event to validate the data before save, if the data is invalid, you can assign your error message to e.ErrorMessage.
		/// </summary>
		/// <param name="e">The event argument</param>
		public void BeforeSave(AutoCount.Invoicing.Purchase.CancelPO.CancelPOBeforeSaveEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to update data to database through the e.DBSetting, which will make your update in transaction control.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnSave(AutoCount.Invoicing.Purchase.CancelPO.CancelPOOnSaveEventArgs e)
        {
        }

        public void OnGetNewDocumentNo(AutoCount.Invoicing.Purchase.CancelPO.CancelPOEventArgs e)
        {
        }

        /// <summary>
		/// Occurs after a document is successfully saved.
		/// </summary>
		/// <param name="e">The event argument</param>
		public void AfterSave(AutoCount.Invoicing.Purchase.CancelPO.CancelPOEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do checking before delete, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeDelete(AutoCount.Invoicing.Purchase.CancelPO.CancelPOBeforeDeleteEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to update/delete data to database through the e.DBSetting, which will make your update in transaction control.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnDelete(AutoCount.Invoicing.Purchase.CancelPO.CancelPOOnDeleteEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a document is successfully deleted.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterDelete(AutoCount.Invoicing.Purchase.CancelPO.CancelPOEventArgs e)
        {
        }

        public void BeforeEdit(AutoCount.Invoicing.Purchase.CancelPO.CancelPOBeforeEditEventArgs e)
        {
        }

        /// <summary>
        /// Occurs whenever partial transfer occur
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnPartialTransfer(AutoCount.Invoicing.Purchase.CancelPO.CancelPOPartialTransferEventArgs e)
        {
        }

        /// <summary>
        /// Occurs whenever a document is full transfer using option 1
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFullTransferOption1(AutoCount.Invoicing.Purchase.CancelPO.CancelPOFullTransferOption1EventArgs e)
        {
        }

        /// <summary>
        /// Occurs whenever a document is full transfer using option 2
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFullTransferOption2(AutoCount.Invoicing.Purchase.CancelPO.CancelPOFullTransferOption2EventArgs e)
        {
        }

        public void OnFullTransferOption3(AutoCount.Invoicing.Purchase.CancelPO.CancelPOFullTransferOption3EventArgs e)
        {
        }

        /// <summary>
        /// Occurs when SubTotal needs to be recalculated
        /// </summary>
        /// <param name="e">The event argument, if you have handled this event, set e.Handled to true</param>
        public void CalcSubTotal(AutoCount.Invoicing.Purchase.CancelPO.CancelPOCalcSubTotalEventArgs e)
        {
        }

        #endregion

        #region Edit Form events

        /// <summary>
        /// Use this event to do form initialization
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormInitialize(AutoCount.Invoicing.Purchase.CancelPO.FormCancelPOEntry.FormInitializeEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when the form data binding occurred
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnDataBinding(AutoCount.Invoicing.Purchase.CancelPO.FormCancelPOEntry.FormDataBindingEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when the form is shown
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormShow(AutoCount.Invoicing.Purchase.CancelPO.FormCancelPOEntry.FormShowEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do form finalization
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormClosed(AutoCount.Invoicing.Purchase.CancelPO.FormCancelPOEntry.FormClosedEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when the edit is switch from View mode to Edit mode
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnSwitchToEditMode(AutoCount.Invoicing.Purchase.CancelPO.FormCancelPOEntry.FormEventArgs e)
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
        public void BeforeSave(AutoCount.Invoicing.Purchase.CancelPO.FormCancelPOEntry.FormBeforeSaveEventArgs e)
        {
        }

        #endregion
    }
}
