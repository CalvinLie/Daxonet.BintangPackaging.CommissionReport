using System;
using System.Collections.Generic;
using System.Text;

namespace Daxonet.BintangPackaging.CommissionReport
{
    /// <summary>
    /// Implements script for ARCNCommandFormScript.
    /// </summary>
    public class ARCNCommandFormScript
    {
        /// <summary>
        /// Use this event to do form initialization
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormInitialize(AutoCount.ARAP.ARCN.FormARCNCmd.FormInitializeEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do form finalization
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormClosed(AutoCount.ARAP.ARCN.FormARCNCmd.FormClosedEventArgs e)
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
        /// Occurs on form load data
        /// </summary>
        /// <param name="e"></param>
        public void OnFormLoadData(AutoCount.ARAP.ARCN.FormARCNCmd.FormLoadDataEventArgs e)
        {
        }
    }
}
