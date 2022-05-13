using System;

namespace Daxonet.BintangPackaging.CommissionReport
{
    /// <summary>
    /// InvoiceScript contains all event handler which will be called from Invoice.
    /// </summary>
    public class APInvoiceScript
    {
        #region logic events

        /// <summary>
        /// Occurs when any of the detail column changed
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnDetailColumnChanged(AutoCount.ARAP.APInvoice.APInvoiceDetailColumnChangedEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when any of the master column changed
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnMasterColumnChanged(AutoCount.ARAP.APInvoice.APInvoiceMasterColumnChangedEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to initialize a new document
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewDocument(AutoCount.ARAP.APInvoice.APInvoiceEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to initialize a new detail row
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewDetail(AutoCount.ARAP.APInvoice.APInvoiceNewDetailEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to validate the data before save, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeSave(AutoCount.ARAP.APInvoice.APInvoiceBeforeSaveEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to update data to database through the e.DBSetting, which will make your update in transaction control.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnSave(AutoCount.ARAP.APInvoice.APInvoiceEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a document is successfully saved.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterSave(AutoCount.ARAP.APInvoice.APInvoiceEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do checking before delete, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeDelete(AutoCount.ARAP.APInvoice.APInvoiceBeforeDeleteEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a document is successfully deleted.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterDelete(AutoCount.ARAP.APInvoice.APInvoiceEventArgs e)
        {
        }

        #endregion

        #region form events

        /// <summary>
        /// Occurs when the form data binding occurred
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnDataBinding(object sender, AutoCount.ARAP.APInvoice.FormAPInvoiceEdit.FormEventArgs e)
        {
        }

        /// <summary>
		/// Use this event to do form initialization
		/// </summary>
		/// <param name="sender">The form itself</param>
		/// <param name="e">The event argument</param>
		public void OnFormInitialize(object sender, AutoCount.ARAP.APInvoice.FormAPInvoiceEdit.FormInitializeEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do form finalization
        /// </summary>
        /// <param name="sender">The form itself</param>
        /// <param name="e">The event argument</param>
        public void OnFormClosed(object sender, AutoCount.ARAP.APInvoice.FormAPInvoiceEdit.FormClosedEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when the edit is switch from View mode to Edit mode
        /// </summary>
        /// <param name="sender">The form itself</param>
        /// <param name="e">The event argument</param>
        public void OnSwitchToEditMode(object sender, AutoCount.ARAP.APInvoice.FormAPInvoiceEdit.FormEventArgs e)
        {
        }

        #endregion
    }
}
