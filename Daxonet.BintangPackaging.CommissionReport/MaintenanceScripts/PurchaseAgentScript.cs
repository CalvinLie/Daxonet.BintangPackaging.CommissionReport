using System;

namespace Daxonet.BintangPackaging.CommissionReport
{
    /// <summary>
    /// PurchaseAgentScript contains the skeleton of the event handler for Purchase Agent
    /// </summary>
    public class PurchaseAgentScript
    {
        /// <summary>
        /// Occurs when any of the columns changed
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnColumnChanged(AutoCount.GeneralMaint.PurchaseAgent.PurchaseAgentColumnChangedEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to initialize a new Purchase Agent
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewPurchaseAgent(AutoCount.GeneralMaint.PurchaseAgent.PurchaseAgentEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to validate the data before save, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeSave(AutoCount.GeneralMaint.PurchaseAgent.PurchaseAgentBeforeSaveEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a Purchase Agent is successfully saved.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterSave(AutoCount.GeneralMaint.PurchaseAgent.PurchaseAgentEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do checking before delete, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeDelete(AutoCount.GeneralMaint.PurchaseAgent.PurchaseAgentBeforeDeleteEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a Purchase Agent is successfully deleted.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterDelete(AutoCount.GeneralMaint.PurchaseAgent.PurchaseAgentEventArgs e)
        {
        }
    }
}
