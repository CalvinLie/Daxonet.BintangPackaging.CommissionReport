using System;

namespace Daxonet.BintangPackaging.CommissionReport
{
    /// <summary>
    /// CashBookScript contains all event handler which will be called from CashBook.
    /// </summary>
    public class CashBookScript
    {
        #region Logic events

        /// <summary>
        /// Occurs when any of the detail column changed
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnDetailColumnChanged(AutoCount.GL.CashBook.CashBookDetailColumnChangedEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when any of the payment detail column changed
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnPaymentDetailColumnChanged(AutoCount.GL.CashBook.CashBookPaymentDetailColumnChangedEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when any of the master column changed
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnMasterColumnChanged(AutoCount.GL.CashBook.CashBookMasterColumnChangedEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to initialize a new document
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewDocument(AutoCount.GL.CashBook.CashBookEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to initialize a new detail row
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewDetail(AutoCount.GL.CashBook.CashBookNewDetailEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to initialize a new payment detail row
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewPaymentDetail(AutoCount.GL.CashBook.CashBookNewPaymentDetailEventArgs e)
        {
        }

        /// <summary>
		/// Use this event to validate the data before save, if the data is invalid, you can assign your error message to e.ErrorMessage.
		/// </summary>
		/// <param name="e">The event argument</param>
		public void BeforeSave(AutoCount.GL.CashBook.CashBookBeforeSaveEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to update data to database through the e.DBSetting, which will make your update in transaction control.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnSave(AutoCount.GL.CashBook.CashBookOnSaveEventArgs e)
        {
        }

        /// <summary>
        /// Occurs on get new document no
        /// </summary>
        /// <param name="e"></param>
        public void OnGetNewDocumentNo(AutoCount.GL.CashBook.CashBookEventArgs e)
        {
        }

        /// <summary>
		/// Occurs after a document is successfully saved.
		/// </summary>
		/// <param name="e">The event argument</param>
		public void AfterSave(AutoCount.GL.CashBook.CashBookEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do checking before delete, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeDelete(AutoCount.GL.CashBook.CashBookBeforeDeleteEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a document is successfully deleted.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterDelete(AutoCount.GL.CashBook.CashBookEventArgs e)
        {
        }

        #endregion

        #region Edit Form events

        /// <summary>
        /// Use this event to do form initialization
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormInitialize(object sender, AutoCount.GL.CashBook.FormCashBookEntry.FormInitializeEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when the form data binding occurred
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnDataBinding(AutoCount.GL.CashBook.FormCashBookEntry.FormDataBindingEventArgs e)
        {
        }

        /// <summary>
        /// Occurs before save
        /// </summary>
        /// <param name="e"></param>
        public void BeforeSave(AutoCount.GL.CashBook.FormCashBookEntry.FormBeforeSaveEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when the form is shown
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormShow(AutoCount.GL.CashBook.FormCashBookEntry.FormShowEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do form finalization
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormClosed(AutoCount.GL.CashBook.FormCashBookEntry.FormClosedEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when the edit is switch from View mode to Edit mode
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnSwitchToEditMode(AutoCount.GL.CashBook.FormCashBookEntry.FormEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after copy to a document.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterCopyToNewDocument(AutoCount.GL.CashBook.FormCashBookEntry.AfterCopyToNewDocumentEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after copy from other document.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterCopyFromOtherDocument(AutoCount.GL.CashBook.FormCashBookEntry.AfterCopyFromOtherDocumentEventArgs e)
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
