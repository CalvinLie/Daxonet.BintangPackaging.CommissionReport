using System;
using System.Collections.Generic;
using System.Text;

namespace Daxonet.BintangPackaging.CommissionReport
{
    /// <summary>
    /// Implements script for QuotationEditForm.
    /// </summary>
    public class QuotationEditFormScript
    {
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
    }
}
