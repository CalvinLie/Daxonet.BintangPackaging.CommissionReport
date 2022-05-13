using System;

namespace Daxonet.BintangPackaging.CommissionReport
{
    /// <summary>
    /// Summary description for ItemGroupScript.
    /// </summary>
    public class SalesAgentScript
    {
        #region Logic events

        /// <summary>
		/// Occurs when any of the columns changed
		/// </summary>
		/// <param name="e">The event argument</param>
        public void OnColumnChanged(AutoCount.GeneralMaint.SalesAgent.SalesAgentColumnChangedEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to initialize a new Sales Agent
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewSalesAgent(AutoCount.GeneralMaint.SalesAgent.SalesAgentEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to validate the data before save, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeSave(AutoCount.GeneralMaint.SalesAgent.SalesAgentBeforeSaveEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after an Item Group is successfully saved.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterSave(AutoCount.GeneralMaint.SalesAgent.SalesAgentEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do checking before delete, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeDelete(AutoCount.GeneralMaint.SalesAgent.SalesAgentBeforeDeleteEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after an Sales Agent is successfully deleted.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterDelete(AutoCount.GeneralMaint.SalesAgent.SalesAgentEventArgs e)
        {
        }

        #endregion

        #region Edit Form events

        /// <summary>
        /// Use this event to do form initialization
        /// </summary>
        /// <param name="sender">The form itself</param>
        /// <param name="e">The event argument</param>
        public void OnFormInitialize(AutoCount.GeneralMaint.SalesAgent.FormSalesAgentEdit.FormInitializeEventArgs e)
        {
        }

        #endregion
    }
}
