using System;

namespace Daxonet.BintangPackaging.CommissionReport
{
    /// <summary>
    /// StockAssemblyScript contains all event handler which will be called from StockAssembly.
    /// </summary>
    public class StockAssemblyScript
    {
        #region Logic events

        /// <summary>
		/// Occurs when any of the detail column changed
		/// </summary>
		/// <param name="e">The event argument</param>
		public void OnDetailColumnChanged(AutoCount.Manufacturing.StockAssembly.StockAssemblyDetailColumnChangedEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when any of the master column changed
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnMasterColumnChanged(AutoCount.Manufacturing.StockAssembly.StockAssemblyMasterColumnChangedEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to initialize a new document
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewDocument(AutoCount.Manufacturing.StockAssembly.StockAssemblyEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to initialize a new detail row
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewDetail(AutoCount.Manufacturing.StockAssembly.StockAssemblyNewDetailEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to override value when assigning from raw material record to new detail
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnAssignNewDetailFromRawMaterialRecord(AutoCount.Manufacturing.StockAssembly.StockAssemblyAssignNewDetailFromRawMaterialRecordEventArgs e)
        {
        }

        /// <summary>
		/// Use this event to validate the data before save, if the data is invalid, you can assign your error message to e.ErrorMessage.
		/// </summary>
		/// <param name="e">The event argument</param>
		public void BeforeSave(AutoCount.Manufacturing.StockAssembly.StockAssemblyBeforeSaveEventArgs e)
        {
        }

        public void OnGetNewDocumentNo(AutoCount.Manufacturing.StockAssembly.StockAssemblyEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a document is successfully saved.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterSave(AutoCount.Manufacturing.StockAssembly.StockAssemblyEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do checking before delete, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeDelete(AutoCount.Manufacturing.StockAssembly.StockAssemblyBeforeDeleteEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a document is successfully deleted.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterDelete(AutoCount.Manufacturing.StockAssembly.StockAssemblyEventArgs e)
        {
        }

        /// <summary>
        /// Occurs whenever a detail needs to recalculate iteself because of bulk insert
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnRecalculateDetail(AutoCount.Manufacturing.StockAssembly.StockAssemblyRecalculateDetailEventArgs e)
        {
        }

        #endregion

        #region Edit Form events

        /// <summary>
        /// Use this event to do form initialization
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormInitialize(AutoCount.Manufacturing.StockAssembly.FormStockAssemblyEntry.FormInitializeEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when the form data binding occurred
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnDataBinding(AutoCount.Manufacturing.StockAssembly.FormStockAssemblyEntry.FormDataBindingEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when the form is shown
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormShow(AutoCount.Manufacturing.StockAssembly.FormStockAssemblyEntry.FormShowEventArgs e)
        {
        }

        public void BeforePromptSerialNumberEntry(AutoCount.Manufacturing.StockAssembly.FormStockAssemblyEntry.BeforePromptSerialNumberEntryEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do form finalization
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormClosed(AutoCount.Manufacturing.StockAssembly.FormStockAssemblyEntry.FormClosedEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when the edit is switch from View mode to Edit mode
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnSwitchToEditMode(AutoCount.Manufacturing.StockAssembly.FormStockAssemblyEntry.FormEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after copy to a document.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterCopyToNewDocument(AutoCount.Manufacturing.StockAssembly.FormStockAssemblyEntry.AfterCopyToNewDocumentEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after copy from other document.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterCopyFromOtherDocument(AutoCount.Manufacturing.StockAssembly.FormStockAssemblyEntry.AfterCopyFromOtherDocumentEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do something before save
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeSave(AutoCount.Manufacturing.StockAssembly.FormStockAssemblyEntry.FormBeforeSaveEventArgs e)
        {
        }

        public void OnValidateItemQty(AutoCount.Manufacturing.StockAssembly.StockAssemblyValidateItemQtyEventArgs e)
        {
        }

        public void BeforePreviewDocument(AutoCount.Report.BeforePreviewDocumentEventArgs e)
        {
        }

        #endregion
    }
}
