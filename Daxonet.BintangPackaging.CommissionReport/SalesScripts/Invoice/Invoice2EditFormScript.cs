using System;
using System.Collections.Generic;
using System.Text;

namespace Daxonet.BintangPackaging.CommissionReport
{
    /// <summary>
    /// Implements script for InvoiceEditForm.
    /// </summary>
    public class Invoice2EditFormScript
    {
        /// <summary>
        /// Use this event to do form initialization
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormInitialize(AutoCount.Invoicing.Sales.Invoice.FormInvoiceEntry.FormInitializeEventArgs e)
        {
            Invoice2Script.GetCombinedInvoiceScript(e.Invoice).OnFormInitialize(e);
        }

        /// <summary>
		/// Occurs when the form data binding occurred
		/// </summary>
		/// <param name="e">The event argument</param>
        public void OnDataBinding(AutoCount.Invoicing.Sales.Invoice.FormInvoiceEntry.FormDataBindingEventArgs e)
        {
            Invoice2Script.GetCombinedInvoiceScript(e.Invoice).OnDataBinding(e);
        }

        /// <summary>
        /// Occurs when the form is shown
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormShow(AutoCount.Invoicing.Sales.Invoice.FormInvoiceEntry.FormShowEventArgs e)
        {
            Invoice2Script.GetCombinedInvoiceScript(e.Invoice).OnFormShow(e);
        }

        /// <summary>
        /// Use this event to do form finalization
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormClosed(AutoCount.Invoicing.Sales.Invoice.FormInvoiceEntry.FormClosedEventArgs e)
        {
            Invoice2Script.GetCombinedInvoiceScript(e.Invoice).OnFormClosed(e);
        }

        /// <summary>
        /// Occurs when the edit is switch from View mode to Edit mode
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnSwitchToEditMode(AutoCount.Invoicing.Sales.Invoice.FormInvoiceEntry.FormEventArgs e)
        {
            Invoice2Script.GetCombinedInvoiceScript(e.Invoice).OnSwitchToEditMode(e);
        }

        /// <summary>
        /// Occurs before a detail item is added, you can set Cancel to true to prevent detail item from added.
        /// </summary>
        /// <param name="e"></param>
        public void BeforeAddDetail(AutoCount.Invoicing.Sales.Invoice.FormInvoiceEntry.FormBeforeAddDetailEventArgs e)
        {
            Invoice2Script.GetCombinedInvoiceScript(e.Invoice).BeforeAddDetail(e);
        }

        /// <summary>
        /// Occurs after copy to a document.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterCopyToNewDocument(AutoCount.Invoicing.Sales.Invoice.FormInvoiceEntry.AfterCopyToNewDocumentEventArgs e)
        {
            //Invoice2Script.GetCombinedInvoiceScript(e.Invoice).AfterCopyToNewDocument(e);
        }

        /// <summary>
        /// Occurs after copy from other document.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterCopyFromOtherDocument(AutoCount.Invoicing.Sales.Invoice.FormInvoiceEntry.AfterCopyFromOtherDocumentEventArgs e)
        {
            //Invoice2Script.GetCombinedInvoiceScript(e.Invoice).AfterCopyFromOtherDocument(e);
        }

        /// <summary>
        /// Occurs before Serial Number Entry form is prompted. If you don't want the Serial Number Entry form to prompt, just set the e.Handled to true.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforePromptSerialNumberEntry(AutoCount.Invoicing.Sales.Invoice.FormInvoiceEntry.BeforePromptSerialNumberEntryEventArgs e)
        {
            Invoice2Script.GetCombinedInvoiceScript(e.Invoice).BeforePromptSerialNumberEntry(e);
        }

        /// <summary>
        /// Use this event to control whether allow to print or preview or export before preview is executed.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforePreviewDocument(AutoCount.Report.BeforePreviewDocumentEventArgs e)
        {
            //Invoice2Script.GetCombinedInvoiceScript(e.Invoice).BeforePreviewDocument(e);
        }

        /// <summary>
        /// Use this event to do something before save
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeSave(AutoCount.Invoicing.Sales.Invoice.FormInvoiceEntry.FormBeforeSaveEventArgs e)
        {
            Invoice2Script.GetCombinedInvoiceScript(e.Invoice).BeforeSave(e);
        }
    }
}
