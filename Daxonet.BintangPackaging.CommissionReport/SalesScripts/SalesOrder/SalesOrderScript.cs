using AutoCount.Application;
using AutoCount.AuditTrail;
using AutoCount.Data;
using AutoCount.Invoicing.Purchase.PurchaseOrder;
using AutoCount.Invoicing.Sales.SalesOrder;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Daxonet.BintangPackaging.CommissionReport
{
    /// <summary>
    /// SalesOrderScript contains all event handler which will be called from SalesOrder.
    /// </summary>
    public class SalesOrderScript
    {
        #region Logic events

        /// <summary>
		/// Occurs when any of the detail column changed
		/// </summary>
		/// <param name="e">The event argument</param>
		public void OnDetailColumnChanged(AutoCount.Invoicing.Sales.SalesOrder.SalesOrderDetailColumnChangedEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when any of the master column changed
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnMasterColumnChanged(AutoCount.Invoicing.Sales.SalesOrder.SalesOrderMasterColumnChangedEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to initialize a new document
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewDocument(AutoCount.Invoicing.Sales.SalesOrder.SalesOrderEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to initialize a new detail row
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewDetail(AutoCount.Invoicing.Sales.SalesOrder.SalesOrderNewDetailEventArgs e)
        {
        }

        /// <summary>
        /// Occurs while a detail item is deleting, e.CurrentDetailRecord is the detail record going to be deleted
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnDetailDeleting(AutoCount.Invoicing.Sales.SalesOrder.SalesOrderDetailDeletingEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a detail item is deleted
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnDetailDeleted(AutoCount.Invoicing.Sales.SalesOrder.SalesOrderDetailDeletedEventArgs e)
        {
        }

        /// <summary>
		/// Use this event to initialize a new item package row
		/// </summary>
		/// <param name="e">The event argument</param>
		public void OnNewItemPackage(AutoCount.Invoicing.Sales.SalesOrder.SalesOrderNewItemPackageEventArgs e)
        {
        }

        public void OnAssignNewItemPackageDetail(AutoCount.Invoicing.Sales.SalesOrder.SalesOrderAssignNewItemPackageDetailEventArgs e)
        {
        }

        public void OnPackageDetailColumnChanged(AutoCount.Invoicing.Sales.SalesOrder.SalesOrderPackageDetailColumnChangedEventArgs e)
        {
        }

        public void BeforeNewDetail(AutoCount.Invoicing.Sales.SalesOrder.SalesOrderBeforeNewDetailEventArgs e)
        {
        }

        public void BeforeNewPackageDetail(AutoCount.Invoicing.Sales.SalesOrder.SalesOrderBeforeNewPackageDetailEventArgs e)
        {
        }

        public void OnNewPackageDetail(AutoCount.Invoicing.Sales.SalesOrder.SalesOrderNewPackageDetailEventArgs e)
        {
        }

        public void OnPackageDetailDeleting(AutoCount.Invoicing.Sales.SalesOrder.SalesOrderPackageDetailDeletingEventArgs e)
        {
        }

        public void OnPackageDetailDeleted(AutoCount.Invoicing.Sales.SalesOrder.SalesOrderPackageDetailDeletedEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to validate the data before save, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeSave(AutoCount.Invoicing.Sales.SalesOrder.SalesOrderBeforeSaveEventArgs e)
        {
        }



        /// <summary>
        /// Use this event to update data to database through the e.DBSetting, which will make your update in transaction control.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnSave(AutoCount.Invoicing.Sales.SalesOrder.SalesOrderOnSaveEventArgs e)
        {
        }

        /// <summary>
		/// Occurs after a document is successfully saved.
		/// </summary>
		/// <param name="e">The event argument</param>
		public void AfterSave(AutoCount.Invoicing.Sales.SalesOrder.SalesOrderEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do checking before delete, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeDelete(AutoCount.Invoicing.Sales.SalesOrder.SalesOrderBeforeDeleteEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to update/delete data to database through the e.DBSetting, which will make your update in transaction control.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnDelete(AutoCount.Invoicing.Sales.SalesOrder.SalesOrderOnDeleteEventArgs e)
        {
        }

        public void OnGetNewDocumentNo(SalesOrderOnDeleteEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a document is successfully deleted.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterDelete(AutoCount.Invoicing.Sales.SalesOrder.SalesOrderEventArgs e)
        {
        }

        public void BeforeEdit(AutoCount.Invoicing.Sales.SalesOrder.SalesOrderBeforeEditEventArgs e)
        {
        }

        /// <summary>
		/// Occurs whenever a detail needs to recalculate iteself because of bulk insert
		/// </summary>
		/// <param name="e">The event argument</param>
		public void OnRecalculateDetail(AutoCount.Invoicing.Sales.SalesOrder.SalesOrderRecalculateDetailEventArgs e)
        {
        }

        /// <summary>
        /// Occurs whenever partial transfer occur
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnPartialTransfer(AutoCount.Invoicing.Sales.SalesOrder.SalesOrderPartialTransferEventArgs e)
        {
        }

        /// <summary>
        /// Occurs whenever a document is full transfer using option 1
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFullTransferOption1(AutoCount.Invoicing.Sales.SalesOrder.SalesOrderFullTransferOption1EventArgs e)
        {
        }

        /// <summary>
        /// Occurs whenever a document is full transfer using option 2
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFullTransferOption2(AutoCount.Invoicing.Sales.SalesOrder.SalesOrderFullTransferOption2EventArgs e)
        {
        }

        public void OnFullTransferOption3(AutoCount.Invoicing.Sales.SalesOrder.SalesOrderFullTransferOption3EventArgs e)
        {
        }

        /// <summary>
        /// Occurs when SubTotal needs to be recalculated
        /// </summary>
        /// <param name="e">The event argument, if you have handled this event, set e.Handled to true</param>
        public void CalcSubTotal(AutoCount.Invoicing.Sales.SalesOrder.SalesOrderCalcSubTotalEventArgs e)
        {
        }

        public void AfterCopyToNewDocument(AutoCount.Invoicing.Sales.SalesOrder.AfterCopyToNewDocumentEventArgs e)
        {
        }

        #endregion

        #region Edit Form events

        /// <summary>
        /// Use this event to do form initialization
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormInitialize(AutoCount.Invoicing.Sales.SalesOrder.FormSalesOrderEntry.FormInitializeEventArgs e)
        {
        }

        public void SetCreditControl(AutoCount.Invoicing.Sales.SalesOrder.FormSalesOrderEntry.SetCreditControlEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when the form data binding occurred
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnDataBinding(AutoCount.Invoicing.Sales.SalesOrder.FormSalesOrderEntry.FormDataBindingEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when the form is shown
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormShow(AutoCount.Invoicing.Sales.SalesOrder.FormSalesOrderEntry.FormShowEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do form finalization
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormClosed(AutoCount.Invoicing.Sales.SalesOrder.FormSalesOrderEntry.FormClosedEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when the edit is switch from View mode to Edit mode
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnSwitchToEditMode(AutoCount.Invoicing.Sales.SalesOrder.FormSalesOrderEntry.FormEventArgs e)
        {
        }

        /// <summary>
        /// Occurs before a detail item is added, you can set Cancel to true to prevent detail item from added.
        /// </summary>
        /// <param name="e"></param>
        public void BeforeAddDetail(AutoCount.Invoicing.Sales.SalesOrder.FormSalesOrderEntry.FormBeforeAddDetailEventArgs e)
        {
        }

        public void BeforePrintDocument(AutoCount.Report.BeforePrintDocumentEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after copy to a document.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterCopyToNewDocument(AutoCount.Invoicing.Sales.SalesOrder.FormSalesOrderEntry.AfterCopyToNewDocumentEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after copy from other document.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterCopyFromOtherDocument(AutoCount.Invoicing.Sales.SalesOrder.FormSalesOrderEntry.AfterCopyFromOtherDocumentEventArgs e)
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
        public void BeforeSave(AutoCount.Invoicing.Sales.SalesOrder.FormSalesOrderEntry.FormBeforeSaveEventArgs e)
        {
        }

        public void OnValidateMinMaxSalesPrice(AutoCount.Invoicing.Sales.SalesOrder.SalesOrderValidateMinMaxSalesPriceEventArgs e)
        {
        }

        #endregion
    }
}
