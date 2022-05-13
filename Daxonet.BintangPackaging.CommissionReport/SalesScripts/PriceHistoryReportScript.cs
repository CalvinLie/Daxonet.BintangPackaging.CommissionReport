using System;

namespace Daxonet.BintangPackaging.CommissionReport
{
    /// <summary>
    /// ReorderAdviceScript contains all event handler which will be called from ReorderAdvice.
    /// </summary>
    public class PriceHistoryReportScript
    {
        /// <summary>
        /// Use this event to do form initialization
        /// </summary>
        /// <param name="sender">The form itself</param>
        /// <param name="e">The event argument</param>
        public void OnFormInitialize(AutoCount.Invoicing.PriceHistory.FormPriceHistory.FormInitializeEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when inquiry function is executed
        /// </summary>
        /// <param name="sender">The form itself</param>
        /// <param name="e">The event argument</param>
        public void OnFormInquiry(AutoCount.Invoicing.PriceHistory.FormPriceHistory.FormInquiryEventArgs e)
        {
        }
    }
}
