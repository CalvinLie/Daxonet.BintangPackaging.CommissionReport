using System;

namespace Daxonet.BintangPackaging.CommissionReport
{
    /// <summary>
    /// Implements script for AccountInquiry.
    /// </summary>
	public class AccountInquiryScript
    {
        /// <summary>
        /// Use this event to do form initialization
        /// </summary>
        /// <param name="sender">The form itself</param>
        /// <param name="e">The event argument</param>
        public void OnFormInitialize(object sender, AutoCount.GL.AccountInquiry.FormInitializeEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do finalization code after form closed
        /// </summary>
        /// <param name="sender">The form itself</param>
        /// <param name="e">The event argument</param>
        public void OnFormClosed(object sender, AutoCount.GL.AccountInquiry.FormClosedEventArgs e)
        {
        }

        /*
        /// <summary>
		/// This event occurs when users query an account number
		/// </summary>
		/// <param name="accNo">Account Number</param>
		public void OnQueryItem(string accNo)
		{
		}

        public void OnQueryItem(AutoCount.GL.AccountInquiry.FormAccountInquiry e)
        {
        }
        */

        /// <summary>
        /// This event occurs when users query an account
        /// </summary>
        /// <param name="e"></param>
        public void OnQueryAccount(AutoCount.GL.AccountInquiry.FormAccountInquiry e)
        {
        }
    }
}
