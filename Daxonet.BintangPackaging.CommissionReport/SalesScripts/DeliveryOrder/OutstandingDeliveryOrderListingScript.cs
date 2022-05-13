using AutoCount.Document;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Daxonet.BintangPackaging.CommissionReport
{
    /// <summary>
    /// Implements script for DeliveryOrderOutstandingListing.
    /// </summary>
    public class OutstandingDeliveryOrderListingScript
    {
        /// <summary>
        /// Occurs when inquiry function is executed
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormInquiry(AutoCount.Invoicing.Sales.DeliveryOrder.FormDeliveryOrderPrintOutstandingListing.FormInquiryEventArgs e)
        {
        }

        /// <summary>
		/// Occurs when inquiry function is executed
		/// </summary>
		/// <param name="e">The event argument</param>
        public void OnFormInitialize(AutoCount.Invoicing.Sales.DeliveryOrder.FormDeliveryOrderPrintOutstandingListing.FormInitializeEventArgs e)
        {
        }
    }
}
