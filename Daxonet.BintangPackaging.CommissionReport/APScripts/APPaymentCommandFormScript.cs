using System;
using System.Collections.Generic;
using System.Text;

namespace Daxonet.BintangPackaging.CommissionReport
{
    /// <summary>
    /// Implements script for APPaymentCommandFormScript.
    /// </summary>
    public class APPaymentCommandFormScript
    {

        /// <summary>
        /// Use this event to do form initialization
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormInitialize(AutoCount.ARAP.APPayment.FormAPPaymentCmd.FormInitializeEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do form finalization
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormClosed(AutoCount.ARAP.APPayment.FormAPPaymentCmd.FormClosedEventArgs e)
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
        /// Occurs when the form has loaded data
        /// </summary>
        /// <param name="e">The event argument</param
        public void OnFormLoadData(AutoCount.ARAP.APPayment.FormAPPaymentCmd.FormLoadDataEventArgs e)
        {
        }
    }
}

