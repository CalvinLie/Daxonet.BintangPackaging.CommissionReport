using System;

namespace Daxonet.BintangPackaging.CommissionReport
{
    /// <summary>
    /// JournalTypeScript contains the skeleton of the event handler for Journal Type
    /// </summary>
    public class JournalTypeScript
    {
        /// <summary>
        /// Occurs when any of the columns changed
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnColumnChanged(AutoCount.GeneralMaint.JournalType.JournalTypeColumnChangedEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to initialize a new Journal Type
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewJournalType(AutoCount.GeneralMaint.JournalType.JournalTypeEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to validate the data before save, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeSave(AutoCount.GeneralMaint.JournalType.JournalTypeBeforeSaveEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a Journal Type is successfully saved.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterSave(AutoCount.GeneralMaint.JournalType.JournalTypeEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do checking before delete, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeDelete(AutoCount.GeneralMaint.JournalType.JournalTypeBeforeDeleteEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a Journal Type is successfully deleted.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterDelete(AutoCount.GeneralMaint.JournalType.JournalTypeEventArgs e)
        {
        }
    }
}
