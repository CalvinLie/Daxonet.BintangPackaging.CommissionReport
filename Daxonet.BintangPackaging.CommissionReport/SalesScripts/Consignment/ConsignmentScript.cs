using AutoCount.Data;
using System;

namespace Daxonet.BintangPackaging.CommissionReport
{
    /// <summary>
    /// ConsignmentScript contains all event handler which will be called from Consignment.
    /// </summary>
    public class ConsignmentScript
    {
        #region Logic events

        public void OnDetailColumnChanged(AutoCount.Invoicing.Sales.Consignment.ConsignmentDetailColumnChangedEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when any of the master column changed
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnMasterColumnChanged(AutoCount.Invoicing.Sales.Consignment.ConsignmentMasterColumnChangedEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to initialize a new document
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewDocument(AutoCount.Invoicing.Sales.Consignment.ConsignmentEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to initialize a new detail row
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewDetail(AutoCount.Invoicing.Sales.Consignment.ConsignmentNewDetailEventArgs e)
        {
        }

        /// <summary>
        /// Occurs while a detail item is deleting, e.CurrentDetailRecord is the detail record going to be deleted
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnDetailDeleting(AutoCount.Invoicing.Sales.Consignment.ConsignmentDetailDeletingEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a detail item is deleted
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnDetailDeleted(AutoCount.Invoicing.Sales.Consignment.ConsignmentDetailDeletedEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to validate the data before save, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeSave(AutoCount.Invoicing.Sales.Consignment.ConsignmentBeforeSaveEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to update data to database through the e.DBSetting, which will make your update in transaction control.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnSave(AutoCount.Invoicing.Sales.Consignment.ConsignmentOnSaveEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to update data to database through the e.DBSetting, which will make your update in transaction control.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnGetNewDocumentNo(AutoCount.Invoicing.Sales.Consignment.ConsignmentEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a document is successfully saved.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterSave(AutoCount.Invoicing.Sales.Consignment.ConsignmentEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do checking before delete, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeDelete(AutoCount.Invoicing.Sales.Consignment.ConsignmentBeforeDeleteEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to update/delete data to database through the e.DBSetting, which will make your update in transaction control.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnDelete(AutoCount.Invoicing.Sales.Consignment.ConsignmentOnDeleteEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a document is successfully deleted.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterDelete(AutoCount.Invoicing.Sales.Consignment.ConsignmentEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a document is successfully deleted.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeEdit(AutoCount.Invoicing.Sales.Consignment.ConsignmentBeforeEditEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a document is successfully deleted.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewItemPackage(AutoCount.Invoicing.Sales.Consignment.ConsignmentNewItemPackageEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a document is successfully deleted.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnAssignNewItemPackageDetail(AutoCount.Invoicing.Sales.Consignment.ConsignmentAssignNewItemPackageDetailEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a document is successfully deleted.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnPackageDetailColumnChanged(AutoCount.Invoicing.Sales.Consignment.ConsignmentPackageDetailColumnChangedEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a document is successfully deleted.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeNewDetail(AutoCount.Invoicing.Sales.Consignment.ConsignmentBeforeNewDetailEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a document is successfully deleted.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeNewPackageDetail(AutoCount.Invoicing.Sales.Consignment.ConsignmentBeforeNewPackageDetailEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a document is successfully deleted.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewPackageDetail(AutoCount.Invoicing.Sales.Consignment.ConsignmentNewPackageDetailEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a document is successfully deleted.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnPackageDetailDeleting(AutoCount.Invoicing.Sales.Consignment.ConsignmentPackageDetailDeletingEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a document is successfully deleted.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnPackageDetailDeleted(AutoCount.Invoicing.Sales.Consignment.ConsignmentPackageDetailDeletedEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a document is successfully deleted.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void CalcSubTotal(AutoCount.Invoicing.Sales.Consignment.ConsignmentCalcSubTotalEventArgs e)
        {
        }

        #endregion

        #region Edit Form events
        /// <summary>
        /// Use this event to do form initialization
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormInitialize(AutoCount.Invoicing.Sales.Consignment.FormConsignmentEntry.FormInitializeEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do form initialization
        /// </summary>
        /// <param name="e">The event argument</param>
        public void SetCreditControl(AutoCount.Invoicing.Sales.Consignment.FormConsignmentEntry.SetCreditControlEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do form initialization
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforePromptSerialNumberEntry(AutoCount.Invoicing.Sales.Consignment.FormConsignmentEntry.BeforePromptSerialNumberEntryEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when the form data binding occurred
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnDataBinding(AutoCount.Invoicing.Sales.Consignment.FormConsignmentEntry.FormDataBindingEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when the form is shown
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormShow(AutoCount.Invoicing.Sales.Consignment.FormConsignmentEntry.FormShowEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do form finalization
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormClosed(AutoCount.Invoicing.Sales.Consignment.FormConsignmentEntry.FormClosedEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when the edit is switch from View mode to Edit mode
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnSwitchToEditMode(AutoCount.Invoicing.Sales.Consignment.FormConsignmentEntry.FormEventArgs e)
        {
        }

        /// <summary>
        /// Occurs before a detail item is added, you can set Cancel to true to prevent detail item from added.
        /// </summary>
        /// <param name="e"></param>
        public void BeforeAddDetail(AutoCount.Invoicing.Sales.Consignment.FormConsignmentEntry.FormBeforeAddDetailEventArgs e)
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
        public void BeforeSave(AutoCount.Invoicing.Sales.Consignment.FormConsignmentEntry.FormBeforeSaveEventArgs e)
        {
        }

        public void OnValidateMinMaxSalesPrice(AutoCount.Invoicing.Sales.Consignment.ConsignmentValidateMinMaxSalesPriceEventArgs e)
        {
        }

        public void BeforePrintDocument(AutoCount.Report.BeforePrintDocumentEventArgs e)
        {
        }

        public void AfterCopyFromOtherDocument(AutoCount.Invoicing.Sales.Consignment.FormConsignmentEntry.AfterCopyFromOtherDocumentEventArgs e)
        {
        }

        public void AfterCopyToNewDocument(AutoCount.Invoicing.Sales.Consignment.FormConsignmentEntry.AfterCopyFromOtherDocumentEventArgs e)
        {
        }

        #endregion
    }
}
