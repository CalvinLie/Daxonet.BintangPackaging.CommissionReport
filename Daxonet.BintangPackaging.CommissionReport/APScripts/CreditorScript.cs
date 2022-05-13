using System;

namespace Daxonet.BintangPackaging.CommissionReport
{
    /// <summary>
    /// CreditorScript contains the skeleton of the event handler for Creditor
    /// </summary>
	public class CreditorScript
    {
        #region logic events

        /// <summary>
        /// Occurs when any of the master column changed
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnMasterColumnChanged(AutoCount.ARAP.Creditor.CreditorMasterColumnChangedEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to initialize a new creditor
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewCreditor(AutoCount.ARAP.Creditor.CreditorEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to validate the data before save, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeSave(AutoCount.ARAP.Creditor.CreditorBeforeSaveEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a Creditor is successfully saved.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterSave(AutoCount.ARAP.Creditor.CreditorEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do checking before delete, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeDelete(AutoCount.ARAP.Creditor.CreditorBeforeDeleteEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a Creditor is successfully deleted.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterDelete(AutoCount.ARAP.Creditor.CreditorEventArgs e)
        {
        }

        #endregion

        #region form events

        /// <summary>
        /// Use this event to do form initialization
        /// </summary>
        /// <param name="sender">The form itself</param>
        /// <param name="e">The event argument</param>
        public void OnFormInitialize(object sender, AutoCount.ARAP.Creditor.FormCreditorEdit.FormInitializeEventArgs e)
        {
        }

        /// <summary>
        /// Occurs on data binding
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnDataBinding(object sender, AutoCount.ARAP.Creditor.FormCreditorEdit.FormEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do form initialization
        /// </summary>
        /// <param name="sender">The form itself</param>
        /// <param name="e">The event argument</param>
        public void OnFormClosed(object sender, AutoCount.ARAP.Creditor.FormCreditorEdit.FormClosedEventArgs e)
        {
        }

        /// <summary>
		/// Occurs when the edit is switch from View mode to Edit mode
		/// </summary>
		/// <param name="sender">The form itself</param>
		/// <param name="e">The event argument</param>
		public void OnSwitchToEditMode(object sender, AutoCount.ARAP.Creditor.FormCreditorEdit.FormEventArgs e)
        {
        }

        #endregion
    }
}
