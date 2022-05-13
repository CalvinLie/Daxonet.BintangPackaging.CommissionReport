using System;

namespace Daxonet.BintangPackaging.CommissionReport
{
    /// <summary>
    /// GoodsReceivedNoteScript contains all event handler which will be called from GoodsReceivedNote.
    /// </summary>
    public class GoodsReceivedNoteScript
    {
        #region Logic events

        /// <summary>
		/// Occurs when any of the detail column changed
		/// </summary>
		/// <param name="e">The event argument</param>
		public void OnDetailColumnChanged(AutoCount.Invoicing.Purchase.GoodsReceivedNote.GoodsReceivedNoteDetailColumnChangedEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when any of the master column changed
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnMasterColumnChanged(AutoCount.Invoicing.Purchase.GoodsReceivedNote.GoodsReceivedNoteMasterColumnChangedEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to initialize a new document
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewDocument(AutoCount.Invoicing.Purchase.GoodsReceivedNote.GoodsReceivedNoteEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to initialize a new detail row
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewDetail(AutoCount.Invoicing.Purchase.GoodsReceivedNote.GoodsReceivedNoteNewDetailEventArgs e)
        {
        }

        /// <summary>
        /// Occurs while a detail item is deleting, e.CurrentDetailRecord is the detail record going to be deleted
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnDetailDeleting(AutoCount.Invoicing.Purchase.GoodsReceivedNote.GoodsReceivedNoteDetailDeletingEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a detail item is deleted
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnDetailDeleted(AutoCount.Invoicing.Purchase.GoodsReceivedNote.GoodsReceivedNoteDetailDeletedEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to initialize a new item package row
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewItemPackage(AutoCount.Invoicing.Purchase.GoodsReceivedNote.GoodsReceivedNoteNewItemPackageEventArgs e)
        {
        }

        public void OnAssignNewItemPackageDetail(AutoCount.Invoicing.Purchase.GoodsReceivedNote.GoodsReceivedNoteAssignNewItemPackageDetailEventArgs e)
        {
        }

        public void OnPackageDetailColumnChanged(AutoCount.Invoicing.Purchase.GoodsReceivedNote.GoodsReceivedNotePackageDetailColumnChangedEventArgs e)
        {
        }

        public void BeforeNewDetail(AutoCount.Invoicing.Purchase.GoodsReceivedNote.GoodsReceivedNoteBeforeNewDetailEventArgs e)
        {
        }

        public void BeforeNewPackageDetail(AutoCount.Invoicing.Purchase.GoodsReceivedNote.GoodsReceivedNoteBeforeNewPackageDetailEventArgs e)
        {
        }

        public void OnNewPackageDetail(AutoCount.Invoicing.Purchase.GoodsReceivedNote.GoodsReceivedNoteNewPackageDetailEventArgs e)
        {
        }

        public void OnPackageDetailDeleting(AutoCount.Invoicing.Purchase.GoodsReceivedNote.GoodsReceivedNotePackageDetailDeletingEventArgs e)
        {
        }

        public void OnPackageDetailDeleted(AutoCount.Invoicing.Purchase.GoodsReceivedNote.GoodsReceivedNotePackageDetailDeletedEventArgs e)
        {
        }

        /// <summary>
		/// Use this event to validate the data before save, if the data is invalid, you can assign your error message to e.ErrorMessage.
		/// </summary>
		/// <param name="e">The event argument</param>
		public void BeforeSave(AutoCount.Invoicing.Purchase.GoodsReceivedNote.GoodsReceivedNoteBeforeSaveEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to update data to database through the e.DBSetting, which will make your update in transaction control.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnSave(AutoCount.Invoicing.Purchase.GoodsReceivedNote.GoodsReceivedNoteOnSaveEventArgs e)
        {
        }

        public void OnGetNewDocumentNo(AutoCount.Invoicing.Purchase.GoodsReceivedNote.GoodsReceivedNoteEventArgs e)
        {
        }

        /// <summary>
		/// Occurs after a document is successfully saved.
		/// </summary>
		/// <param name="e">The event argument</param>
		public void AfterSave(AutoCount.Invoicing.Purchase.GoodsReceivedNote.GoodsReceivedNoteEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do checking before delete, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeDelete(AutoCount.Invoicing.Purchase.GoodsReceivedNote.GoodsReceivedNoteOnDeleteEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to update/delete data to database through the e.DBSetting, which will make your update in transaction control.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnDelete(AutoCount.Invoicing.Purchase.GoodsReceivedNote.GoodsReceivedNoteOnDeleteEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a document is successfully deleted.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterDelete(AutoCount.Invoicing.Purchase.GoodsReceivedNote.GoodsReceivedNoteEventArgs e)
        {
        }

        public void BeforeEdit(AutoCount.Invoicing.Purchase.GoodsReceivedNote.GoodsReceivedNoteBeforeEditEventArgs e)
        {
        }

        /// <summary>
		/// Occurs whenever a detail needs to recalculate iteself because of bulk insert
		/// </summary>
		/// <param name="e">The event argument</param>
		public void OnRecalculateDetail(AutoCount.Invoicing.Purchase.GoodsReceivedNote.GoodsReceivedNoteRecalculateDetailEventArgs e)
        {
        }

        /// <summary>
        /// Occurs whenever partial transfer occur
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnPartialTransfer(AutoCount.Invoicing.Purchase.GoodsReceivedNote.GoodsReceivedNotePartialTransferEventArgs e)
        {
        }

        /// <summary>
        /// Occurs whenever a document is full transfer using option 1
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFullTransferOption1(AutoCount.Invoicing.Purchase.GoodsReceivedNote.GoodsReceivedNoteFullTransferOption1EventArgs e)
        {
        }

        /// <summary>
        /// Occurs whenever a document is full transfer using option 2
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFullTransferOption2(AutoCount.Invoicing.Purchase.GoodsReceivedNote.GoodsReceivedNoteFullTransferOption2EventArgs e)
        {
        }

        public void OnFullTransferOption3(AutoCount.Invoicing.Purchase.GoodsReceivedNote.GoodsReceivedNoteFullTransferOption3EventArgs e)
        {
        }

        /// <summary>
        /// Occurs when SubTotal needs to be recalculated
        /// </summary>
        /// <param name="e">The event argument, if you have handled this event, set e.Handled to true</param>
        public void CalcSubTotal(AutoCount.Invoicing.Purchase.GoodsReceivedNote.GoodsReceivedNoteCalcSubTotalEventArgs e)
        {
        }

        #endregion

        #region Edit Form events

        /// <summary>
        /// Use this event to do form initialization
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormInitialize(AutoCount.Invoicing.Purchase.GoodsReceivedNote.FormGoodsReceivedNoteEntry.FormInitializeEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when the form data binding occurred
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnDataBinding(AutoCount.Invoicing.Purchase.GoodsReceivedNote.FormGoodsReceivedNoteEntry.FormDataBindingEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when the form is shown
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormShow(AutoCount.Invoicing.Purchase.GoodsReceivedNote.FormGoodsReceivedNoteEntry.FormShowEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do form finalization
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormClosed(AutoCount.Invoicing.Purchase.GoodsReceivedNote.FormGoodsReceivedNoteEntry.FormClosedEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when the edit is switch from View mode to Edit mode
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnSwitchToEditMode(AutoCount.Invoicing.Purchase.GoodsReceivedNote.FormGoodsReceivedNoteEntry.FormEventArgs e)
        {
        }

        /// <summary>
        /// Occurs before a detail item is added, you can set Cancel to true to prevent detail item from added.
        /// </summary>
        /// <param name="e"></param>
        public void BeforeAddDetail(AutoCount.Invoicing.Purchase.GoodsReceivedNote.FormGoodsReceivedNoteEntry.FormBeforeAddDetailEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after copy to a document.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterCopyToNewDocument(AutoCount.Invoicing.Purchase.GoodsReceivedNote.FormGoodsReceivedNoteEntry.AfterCopyToNewDocumentEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after copy from other document.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterCopyFromOtherDocument(AutoCount.Invoicing.Purchase.GoodsReceivedNote.FormGoodsReceivedNoteEntry.AfterCopyFromOtherDocumentEventArgs e)
        {
        }

        /// <summary>
        /// Occurs before Serial Number Entry form is prompted. If you don't want the Serial Number Entry form to prompt, just set the e.Handled to true.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforePromptSerialNumberEntry(AutoCount.Invoicing.Purchase.GoodsReceivedNote.FormGoodsReceivedNoteEntry.BeforePromptSerialNumberEntryEventArgs e)
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
        public void BeforeSave(AutoCount.Invoicing.Purchase.GoodsReceivedNote.FormGoodsReceivedNoteEntry.FormBeforeSaveEventArgs e)
        {
        }

        #endregion
    }
}
