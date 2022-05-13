using System;

namespace Daxonet.BintangPackaging.CommissionReport
{
    /// <summary>
    /// DNTypeScript contains the skeleton of the event handler for D/N Type
    /// </summary>
    public class DNTypeScript
    {
        /// <summary>
        /// Occurs when any of the columns changed
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnColumnChanged(AutoCount.GeneralMaint.DNType.DebitNoteTypeColumnChangedEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to initialize a new D/N Type
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewDebitNoteType(AutoCount.GeneralMaint.DNType.DebitNoteTypeEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to validate the data before save, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeSave(AutoCount.GeneralMaint.DNType.DebitNoteTypeBeforeSaveEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a D/N Type is successfully saved.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterSave(AutoCount.GeneralMaint.DNType.DebitNoteTypeEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do checking before delete, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeDelete(AutoCount.GeneralMaint.DNType.DebitNoteTypeBeforeDeleteEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a D/N Type is successfully deleted.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterDelete(AutoCount.GeneralMaint.DNType.DebitNoteTypeEventArgs e)
        {
        }
    }
}
