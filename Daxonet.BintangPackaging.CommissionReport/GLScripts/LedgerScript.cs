using System;

namespace Daxonet.BintangPackaging.CommissionReport
{
    /// <summary>
    /// LedgerScript contains all event handler which will be called from Ledger.
    /// </summary>
    public class LedgerScript
    {
        /// <summary>
        /// Use this event to do form initialization
        /// </summary>
        /// <param name="sender">The form itself</param>
        /// <param name="e">The event argument</param>
        public void OnFormInitialize(object sender, AutoCount.GL.Ledger.FormLedger.FormInitializeEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when inquiry function is executed
        /// </summary>
        /// <param name="sender">The form itself</param>
        /// <param name="e">The event argument</param>
        public void OnFormInquiry(object sender, AutoCount.GL.Ledger.FormLedger.FormInquiryEventArgs e)
        {
        }
    }
}
