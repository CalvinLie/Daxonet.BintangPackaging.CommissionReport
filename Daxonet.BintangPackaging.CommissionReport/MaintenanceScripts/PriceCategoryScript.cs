using System;

namespace Daxonet.BintangPackaging.CommissionReport
{
    /// <summary>
    /// PriceCategoryScript contains the skeleton of the event handler for Price Category
    /// </summary>
    public class PriceCategoryScript
    {
        /// <summary>
        /// Occurs when any of the columns changed
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnColumnChanged(AutoCount.GeneralMaint.PriceCategory.PriceCategoryColumnChangedEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to initialize a new price category
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewPriceCategory(AutoCount.GeneralMaint.PriceCategory.PriceCategoryEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to validate the data before save, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeSave(AutoCount.GeneralMaint.PriceCategory.PriceCategoryBeforeSaveEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a Price Category is successfully saved.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterSave(AutoCount.GeneralMaint.PriceCategory.PriceCategoryEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do checking before delete, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeDelete(AutoCount.GeneralMaint.PriceCategory.PriceCategoryBeforeDeleteEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a Price Category is successfully deleted.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterDelete(AutoCount.GeneralMaint.PriceCategory.PriceCategoryEventArgs e)
        {
        }
    }
}
