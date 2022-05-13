using AutoCount.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Daxonet.BintangPackaging.CommissionReport
{
    /// <summary>
    /// Implements script for ItemEditForm.
    /// </summary>
    public class ItemEditFormScript
    {

        /// <summary>
		/// Use this event to do form initialization
		/// </summary>
		/// <param name="e">The event argument</param>
        public void OnFormInitialize(AutoCount.Stock.Item.FormStockItem.FormInitializeEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when the form data binding occurred
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnDataBinding(AutoCount.Stock.Item.FormStockItem.FormDataBindingEventArgs e)
        {
        }

        private void MasterTable_ColumnChanged(object sender, System.Data.DataColumnChangeEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when the form is shown
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormShow(AutoCount.Stock.Item.FormStockItem.FormShowEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do form finalization
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormClosed(AutoCount.Stock.Item.FormStockItem.FormClosedEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when the edit is switch from View mode to Edit mode
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnSwitchToEditMode(AutoCount.Stock.Item.FormStockItem.FormEventArgs e)
        {
        }
    }
}
