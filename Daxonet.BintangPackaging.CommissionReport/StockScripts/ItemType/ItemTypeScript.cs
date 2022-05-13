using System;

namespace Daxonet.BintangPackaging.CommissionReport
{
    /// <summary>
    /// ItemTypeScript contains the skeleton of the event handler for ItemType
    /// </summary>
	public class ItemTypeScript
    {
        #region Logic events

        /// <summary>
		/// Occurs when any of the columns changed
		/// </summary>
		/// <param name="e">The event argument</param>
        public void OnColumnChanged(AutoCount.Stock.ItemType.ItemTypeColumnChangedEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to initialize a new item type
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewItemType(AutoCount.Stock.ItemType.ItemTypeEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to validate the data before save, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeSave(AutoCount.Stock.ItemType.ItemTypeBeforeSaveEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after an Item Type is successfully saved.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterSave(AutoCount.Stock.ItemType.ItemTypeEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do checking before delete, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeDelete(AutoCount.Stock.ItemType.ItemTypeBeforeDeleteEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after an Item Type is successfully deleted.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterDelete(AutoCount.Stock.ItemType.ItemTypeEventArgs e)
        {
        }

        #endregion

        #region Edit Form events

        /// <summary>
        /// Use this event to do form initialization
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormInitialize(AutoCount.Stock.ItemType.FormItemTypeEdit.FormInitializeEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when the form is shown
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormShow(AutoCount.Stock.ItemType.FormItemTypeEdit.FormShowEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do form finalization
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormClosed(AutoCount.Stock.ItemType.FormItemTypeEdit.FormClosedEventArgs e)
        {
        }

        #endregion
    }
}
