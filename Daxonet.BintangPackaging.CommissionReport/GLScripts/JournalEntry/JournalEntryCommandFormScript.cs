using System;
using System.Collections.Generic;
using System.Text;

namespace Daxonet.BintangPackaging.CommissionReport
{
    /// <summary>
    /// Implements script for JournalEntryCommandForm.
    /// </summary>
    public class JournalEntryCommandFormScript
    {
        /// <summary>
        /// Use this event to do form initialization
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormInitialize(AutoCount.GL.JournalEntry.FormJournalEntryCmd.FormInitializeEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when the form has loaded data
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormLoadData(AutoCount.GL.JournalEntry.FormJournalEntryCmd.FormLoadDataEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do form finalization
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormClosed(AutoCount.GL.JournalEntry.FormJournalEntryCmd.FormClosedEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to control whether allow to print or preview or export before preview is executed.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforePreviewDocument(AutoCount.Report.BeforePreviewDocumentEventArgs e)
        {
        }
    }
}
