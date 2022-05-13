using System;

namespace Daxonet.BintangPackaging.CommissionReport
{
    /// <summary>
    /// ItemGroupScript contains the skeleton of the event handler for ItemGroup
    /// </summary>
	public class ItemGroupScript
    {
        #region Logic events

        /// <summary>
		/// Occurs when any of the columns changed
		/// </summary>
		/// <param name="e">The event argument</param>
        public void OnColumnChanged(AutoCount.Stock.ItemGroup.ItemGroupColumnChangedEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to initialize a new item group
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewItemGroup(AutoCount.Stock.ItemGroup.ItemGroupEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to validate the data before save, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeSave(AutoCount.Stock.ItemGroup.ItemGroupBeforeSaveEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after an Item Group is successfully saved.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterSave(AutoCount.Stock.ItemGroup.ItemGroupEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do checking before delete, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeDelete(AutoCount.Stock.ItemGroup.ItemGroupBeforeDeleteEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after an Item Group is successfully deleted.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterDelete(AutoCount.Stock.ItemGroup.ItemGroupEventArgs e)
        {
        }

        #endregion

        #region Edit Form events

        /// <summary>
        /// Use this event to do form initialization
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormInitialize(AutoCount.Stock.ItemGroup.FormItemGroupEdit.FormInitializeEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when the form is shown
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormShow(AutoCount.Stock.ItemGroup.FormItemGroupEdit.FormShowEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do form finalization
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormClosed(AutoCount.Stock.ItemGroup.FormItemGroupEdit.FormClosedEventArgs e)
        {
        }

        #endregion
    }
}
