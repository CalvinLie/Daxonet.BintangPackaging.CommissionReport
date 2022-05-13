using System;

namespace Daxonet.BintangPackaging.CommissionReport
{
    /// <summary>
    /// ShippingMethodScripts contains the skeleton of the event handler for Shipping Method
    /// </summary>
    public class ShippingMethodScripts
    {
        /// <summary>
        /// Occurs when any of the columns changed
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnColumnChanged(AutoCount.GeneralMaint.ShippingMethod.ShippingMethodColumnChangedEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to initialize a new Shipping Method
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewShippingMethod(AutoCount.GeneralMaint.ShippingMethod.ShippingMethodEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to validate the data before save, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeSave(AutoCount.GeneralMaint.ShippingMethod.ShippingMethodBeforeSaveEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a Shipping Method is successfully saved.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterSave(AutoCount.GeneralMaint.ShippingMethod.ShippingMethodEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do checking before delete, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeDelete(AutoCount.GeneralMaint.ShippingMethod.ShippingMethodBeforeDeleteEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a Shipping Method is successfully deleted.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterDelete(AutoCount.GeneralMaint.ShippingMethod.ShippingMethodEventArgs e)
        {
        }
    }
}
