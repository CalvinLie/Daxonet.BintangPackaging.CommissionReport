using System;
using System.Collections.Generic;
using System.Text;

namespace Daxonet.BintangPackaging.CommissionReport
{
    /// <summary>
    /// Implements script for PurchaseOrderCommandForm.
    /// </summary>
    public class PurchaseOrderCommandFormScript
    {
        /// <summary>
        /// Use this event to do form initialization
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormInitialize(AutoCount.Invoicing.Purchase.PurchaseOrder.FormPurchaseOrderCmd.FormInitializeEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when the form has loaded data
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormLoadData(AutoCount.Invoicing.Purchase.PurchaseOrder.FormPurchaseOrderCmd.FormLoadDataEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do form finalization
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormClosed(AutoCount.Invoicing.Purchase.PurchaseOrder.FormPurchaseOrderCmd.FormClosedEventArgs e)
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
		/// Use this event before print
		/// </summary>
		/// <param name="e">The event argument</param>
        public void BeforePrintDocument(AutoCount.Report.BeforePrintDocumentEventArgs e)
        {
        }
    }
}
