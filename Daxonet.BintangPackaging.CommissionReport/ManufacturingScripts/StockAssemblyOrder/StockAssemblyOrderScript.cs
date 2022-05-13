using System;

namespace Daxonet.BintangPackaging.CommissionReport
{
    /// <summary>
    /// StockAssemblyOrderScript contains all event handler which will be called from StockAssemblyOrder.
    /// </summary>
    public class StockAssemblyOrderScript
    {
        #region Logic events

        /// <summary>
        /// Occurs when any of the detail column changed
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnDetailColumnChanged(AutoCount.Manufacturing.StockAssemblyOrder.StockAssemblyOrderDetailColumnChangedEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when any of the master column changed
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnMasterColumnChanged(AutoCount.Manufacturing.StockAssemblyOrder.StockAssemblyOrderMasterColumnChangedEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to initialize a new document
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewDocument(AutoCount.Manufacturing.StockAssemblyOrder.StockAssemblyOrderEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to initialize a new detail row
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewDetail(AutoCount.Manufacturing.StockAssemblyOrder.StockAssemblyOrderNewDetailEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to override value when assigning from raw material record to new detail
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnAssignNewDetailFromRawMaterialRecord(AutoCount.Manufacturing.StockAssemblyOrder.StockAssemblyOrderAssignNewDetailFromRawMaterialRecordEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to validate the data before save, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeSave(AutoCount.Manufacturing.StockAssemblyOrder.StockAssemblyOrderBeforeSaveEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a document is successfully saved.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterSave(AutoCount.Manufacturing.StockAssemblyOrder.StockAssemblyOrderEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do checking before delete, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeDelete(AutoCount.Manufacturing.StockAssemblyOrder.StockAssemblyOrderBeforeDeleteEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a document is successfully deleted.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterDelete(AutoCount.Manufacturing.StockAssemblyOrder.StockAssemblyOrderEventArgs e)
        {
        }

        /// <summary>
        /// Occurs whenever a detail needs to recalculate iteself because of bulk insert
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnRecalculateDetail(AutoCount.Manufacturing.StockAssemblyOrder.StockAssemblyOrderRecalculateDetailEventArgs e)
        {
        }

        #endregion

        #region Edit Form events

        /// <summary>
        /// Use this event to do form initialization
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormInitialize(object sender, AutoCount.Manufacturing.StockAssemblyOrder.FormStockAssemblyOrderEntry.FormInitializeEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when the form data binding occurred
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnDataBinding(AutoCount.Manufacturing.StockAssemblyOrder.FormStockAssemblyOrderEntry.FormDataBindingEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when the form is shown
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormShow(AutoCount.Manufacturing.StockAssemblyOrder.FormStockAssemblyOrderEntry.FormShowEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do form finalization
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormClosed(AutoCount.Manufacturing.StockAssemblyOrder.FormStockAssemblyOrderEntry.FormClosedEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when the edit is switch from View mode to Edit mode
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnSwitchToEditMode(AutoCount.Manufacturing.StockAssemblyOrder.FormStockAssemblyOrderEntry.FormEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after copy to a document.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterCopyToNewDocument(AutoCount.Manufacturing.StockAssemblyOrder.FormStockAssemblyOrderEntry.AfterCopyToNewDocumentEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after copy from other document.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterCopyFromOtherDocument(AutoCount.Manufacturing.StockAssemblyOrder.FormStockAssemblyOrderEntry.AfterCopyFromOtherDocumentEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do something before save
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeSave(AutoCount.Manufacturing.StockAssemblyOrder.FormStockAssemblyOrderEntry.FormBeforeSaveEventArgs e)
        {
        }

        #endregion
    }
}
