using System;

namespace Daxonet.BintangPackaging.CommissionReport
{
    /// <summary>
    /// TaxTypeScript contains the skeleton of the event handler for Tax Type
    /// </summary>
    public class TaxTypeScript
    {
        /// <summary>
        /// Occurs when any of the columns changed
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnColumnChanged(AutoCount.Tax.TaxTypeMaintenance.TaxTypeColumnChangedEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to initialize a new tax type
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewTaxType(AutoCount.Tax.TaxTypeMaintenance.TaxTypeEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to validate the data before save, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeSave(AutoCount.Tax.TaxTypeMaintenance.TaxTypeBeforeSaveEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a Tax Type is successfully saved.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterSave(AutoCount.Tax.TaxTypeMaintenance.TaxTypeEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do checking before delete, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeDelete(AutoCount.Tax.TaxTypeMaintenance.TaxTypeBeforeDeleteEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a Tax Type is successfully deleted.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterDelete(AutoCount.Tax.TaxTypeMaintenance.TaxTypeEventArgs e)
        {
        }
    }
}
