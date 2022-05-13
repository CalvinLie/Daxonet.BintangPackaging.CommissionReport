using AutoCount.Data;
using System;

namespace Daxonet.BintangPackaging.CommissionReport
{
    /// <summary>
    /// PurchaseConsignmentScript contains all event handler which will be called from PurchaseConsignment.
    /// </summary>
    public class PurchaseConsignmentScript
    {
        #region Logic events

        public void OnDetailColumnChanged(AutoCount.Invoicing.Purchase.PurchaseConsignment.PurchaseConsignmentDetailColumnChangedEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when any of the master column changed
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnMasterColumnChanged(AutoCount.Invoicing.Purchase.PurchaseConsignment.PurchaseConsignmentMasterColumnChangedEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to initialize a new document
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewDocument(AutoCount.Invoicing.Purchase.PurchaseConsignment.PurchaseConsignmentEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to initialize a new detail row
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewDetail(AutoCount.Invoicing.Purchase.PurchaseConsignment.PurchaseConsignmentNewDetailEventArgs e)
        {
        }

        /// <summary>
        /// Occurs while a detail item is deleting, e.CurrentDetailRecord is the detail record going to be deleted
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnDetailDeleting(AutoCount.Invoicing.Purchase.PurchaseConsignment.PurchaseConsignmentDetailDeletingEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a detail item is deleted
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnDetailDeleted(AutoCount.Invoicing.Purchase.PurchaseConsignment.PurchaseConsignmentDetailDeletedEventArgs e)
        {
        }

        public void OnNewItemPackage(AutoCount.Invoicing.Purchase.PurchaseConsignment.PurchaseConsignmentNewItemPackageEventArgs e)
        {
        }

        public void OnAssignNewItemPackageDetail(AutoCount.Invoicing.Purchase.PurchaseConsignment.PurchaseConsignmentAssignNewItemPackageDetailEventArgs e)
        {
        }

        public void OnPackageDetailColumnChanged(AutoCount.Invoicing.Purchase.PurchaseConsignment.PurchaseConsignmentPackageDetailColumnChangedEventArgs e)
        {
        }

        public void BeforeNewDetail(AutoCount.Invoicing.Purchase.PurchaseConsignment.PurchaseConsignmentBeforeNewDetailEventArgs e)
        {
        }

        public void BeforeNewPackageDetail(AutoCount.Invoicing.Purchase.PurchaseConsignment.PurchaseConsignmentBeforeNewPackageDetailEventArgs e)
        {
        }

        public void OnNewPackageDetail(AutoCount.Invoicing.Purchase.PurchaseConsignment.PurchaseConsignmentNewPackageDetailEventArgs e)
        {
        }

        public void OnPackageDetailDeleting(AutoCount.Invoicing.Purchase.PurchaseConsignment.PurchaseConsignmentPackageDetailDeletingEventArgs e)
        {
        }

        public void OnPackageDetailDeleted(AutoCount.Invoicing.Purchase.PurchaseConsignment.PurchaseConsignmentPackageDetailDeletedEventArgs e)
        {
        }

        public void CalcSubTotal(AutoCount.Invoicing.Purchase.PurchaseConsignment.PurchaseConsignmentCalcSubTotalEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to validate the data before save, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeSave(AutoCount.Invoicing.Purchase.PurchaseConsignment.PurchaseConsignmentBeforeSaveEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to update data to database through the e.DBSetting, which will make your update in transaction control.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnSave(AutoCount.Invoicing.Purchase.PurchaseConsignment.PurchaseConsignmentOnSaveEventArgs e)
        {
        }

        public void OnGetNewDocumentNo(AutoCount.Invoicing.Purchase.PurchaseConsignment.PurchaseConsignmentEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a document is successfully saved.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterSave(AutoCount.Invoicing.Purchase.PurchaseConsignment.PurchaseConsignmentEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do checking before delete, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeDelete(AutoCount.Invoicing.Purchase.PurchaseConsignment.PurchaseConsignmentBeforeDeleteEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to update/delete data to database through the e.DBSetting, which will make your update in transaction control.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnDelete(AutoCount.Invoicing.Purchase.PurchaseConsignment.PurchaseConsignmentOnDeleteEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a document is successfully deleted.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterDelete(AutoCount.Invoicing.Purchase.PurchaseConsignment.PurchaseConsignmentEventArgs e)
        {
        }

        public void BeforeEdit(AutoCount.Invoicing.Purchase.PurchaseConsignment.PurchaseConsignmentBeforeEditEventArgs e)
        {
        }

        #endregion

        #region Edit Form events

        /// <summary>
        /// Use this event to do form initialization
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormInitialize(AutoCount.Invoicing.Purchase.PurchaseConsignment.FormPurchaseConsignmentEntry.FormInitializeEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when the form data binding occurred
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnDataBinding(AutoCount.Invoicing.Purchase.PurchaseConsignment.FormPurchaseConsignmentEntry.FormDataBindingEventArgs e)
        {
        }

        public void BeforePromptSerialNumberEntry(AutoCount.Invoicing.Purchase.PurchaseConsignment.FormPurchaseConsignmentEntry.BeforePromptSerialNumberEntryEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when the form is shown
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormShow(AutoCount.Invoicing.Purchase.PurchaseConsignment.FormPurchaseConsignmentEntry.FormShowEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do form finalization
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormClosed(AutoCount.Invoicing.Purchase.PurchaseConsignment.FormPurchaseConsignmentEntry.FormClosedEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when the edit is switch from View mode to Edit mode
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnSwitchToEditMode(AutoCount.Invoicing.Purchase.PurchaseConsignment.FormPurchaseConsignmentEntry.FormEventArgs e)
        {
        }

        public void BeforePrintDocument(AutoCount.Report.BeforePrintDocumentEventArgs e)
        {
        }

        public void AfterCopyFromOtherDocument(AutoCount.Invoicing.Purchase.PurchaseConsignment.FormPurchaseConsignmentEntry.AfterCopyFromOtherDocumentEventArgs e)
        {
        }

        public void AfterCopyToNewDocument(AutoCount.Invoicing.Purchase.PurchaseConsignment.FormPurchaseConsignmentEntry.AfterCopyToNewDocumentEventArgs e)
        {
        }

        /// <summary>
        /// Occurs before a detail item is added, you can set Cancel to true to prevent detail item from added.
        /// </summary>
        /// <param name="e"></param>
        public void BeforeAddDetail(AutoCount.Invoicing.Purchase.PurchaseConsignment.FormPurchaseConsignmentEntry.FormBeforeAddDetailEventArgs e)
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
        public void BeforeSave(AutoCount.Invoicing.Purchase.PurchaseConsignment.FormPurchaseConsignmentEntry.FormBeforeSaveEventArgs e)
        {
        }

        #endregion
    }
}
