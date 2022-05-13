using System;

namespace Daxonet.BintangPackaging.CommissionReport
{
    /// <summary>
    /// CNTypeScript contains the skeleton of the event handler for C/N Type
    /// </summary>
    public class CNTypeScript
    {
        /// <summary>
        /// Occurs when any of the columns changed
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnColumnChanged(AutoCount.GeneralMaint.CNType.CreditNoteTypeColumnChangedEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to initialize a new C/N Type
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewCreditNoteType(AutoCount.GeneralMaint.CNType.CreditNoteTypeEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to validate the data before save, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeSave(AutoCount.GeneralMaint.CNType.CreditNoteTypeBeforeSaveEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a C/N Type is successfully saved.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterSave(AutoCount.GeneralMaint.CNType.CreditNoteTypeEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do checking before delete, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeDelete(AutoCount.GeneralMaint.CNType.CreditNoteTypeBeforeDeleteEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a C/N Type is successfully deleted.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterDelete(AutoCount.GeneralMaint.CNType.CreditNoteTypeEventArgs e)
        {
        }
    }
}
