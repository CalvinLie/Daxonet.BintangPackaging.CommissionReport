using System;

namespace Daxonet.BintangPackaging.CommissionReport
{
    /// <summary>
    /// InvoiceScript contains all event handler which will be called from Invoice.
    /// </summary>
    public class ARDNScript
    {
        #region logic events

        /// <summary>
        /// Occurs when any of the detail column changed
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnDetailColumnChanged(AutoCount.ARAP.ARDN.ARDNDetailColumnChangedEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when any of the master column changed
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnMasterColumnChanged(AutoCount.ARAP.ARDN.ARDNMasterColumnChangedEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to initialize a new document
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewDocument(AutoCount.ARAP.ARDN.ARDNEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to initialize a new detail row
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewDetail(AutoCount.ARAP.ARDN.ARDNNewDetailEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to validate the data before save, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeSave(AutoCount.ARAP.ARDN.ARDNBeforeSaveEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to update data to database through the e.DBSetting, which will make your update in transaction control.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnSave(AutoCount.ARAP.ARDN.ARDNEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a document is successfully saved.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterSave(AutoCount.ARAP.ARDN.ARDNEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do checking before delete, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeDelete(AutoCount.ARAP.ARDN.ARDNBeforeDeleteEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a document is successfully deleted.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterDelete(AutoCount.ARAP.ARDN.ARDNEventArgs e)
        {
        }

        #endregion

        #region form logic

        /// <summary>
        /// Occurs when the form data binding occurred
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnDataBinding(object sender, AutoCount.ARAP.ARDN.FormARDNEdit.FormEventArgs e)
        {
        }

        /// <summary>
		/// Use this event to do form initialization
		/// </summary>
		/// <param name="sender">The form itself</param>
		/// <param name="e">The event argument</param>
		public void OnFormInitialize(object sender, AutoCount.ARAP.ARDN.FormARDNEdit.FormInitializeEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do form initialization
        /// </summary>
        /// <param name="sender">The form itself</param>
        /// <param name="e">The event argument</param>
        public void OnFormClosed(object sender, AutoCount.ARAP.ARDN.FormARDNEdit.FormClosedEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when the edit is switch from View mode to Edit mode
        /// </summary>
        /// <param name="sender">The form itself</param>
        /// <param name="e">The event argument</param>
        public void OnSwitchToEditMode(object sender, AutoCount.ARAP.ARDN.FormARDNEdit.FormEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to control whether allow to print or preview or export before preview is executed.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforePreviewDocument(AutoCount.Report.BeforePreviewDocumentEventArgs e)
        {
        }

        #endregion
    }
}
