using System;

namespace Daxonet.BintangPackaging.CommissionReport
{
    /// <summary>
    /// StockUOMConversionScript contains all event handler which will be called from StockUOMConversion.
    /// </summary>
    public class StockUOMConversionScript
    {
        #region Logic events

        /// <summary>
		/// Occurs when any of the detail column changed
		/// </summary>
		/// <param name="e">The event argument</param>
		public void OnDetailColumnChanged(AutoCount.Stock.StockUOMConversion.StockUOMConversionDetailColumnChangedEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when any of the master column changed
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnMasterColumnChanged(AutoCount.Stock.StockUOMConversion.StockUOMConversionMasterColumnChangedEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to initialize a new document
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewDocument(AutoCount.Stock.StockUOMConversion.StockUOMConversionEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to initialize a new detail row
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewDetail(AutoCount.Stock.StockUOMConversion.StockUOMConversionNewDetailEventArgs e)
        {
        }

        /// <summary>
        /// Occurs while a detail item is deleting, e.CurrentDetailRecord is the detail record going to be deleted
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnDetailDeleting(AutoCount.Stock.StockUOMConversion.StockUOMConversionDetailDeletingEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a detail item is deleted
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnDetailDeleted(AutoCount.Stock.StockUOMConversion.StockUOMConversionDetailDeletedEventArgs e)
        {
        }

        /// <summary>
		/// Use this event to validate the data before save, if the data is invalid, you can assign your error message to e.ErrorMessage.
		/// </summary>
		/// <param name="e">The event argument</param>
		public void BeforeSave(AutoCount.Stock.StockUOMConversion.StockUOMConversionBeforeSaveEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to update data to database through the e.DBSetting, which will make your update in transaction control.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnSave(AutoCount.Stock.StockUOMConversion.StockUOMConversionOnSaveEventArgs e)
        {
        }

        public void OnGetNewDocumentNo(AutoCount.Stock.StockUOMConversion.StockUOMConversionEventArgs e)
        {
        }

        /// <summary>
		/// Occurs after a document is successfully saved.
		/// </summary>
		/// <param name="e">The event argument</param>
		public void AfterSave(AutoCount.Stock.StockUOMConversion.StockUOMConversionEventArgs e)
        {
        }

        public void BeforeDelete(AutoCount.Stock.StockUOMConversion.StockUOMConversionBeforeDeleteEventArgs e)
        {
        }

        public void OnDelete(AutoCount.Stock.StockUOMConversion.StockUOMConversionOnDeleteEventArgs e)
        {
        }

        public void AfterDelete(AutoCount.Stock.StockUOMConversion.StockUOMConversionEventArgs e)
        {
        }

        /// <summary>
        /// Occurs whenever a detail needs to recalculate iteself because of bulk insert
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnRecalculateDetail(AutoCount.Stock.StockUOMConversion.StockUOMConversionRecalculateDetailEventArgs e)
        {
        }

        #endregion

        #region Edit Form events

        /// <summary>
        /// Use this event to do form initialization
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormInitialize(AutoCount.Stock.StockUOMConversion.FormStockUOMConversionEntry.FormInitializeEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when the form data binding occurred
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnDataBinding(AutoCount.Stock.StockUOMConversion.FormStockUOMConversionEntry.FormDataBindingEventArgs e)
        {
        }

        public void BeforeSave(AutoCount.Stock.StockUOMConversion.FormStockUOMConversionEntry.FormBeforeSaveEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when the form is shown
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormShow(AutoCount.Stock.StockUOMConversion.FormStockUOMConversionEntry.FormShowEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do form finalization
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormClosed(AutoCount.Stock.StockUOMConversion.FormStockUOMConversionEntry.FormClosedEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when the edit is switch from View mode to Edit mode
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnSwitchToEditMode(AutoCount.Stock.StockUOMConversion.FormStockUOMConversionEntry.FormEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after copy to a document.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterCopyToNewDocument(AutoCount.Stock.StockUOMConversion.FormStockUOMConversionEntry.AfterCopyToNewDocumentEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after copy from other document.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterCopyFromOtherDocument(AutoCount.Stock.StockUOMConversion.FormStockUOMConversionEntry.AfterCopyFromOtherDocumentEventArgs e)
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
