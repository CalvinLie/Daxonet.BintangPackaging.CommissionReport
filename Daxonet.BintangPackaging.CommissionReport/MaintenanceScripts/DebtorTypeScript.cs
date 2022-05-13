using System;

namespace Daxonet.BintangPackaging.CommissionReport
{
    /// <summary>
    /// DebtorTypeScript contains the skeleton of the event handler for Debtor Type
    /// </summary>
    public class DebtorTypeScript
    {
        /// <summary>
        /// Occurs when any of the columns changed
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnColumnChanged(AutoCount.GeneralMaint.DebtorType.DebtorTypeColumnChangedEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to initialize a new Debtor Type
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewDebtorType(AutoCount.GeneralMaint.DebtorType.DebtorTypeEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to validate the data before save, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeSave(AutoCount.GeneralMaint.DebtorType.DebtorTypeBeforeSaveEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a Debtor Type is successfully saved.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterSave(AutoCount.GeneralMaint.DebtorType.DebtorTypeEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do checking before delete, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeDelete(AutoCount.GeneralMaint.DebtorType.DebtorTypeBeforeDeleteEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a Debtor Type is successfully deleted.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterDelete(AutoCount.GeneralMaint.DebtorType.DebtorTypeEventArgs e)
        {
        }
    }
}
