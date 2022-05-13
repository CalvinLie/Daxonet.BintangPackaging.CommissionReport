using AutoCount.ARAP;
using AutoCount.ARAP.Debtor;
using AutoCount.Data;
using AutoCount.Localization;
using System;
using System.Data;
using System.Windows.Forms;

namespace Daxonet.BintangPackaging.CommissionReport
{
    /// <summary>
    /// DebtorScript contains the skeleton of the event handler for Debtor
    /// </summary>
	public class DebtorScript
    {
        #region logic events

        /// <summary>
        /// Occurs when any of the master column changed
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnMasterColumnChanged(AutoCount.ARAP.Debtor.DebtorMasterColumnChangedEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to initialize a new debtor
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewDebtor(AutoCount.ARAP.Debtor.DebtorEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to validate the data before save, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeSave(AutoCount.ARAP.Debtor.DebtorBeforeSaveEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a Debtor is successfully saved.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterSave(AutoCount.ARAP.Debtor.DebtorEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do checking before delete, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeDelete(AutoCount.ARAP.Debtor.DebtorBeforeDeleteEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a Debtor is successfully deleted.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterDelete(AutoCount.ARAP.Debtor.DebtorEventArgs e)
        {
        }

        #endregion

        #region form events

        /// <summary>
        /// Occurs on data binding
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnDataBinding(object sender, AutoCount.ARAP.Debtor.FormDebtorEdit.FormEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do form initialization
        /// </summary>
        /// <param name="sender">The form itself</param>
        /// <param name="e">The event argument</param>
        public void OnFormInitialize(object sender, AutoCount.ARAP.Debtor.FormDebtorEdit.FormInitializeEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do form initialization
        /// </summary>
        /// <param name="sender">The form itself</param>
        /// <param name="e">The event argument</param>
        public void OnFormClosed(object sender, AutoCount.ARAP.Debtor.FormDebtorEdit.FormClosedEventArgs e)
        {
        }

        /// <summary>
		/// Occurs when the edit is switch from View mode to Edit mode
		/// </summary>
		/// <param name="sender">The form itself</param>
		/// <param name="e">The event argument</param>
        public void OnSwitchToEditMode(object sender, AutoCount.ARAP.Debtor.FormDebtorEdit.FormEventArgs e)
        {
        }

        #endregion
    }
}
