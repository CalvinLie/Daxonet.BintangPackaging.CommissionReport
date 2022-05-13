using System;
using System.Collections.Generic;
using System.Text;

namespace Daxonet.BintangPackaging.CommissionReport
{
    /// <summary>
    /// Implements script for InvoiceListing.
    /// </summary>
    public class InvoiceListingScript
    {
        /// <summary>
        /// Use this event to do form initialization
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormInitialize(AutoCount.Invoicing.Sales.Invoice.FormInvoicePrintListing.FormInitializeEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when inquiry function is executed
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormInquiry(AutoCount.Invoicing.Sales.Invoice.FormInvoicePrintListing.FormInquiryEventArgs e)
        {
        }
    }
}
