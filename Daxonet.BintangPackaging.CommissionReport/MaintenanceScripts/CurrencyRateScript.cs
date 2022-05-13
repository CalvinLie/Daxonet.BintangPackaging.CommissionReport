using System;

namespace Daxonet.BintangPackaging.CommissionReport
{
    /// <summary>
    /// CurrencyRateScript contains the skeleton of the event handler for Currency Rate
    /// </summary>
    public class CurrencyRateScript
    {
        public void OnNewCurrRate(AutoCount.GeneralMaint.Currency.CurrRateEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when any of the columns changed
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnColumnChanged(AutoCount.GeneralMaint.Currency.CurrRateColumnChangedEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to initialize a new Currency Rate
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewCurrency(AutoCount.GeneralMaint.Currency.CurrRateEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to validate the data before save, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeSave(AutoCount.GeneralMaint.Currency.CurrRateBeforeSaveEventArgs e)
        {
        }

        /// <summary>
		/// Occurs after a Currency Rate is successfully saved.
		/// </summary>
        /// <param name="e">The event argument</param>
        public void AfterSave(AutoCount.GeneralMaint.Currency.CurrRateEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do checking before delete, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeDelete(AutoCount.GeneralMaint.Currency.CurrencyBeforeDeleteEventArgs e)
        {
        }

        /// <summary>
		/// Occurs after a Currency Rate is successfully deleted.
		/// </summary>
        /// <param name="e">The event argument</param>
        public void AfterDelete(AutoCount.GeneralMaint.Currency.CurrRateEventArgs e)
        {
        }
    }
}
