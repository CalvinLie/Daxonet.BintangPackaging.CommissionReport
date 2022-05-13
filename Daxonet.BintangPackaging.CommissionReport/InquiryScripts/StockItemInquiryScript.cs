using System;

namespace Daxonet.BintangPackaging.CommissionReport
{
    /// <summary>
    /// Implements script for StockItemInquiry.
    /// </summary>
	public class StockItemInquiryScript
    {
        /// <summary>
        /// Use this event to do form initialization
        /// </summary>
        /// <param name="sender">The form itself</param>
        /// <param name="e">The event argument</param>
        public void OnFormInitialize(object sender, AutoCount.Stock.ItemInquiry.FormInitializeEventArgs e)
        {
        }

        /// <summary>
		/// Use this event to do form initialization
		/// </summary>
		/// <param name="sender">The form itself</param>
		/// <param name="e">The event argument</param>
        public void OnFormInitialize(object sender, AutoCount.Stock.ItemInquiry.FormNewItemInquiry.FormInitializeEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do finalization code after form closed
        /// </summary>
        /// <param name="sender">The form itself</param>
        /// <param name="e">The event argument</param>
        public void OnFormClosed(object sender, AutoCount.Stock.ItemInquiry.FormClosedEventArgs e)
        {
        }

        /// <summary>
		/// This event occurs when users query an item
		/// </summary>
		/// <param name="itemCode">An itemcode</param>
		public void OnQueryItem(string itemCode)
        {
        }

        public void OnQueryItem(AutoCount.Stock.ItemInquiry.FormItemInquiry e)
        {
        }

        public void OnQueryItem(AutoCount.Stock.ItemInquiry.FormNewItemInquiry e)
        {
        }
    }
}
