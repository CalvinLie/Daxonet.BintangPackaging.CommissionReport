using System;

namespace Daxonet.BintangPackaging.CommissionReport
{
    /// <summary>
    /// StockBalanceScript contains all event handler which will be called from StockBalance.
    /// </summary>
    public class StockBalanceScript
    {
        /// <summary>
        /// Use this event to do form initialization
        /// </summary>
        /// <param name="sender">The form itself</param>
        /// <param name="e">The event argument</param>
        public void OnFormInitialize(object sender, AutoCount.Stock.StockBalance.FormStockBalance.FormInitializeEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when inquiry function is executed
        /// </summary>
        /// <param name="sender">The form itself</param>
        /// <param name="e">The event argument</param>
        public void OnFormInquiry(object sender, AutoCount.Stock.StockBalance.FormStockBalance.FormInquiryEventArgs e)
        {
        }
    }
}
