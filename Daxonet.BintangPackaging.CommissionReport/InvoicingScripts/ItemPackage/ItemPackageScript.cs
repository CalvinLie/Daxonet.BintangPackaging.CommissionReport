using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daxonet.BintangPackaging.CommissionReport
{
    public class ItemPackageScript
    {
        #region logic events

        /// <summary>
        /// Use this event to initialize a new document
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewDocument(AutoCount.Stock.ItemPackage.ItemPackageEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to validate the data before save, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeSave(AutoCount.Stock.ItemPackage.ItemPackageBeforeSaveEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to update data to database through the e.DBSetting, which will make your update in transaction control.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnSave(AutoCount.Stock.ItemPackage.ItemPackageOnSaveEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a document is successfully saved.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterSave(AutoCount.Stock.ItemPackage.ItemPackageEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do checking before delete, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeDelete(AutoCount.Stock.ItemPackage.ItemPackageBeforeDeleteEventArgs e)
        {
        }

        /// <summary>
        /// Occurs on delete
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnDelete(AutoCount.Stock.ItemPackage.ItemPackageOnDeleteEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a document is successfully deleted.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterDelete(AutoCount.Stock.ItemPackage.ItemPackageEventArgs e)
        {
        }

        /// <summary>
        /// Occurs on new detail
        /// </summary>
        /// <param name="e"></param>
        public void OnNewDetail(AutoCount.Stock.ItemPackage.ItemPackageNewDetailEventArgs e)
        {
        }

        /// <summary>
        /// Occurs on master column changed
        /// </summary>
        /// <param name="e"></param>
        public void OnMasterColumnChanged(AutoCount.Stock.ItemPackage.ItemPackageMasterColumnChangedEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when any of the detail column changed
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnDetailColumnChanged(AutoCount.Stock.ItemPackage.ItemPackageDetailColumnChangedEventArgs e)
        {
        }

        #endregion

        #region form events

        /// <summary>
        /// Occurs when the form data binding occurred
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnDataBinding(AutoCount.Stock.ItemPackage.FormItemPackageEntry.FormDataBindingEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when the edit is switch from View mode to Edit mode
        /// </summary>
        /// <param name="sender">The form itself</param>
        /// <param name="e">The event argument</param>
        public void OnSwitchToEditMode(AutoCount.Stock.ItemPackage.FormItemPackageEntry.FormEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do form initialization
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormInitialize(AutoCount.Stock.ItemPackage.FormItemPackageEntry.FormInitializeEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do form initialization
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormClosed(AutoCount.Stock.ItemPackage.FormItemPackageEntry.FormClosedEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when the form is shown
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormShow(AutoCount.Stock.ItemPackage.FormItemPackageEntry.FormShowEventArgs e)
        {
        }

        #endregion
    }
}
