using AutoCount.Document;
using System;
using System.Data;

namespace Daxonet.BintangPackaging.CommissionReport
{
    /// <summary>
    /// Summary description for ItemMaintenance.
    /// </summary>
    public class ItemMaintenanceScript
    {
        #region Logic events

        /// <summary>
		/// Occurs when any of the detail column (Item Uom) changed
		/// </summary>
		/// <param name="e">The event argument</param>
        public void OnItemUomColumnChanged(AutoCount.Stock.Item.StockItemUomColumnChangedEventArgs e)
        {

        }

        /// <summary>
        /// Occurs when any of the master column (Item) changed
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnItemColumnChanged(AutoCount.Stock.Item.StockItemColumnChangedEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to initialize a new item
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewItem(AutoCount.Stock.Item.StockItemEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to initialize a new Item Uom row
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewItemUom(AutoCount.Stock.Item.StockItemNewUomEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to validate the data before save, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeSave(AutoCount.Stock.Item.StockItemBeforeSaveEventArgs e)
        {

        }

        /// <summary>
        /// Occurs after an Item is successfully saved.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterSave(AutoCount.Stock.Item.StockItemEventArgs e)
        {
        }

        public void OnNavigate(AutoCount.Stock.Item.StockItemOnNavigateEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do checking before delete, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeDelete(AutoCount.Stock.Item.StockItemBeforeDeleteEventArgs e)
        {
        }

        /// <summary>
		/// Occurs after an Item is successfully deleted.
		/// </summary>
		/// <param name="e">The event argument</param>
		public void AfterDelete(AutoCount.Stock.Item.StockItemEventArgs e)
        {
        }

        #endregion

        #region Edit Form events

        /// <summary>
        /// Use this event to do form initialization
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormInitialize(object sender, AutoCount.Stock.Item.FormStockItem.LayoutFormInitializeEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when the form data binding occurred
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnDataBinding(AutoCount.Stock.Item.FormStockItem.LayoutFormDataBindingEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when the form is shown
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormShow(AutoCount.Stock.Item.FormStockItem.LayoutFormShowEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do form finalization
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormClosed(AutoCount.Stock.Item.FormStockItem.LayoutFormClosedEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when the edit is switch from View mode to Edit mode
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnSwitchToEditMode(AutoCount.Stock.Item.FormStockItem.LayoutFormEventArgs e)
        {
        }

        public void AfterNavigate(AutoCount.Stock.Item.FormStockItem.LayoutFormNavigateEventArgs e)
        {
        }

        public void OnNavigate(AutoCount.Stock.Item.FormStockItem.LayoutFormNavigateEventArgs e)
        {
        }

        #endregion
    }
}
