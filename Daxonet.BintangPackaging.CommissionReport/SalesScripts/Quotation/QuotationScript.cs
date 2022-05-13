using System;

namespace Daxonet.BintangPackaging.CommissionReport
{
    /// <summary>
    /// QuotationScript contains all event handler which will be called from Quotation.
    /// </summary>
    public class QuotationScript
    {
        #region Logic events

        /// <summary>
		/// Occurs when any of the detail column changed
		/// </summary>
		/// <param name="e">The event argument</param>
		public void OnDetailColumnChanged(AutoCount.Invoicing.Sales.Quotation.QuotationDetailColumnChangedEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when any of the master column changed
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnMasterColumnChanged(AutoCount.Invoicing.Sales.Quotation.QuotationMasterColumnChangedEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to initialize a new document
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewDocument(AutoCount.Invoicing.Sales.Quotation.QuotationEventArgs e)
        {
        }

        /// <summary>
        /// This event is triggered just after a new document number is allocated.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnGetNewDocumentNo(AutoCount.Invoicing.Sales.Quotation.QuotationEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do checking before edit a document, if you don't allow the edit, just set Cancel to true.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeEdit(AutoCount.Invoicing.Sales.Quotation.QuotationBeforeEditEventArgs e)
        {
        }

        /// <summary>
		/// Use this event to initialize a new detail row
		/// </summary>
		/// <param name="e">The event argument</param>
		public void OnNewDetail(AutoCount.Invoicing.Sales.Quotation.QuotationNewDetailEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do checking before create a new detail, if you don't allow to create a new delete, just set Cancel to true.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeNewDetail(AutoCount.Invoicing.Sales.Quotation.QuotationBeforeNewDetailEventArgs e)
        {
        }

        /// <summary>
        /// Occurs while a detail item is deleting, e.CurrentDetailRecord is the detail record going to be deleted
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnDetailDeleting(AutoCount.Invoicing.Sales.Quotation.QuotationDetailDeletingEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a detail item is deleted
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnDetailDeleted(AutoCount.Invoicing.Sales.Quotation.QuotationDetailDeletedEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to initialize a new item package row
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewItemPackage(AutoCount.Invoicing.Sales.Quotation.QuotationNewItemPackageEventArgs e)
        {
        }

        /// <summary>
        /// This event is triggered just after a new item package is assigned.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnAssignNewItemPackageDetail(AutoCount.Invoicing.Sales.Quotation.QuotationAssignNewItemPackageDetailEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when any of the package detail column changed
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnPackageDetailColumnChanged(AutoCount.Invoicing.Sales.Quotation.QuotationPackageDetailColumnChangedEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do checking before create a new package detail, if you don't allow to create a new delete, just set Cancel to true.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeNewPackageDetail(AutoCount.Invoicing.Sales.Quotation.QuotationBeforeNewPackageDetailEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to initialize a new package detail row
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewPackageDetail(AutoCount.Invoicing.Sales.Quotation.QuotationNewPackageDetailEventArgs e)
        {
        }

        /// <summary>
        /// Occurs while a package detail item is deleting, e.CurrentPackageDetailRecord is the package detail record going to be deleted
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnPackageDetailDeleting(AutoCount.Invoicing.Sales.Quotation.QuotationPackageDetailDeletingEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a package detail item is deleted
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnPackageDetailDeleted(AutoCount.Invoicing.Sales.Quotation.QuotationPackageDetailDeletedEventArgs e)
        {
        }

        /// <summary>
		/// Use this event to validate the data before save, if the data is invalid, you can assign your error message to e.ErrorMessage.
		/// </summary>
		/// <param name="e">The event argument</param>
		public void BeforeSave(AutoCount.Invoicing.Sales.Quotation.QuotationBeforeSaveEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to update data to database through the e.DBSetting, which will make your update in transaction control.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnSave(AutoCount.Invoicing.Sales.Quotation.QuotationOnSaveEventArgs e)
        {
        }

        /// <summary>
		/// Occurs after a document is successfully saved.
		/// </summary>
		/// <param name="e">The event argument</param>
		public void AfterSave(AutoCount.Invoicing.Sales.Quotation.QuotationEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do checking before delete, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeDelete(AutoCount.Invoicing.Sales.Quotation.QuotationBeforeDeleteEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to update/delete data to database through the e.DBSetting, which will make your update in transaction control.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnDelete(AutoCount.Invoicing.Sales.Quotation.QuotationOnDeleteEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a document is successfully deleted.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterDelete(AutoCount.Invoicing.Sales.Quotation.QuotationEventArgs e)
        {
        }

        /// <summary>
		/// Occurs whenever a detail needs to recalculate iteself because of bulk insert
		/// </summary>
		/// <param name="e">The event argument</param>
		public void OnRecalculateDetail(AutoCount.Invoicing.Sales.Quotation.QuotationRecalculateDetailEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when SubTotal needs to be recalculated
        /// </summary>
        /// <param name="e">The event argument, if you have handled this event, set e.Handled to true</param>
        public void CalcSubTotal(AutoCount.Invoicing.Sales.Quotation.QuotationCalcSubTotalEventArgs e)
        {
        }

        #endregion

        #region Edit Form events

        /// <summary>
        /// Use this event to do form initialization
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormInitialize(AutoCount.Invoicing.Sales.Quotation.FormQuotationEntry.FormInitializeEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when the form data binding occurred
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnDataBinding(AutoCount.Invoicing.Sales.Quotation.FormQuotationEntry.FormDataBindingEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when the form is shown
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormShow(AutoCount.Invoicing.Sales.Quotation.FormQuotationEntry.FormShowEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do form finalization
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormClosed(AutoCount.Invoicing.Sales.Quotation.FormQuotationEntry.FormClosedEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when the edit is switch from View mode to Edit mode
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnSwitchToEditMode(AutoCount.Invoicing.Sales.Quotation.FormQuotationEntry.FormEventArgs e)
        {
        }

        public void BeforePrintDocument(AutoCount.Report.BeforePrintDocumentEventArgs e)
        {
        }

        /// <summary>
        /// Occurs before a detail item is added, you can set Cancel to true to prevent detail item from added.
        /// </summary>
        /// <param name="e"></param>
        public void BeforeAddDetail(AutoCount.Invoicing.Sales.Quotation.FormQuotationEntry.FormBeforeAddDetailEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after copy to a document.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterCopyToNewDocument(AutoCount.Invoicing.Sales.Quotation.FormQuotationEntry.AfterCopyToNewDocumentEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after copy from other document.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterCopyFromOtherDocument(AutoCount.Invoicing.Sales.Quotation.FormQuotationEntry.AfterCopyFromOtherDocumentEventArgs e)
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
        /// <remarks>This event called from the edit form.</remarks>
        public void BeforeSave(AutoCount.Invoicing.Sales.Quotation.FormQuotationEntry.FormBeforeSaveEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to hook your own credit control event handler
        /// </summary>
        /// <param name="e">The event argument</param>
        public void SetCreditControl(AutoCount.Invoicing.Sales.Quotation.FormQuotationEntry.SetCreditControlEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to provide your own validation logic
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnValidateMinMaxSalesPrice(AutoCount.Invoicing.Sales.Quotation.QuotationValidateMinMaxSalesPriceEventArgs e)
        {
        }

        #endregion
    }
}
