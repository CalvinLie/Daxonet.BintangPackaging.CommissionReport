using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Daxonet.BintangPackaging.CommissionReport
{
    /// <summary>
    /// DeliveryOrderScript contains all event handler which will be called from DeliveryOrder.
    /// </summary>
    public class DeliveryOrderScript
    {
        #region Logic events

        /// <summary>
		/// Occurs when any of the detail column changed
		/// </summary>
		/// <param name="e">The event argument</param>
		public void OnDetailColumnChanged(AutoCount.Invoicing.Sales.DeliveryOrder.DeliveryOrderDetailColumnChangedEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when any of the master column changed
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnMasterColumnChanged(AutoCount.Invoicing.Sales.DeliveryOrder.DeliveryOrderMasterColumnChangedEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to initialize a new document
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewDocument(AutoCount.Invoicing.Sales.DeliveryOrder.DeliveryOrderEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to initialize a new detail row
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewDetail(AutoCount.Invoicing.Sales.DeliveryOrder.DeliveryOrderNewDetailEventArgs e)
        {
        }

        /// <summary>
        /// Occurs while a detail item is deleting, e.CurrentDetailRecord is the detail record going to be deleted
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnDetailDeleting(AutoCount.Invoicing.Sales.DeliveryOrder.DeliveryOrderDetailDeletingEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a detail item is deleted
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnDetailDeleted(AutoCount.Invoicing.Sales.DeliveryOrder.DeliveryOrderDetailDeletedEventArgs e)
        {
        }

        /// <summary>
		/// Use this event to initialize a new item package row
		/// </summary>
		/// <param name="e">The event argument</param>
		public void OnNewItemPackage(AutoCount.Invoicing.Sales.DeliveryOrder.DeliveryOrderNewItemPackageEventArgs e)
        {
        }

        /// <summary>
		/// Use this event to initialize a new item package row
		/// </summary>
		/// <param name="e">The event argument</param>
		public void OnAssignNewItemPackageDetail(AutoCount.Invoicing.Sales.DeliveryOrder.DeliveryOrderAssignNewItemPackageDetailEventArgs e)
        {
        }

        /// <summary>
		/// Use this event to initialize a new item package row
		/// </summary>
		/// <param name="e">The event argument</param>
		public void OnPackageDetailColumnChanged(AutoCount.Invoicing.Sales.DeliveryOrder.DeliveryOrderPackageDetailColumnChangedEventArgs e)
        {
        }

        /// <summary>
		/// Use this event to initialize a new item package row
		/// </summary>
		/// <param name="e">The event argument</param>
		public void BeforeNewDetail(AutoCount.Invoicing.Sales.DeliveryOrder.DeliveryOrderBeforeNewDetailEventArgs e)
        {
        }

        /// <summary>
		/// Use this event to initialize a new item package row
		/// </summary>
		/// <param name="e">The event argument</param>
		public void BeforeNewPackageDetail(AutoCount.Invoicing.Sales.DeliveryOrder.DeliveryOrderBeforeNewPackageDetailEventArgs e)
        {
        }

        /// <summary>
		/// Use this event to initialize a new item package row
		/// </summary>
		/// <param name="e">The event argument</param>
		public void OnNewPackageDetail(AutoCount.Invoicing.Sales.DeliveryOrder.DeliveryOrderNewPackageDetailEventArgs e)
        {
        }

        /// <summary>
		/// Use this event to initialize a new item package row
		/// </summary>
		/// <param name="e">The event argument</param>
		public void OnPackageDetailDeleting(AutoCount.Invoicing.Sales.DeliveryOrder.DeliveryOrderPackageDetailDeletingEventArgs e)
        {
        }

        /// <summary>
		/// Use this event to initialize a new item package row
		/// </summary>
		/// <param name="e">The event argument</param>
		public void OnPackageDetailDeleted(AutoCount.Invoicing.Sales.DeliveryOrder.DeliveryOrderPackageDetailDeletedEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to validate the data before save, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeSave(AutoCount.Invoicing.Sales.DeliveryOrder.DeliveryOrderBeforeSaveEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to update data to database through the e.DBSetting, which will make your update in transaction control.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnSave(AutoCount.Invoicing.Sales.DeliveryOrder.DeliveryOrderOnSaveEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to update data to database through the e.DBSetting, which will make your update in transaction control.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnGetNewDocumentNo(AutoCount.Invoicing.Sales.DeliveryOrder.DeliveryOrderEventArgs e)
        {
        }

        /// <summary>
		/// Occurs after a document is successfully saved.
		/// </summary>
		/// <param name="e">The event argument</param>
		public void AfterSave(AutoCount.Invoicing.Sales.DeliveryOrder.DeliveryOrderEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do checking before delete, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeDelete(AutoCount.Invoicing.Sales.DeliveryOrder.DeliveryOrderBeforeDeleteEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to update/delete data to database through the e.DBSetting, which will make your update in transaction control.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnDelete(AutoCount.Invoicing.Sales.DeliveryOrder.DeliveryOrderOnDeleteEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a document is successfully deleted.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterDelete(AutoCount.Invoicing.Sales.DeliveryOrder.DeliveryOrderEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a document is successfully deleted.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeEdit(AutoCount.Invoicing.Sales.DeliveryOrder.DeliveryOrderBeforeEditEventArgs e)
        {
        }

        /// <summary>
		/// Occurs whenever a detail needs to recalculate iteself because of bulk insert
		/// </summary>
		/// <param name="e">The event argument</param>
		public void OnRecalculateDetail(AutoCount.Invoicing.Sales.DeliveryOrder.DeliveryOrderRecalculateDetailEventArgs e)
        {
        }

        /// <summary>
        /// Occurs whenever partial transfer occur
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnPartialTransfer(AutoCount.Invoicing.Sales.DeliveryOrder.DeliveryOrderPartialTransferEventArgs e)
        {
        }

        /// <summary>
        /// Occurs whenever a document is full transfer using option 1
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFullTransferOption1(AutoCount.Invoicing.Sales.DeliveryOrder.DeliveryOrderFullTransferOption1EventArgs e)
        {
        }

        /// <summary>
        /// Occurs whenever a document is full transfer using option 2
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFullTransferOption2(AutoCount.Invoicing.Sales.DeliveryOrder.DeliveryOrderFullTransferOption2EventArgs e)
        {
        }

        /// <summary>
        /// Occurs whenever a document is full transfer using option 2
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFullTransferOption3(AutoCount.Invoicing.Sales.DeliveryOrder.DeliveryOrderFullTransferOption3EventArgs e)
        {
        }

        /// <summary>
        /// Occurs when SubTotal needs to be recalculated
        /// </summary>
        /// <param name="e">The event argument, if you have handled this event, set e.Handled to true</param>
        public void CalcSubTotal(AutoCount.Invoicing.Sales.DeliveryOrder.DeliveryOrderCalcSubTotalEventArgs e)
        {
        }

        #endregion

        #region Edit Form events

        /// <summary>
        /// Use this event to do form initialization
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormInitialize(AutoCount.Invoicing.Sales.DeliveryOrder.FormDeliveryOrderEntry.FormInitializeEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when the form data binding occurred
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnDataBinding(AutoCount.Invoicing.Sales.DeliveryOrder.FormDeliveryOrderEntry.FormDataBindingEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when the form data binding occurred
        /// </summary>
        /// <param name="e">The event argument</param>
        public void SetCreditControl(AutoCount.Invoicing.Sales.DeliveryOrder.FormDeliveryOrderEntry.SetCreditControlEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when the form is shown
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormShow(AutoCount.Invoicing.Sales.DeliveryOrder.FormDeliveryOrderEntry.FormShowEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do form finalization
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormClosed(AutoCount.Invoicing.Sales.DeliveryOrder.FormDeliveryOrderEntry.FormClosedEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when the edit is switch from View mode to Edit mode
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnSwitchToEditMode(AutoCount.Invoicing.Sales.DeliveryOrder.FormDeliveryOrderEntry.FormEventArgs e)
        {
        }

        /// <summary>
        /// Occurs before a detail item is added, you can set Cancel to true to prevent detail item from added.
        /// </summary>
        /// <param name="e"></param>
        public void BeforeAddDetail(AutoCount.Invoicing.Sales.DeliveryOrder.FormDeliveryOrderEntry.FormBeforeAddDetailEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after copy to a document.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterCopyToNewDocument(AutoCount.Invoicing.Sales.DeliveryOrder.FormDeliveryOrderEntry.AfterCopyToNewDocumentEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after copy from other document.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterCopyFromOtherDocument(AutoCount.Invoicing.Sales.DeliveryOrder.FormDeliveryOrderEntry.AfterCopyFromOtherDocumentEventArgs e)
        {
        }

        /// <summary>
        /// Occurs before Serial Number Entry form is prompted. If you don't want the Serial Number Entry form to prompt, just set the e.Handled to true.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforePromptSerialNumberEntry(AutoCount.Invoicing.Sales.DeliveryOrder.FormDeliveryOrderEntry.BeforePromptSerialNumberEntryEventArgs e)
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
        public void BeforeSave(AutoCount.Invoicing.Sales.DeliveryOrder.FormDeliveryOrderEntry.FormBeforeSaveEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do something before save
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnValidateItemQty(AutoCount.Invoicing.Sales.DeliveryOrder.DeliveryOrderValidateItemQtyEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do something before save
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnValidateMinMaxSalesPrice(AutoCount.Invoicing.Sales.DeliveryOrder.DeliveryOrderValidateMinMaxSalesPriceEventArgs e)
        {
        }

        #endregion
    }
}
