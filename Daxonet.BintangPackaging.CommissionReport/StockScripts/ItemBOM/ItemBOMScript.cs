using System;
using System.Collections.Generic;
using System.Text;

namespace Daxonet.BintangPackaging.CommissionReport
{
    public class ItemBOMScript
    {
        #region Logic events

        /// <summary>
        /// Occurs when any of the detail column changed
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnDetailColumnChanged(AutoCount.Stock.Item.DetailColumnChangedEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when any of the master column changed
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnMasterColumnChanged(AutoCount.Stock.Item.MasterColumnChangedEventArgs e)
        {

        }

        /// <summary>
        /// Use this event to initialize a new document
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewDocument(AutoCount.Stock.Item.ItemBomEventArgs e)
        {

        }

        /// <summary>
        /// Use this event to initialize a new detail row
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewDetail(AutoCount.Stock.Item.ItemBomNewDetailEventArgs e)
        {

        }

        /// <summary>
        /// Use this event to validate the data before save, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeSave(AutoCount.Stock.Item.ItemBomBeforeSaveEventArgs e)
        {


        }

        /// <summary>
        /// Use this event to validate the data before save, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnSave(AutoCount.Stock.Item.ItemBomOnSaveEventArgs e)
        {


        }

        public void AfterSave(AutoCount.Stock.Item.ItemBomEventArgs e)
        {

        }

        /// <summary>
        /// Use this event to do checking before delete, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeDelete(AutoCount.Stock.Item.ItemBomBeforeDeleteEventArgs e)
        {

        }

        public void OnDelete(AutoCount.Stock.Item.ItemBomOnDeleteEventArgs e)
        {

        }

        /// <summary>
        /// Occurs after a document is successfully deleted.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterDelete(AutoCount.Stock.Item.ItemBomEventArgs e)
        {
        }

        #endregion

        #region Edit Form events

        /// <summary>
        /// Use this event to do form initialization
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormInitialize(AutoCount.Stock.Item.FormItemBomEntry.FormInitializeEventArgs e)
        {

        }

        /// <summary>
        /// Occurs when the form data binding occurred
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnDataBinding(AutoCount.Stock.Item.FormItemBomEntry.FormDataBindingEventArgs e)
        {

        }

        /// <summary>
        /// Use this event to do form closed
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormClosed(AutoCount.Stock.Item.FormItemBomEntry.FormClosedEventArgs e)
        {

        }

        #endregion
    }
}
