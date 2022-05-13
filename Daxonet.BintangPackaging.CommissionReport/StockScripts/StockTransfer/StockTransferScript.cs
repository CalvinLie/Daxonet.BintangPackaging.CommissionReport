using System;

namespace Daxonet.BintangPackaging.CommissionReport
{
    /// <summary>
    /// StockTransferScript contains all event handler which will be called from StockTransfer.
    /// </summary>
    public class StockTransferScript
    {
        #region Logic events

        /// <summary>
		/// Occurs when any of the detail column changed
		/// </summary>
		/// <param name="e">The event argument</param>
		public void OnDetailColumnChanged(AutoCount.Stock.StockTransfer.StockTransferDetailColumnChangedEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when any of the master column changed
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnMasterColumnChanged(AutoCount.Stock.StockTransfer.StockTransferMasterColumnChangedEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to initialize a new document
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewDocument(AutoCount.Stock.StockTransfer.StockTransferEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to initialize a new detail row
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewDetail(AutoCount.Stock.StockTransfer.StockTransferNewDetailEventArgs e)
        {
        }

        /// <summary>
        /// Occurs while a detail item is deleting, e.CurrentDetailRecord is the detail record going to be deleted
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnDetailDeleting(AutoCount.Stock.StockTransfer.StockTransferDetailDeletingEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a detail item is deleted
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnDetailDeleted(AutoCount.Stock.StockTransfer.StockTransferDetailDeletedEventArgs e)
        {
        }

        /// <summary>
		/// Use this event to validate the data before save, if the data is invalid, you can assign your error message to e.ErrorMessage.
		/// </summary>
		/// <param name="e">The event argument</param>
		public void BeforeSave(AutoCount.Stock.StockTransfer.StockTransferBeforeSaveEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to update data to database through the e.DBSetting, which will make your update in transaction control.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnSave(AutoCount.Stock.StockTransfer.StockTransferOnSaveEventArgs e)
        {
        }

        public void OnGetNewDocumentNo(AutoCount.Stock.StockTransfer.StockTransferEventArgs e)
        {
        }

        /// <summary>
		/// Occurs after a document is successfully saved.
		/// </summary>
		/// <param name="e">The event argument</param>
		public void AfterSave(AutoCount.Stock.StockTransfer.StockTransferEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do checking before delete, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeDelete(AutoCount.Stock.StockTransfer.StockTransferBeforeDeleteEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to update/delete data to database through the e.DBSetting, which will make your update in transaction control.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnDelete(AutoCount.Stock.StockTransfer.StockTransferOnDeleteEventArgs e)
        {
        }

        /// <summary>
		/// Occurs after a document is successfully deleted.
		/// </summary>
		/// <param name="e">The event argument</param>
		public void AfterDelete(AutoCount.Stock.StockTransfer.StockTransferEventArgs e)
        {
        }

        /// <summary>
        /// Occurs whenever a detail needs to recalculate iteself because of bulk insert
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnRecalculateDetail(AutoCount.Stock.StockTransfer.StockTransferRecalculateDetailEventArgs e)
        {
        }

        #endregion

        #region Edit Form events

        /// <summary>
        /// Use this event to do form initialization
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormInitialize(AutoCount.Stock.StockTransfer.FormStockTransferEntry.FormInitializeEventArgs e)
        {
        }

        public void BeforePromptSerialNumberEntry(AutoCount.Stock.StockTransfer.FormStockTransferEntry.BeforePromptSerialNumberEntryEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when the form data binding occurred
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnDataBinding(AutoCount.Stock.StockTransfer.FormStockTransferEntry.FormDataBindingEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when the form is shown
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormShow(AutoCount.Stock.StockTransfer.FormStockTransferEntry.FormShowEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do form finalization
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormClosed(AutoCount.Stock.StockTransfer.FormStockTransferEntry.FormClosedEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when the edit is switch from View mode to Edit mode
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnSwitchToEditMode(AutoCount.Stock.StockTransfer.FormStockTransferEntry.FormEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after copy to a document.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterCopyToNewDocument(AutoCount.Stock.StockTransfer.FormStockTransferEntry.AfterCopyToNewDocumentEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after copy from other document.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterCopyFromOtherDocument(AutoCount.Stock.StockTransfer.FormStockTransferEntry.AfterCopyFromOtherDocumentEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to control whether allow to print or preview or export before preview is executed.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforePreviewDocument(AutoCount.Report.BeforePreviewDocumentEventArgs e)
        {
        }

        #endregion
    }
}
