using System;

namespace Daxonet.BintangPackaging.CommissionReport
{
    /// <summary>
    /// InvoiceScript contains all event handler which will be called from Invoice.
    /// </summary>
    public class APPaymentScript
    {
        #region logic events

        /// <summary>
        /// Occurs before post GL
        /// </summary>
        /// <param name="e"></param>
        public void BeforePostGL(AutoCount.ARAP.APPayment.APPaymentBeforePostGLEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when any of the detail column changed
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnDetailColumnChanged(AutoCount.ARAP.APPayment.APPaymentDetailColumnChangedEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when any of the master column changed
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnMasterColumnChanged(AutoCount.ARAP.APPayment.APPaymentMasterColumnChangedEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to initialize a new document
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewDocument(AutoCount.ARAP.APPayment.APPaymentEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to initialize a new detail row
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewDetail(AutoCount.ARAP.APPayment.APPaymentNewDetailEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to validate the data before save, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeSave(AutoCount.ARAP.APPayment.APPaymentBeforeSaveEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to update data to database through the e.DBSetting, which will make your update in transaction control.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnSave(AutoCount.ARAP.APPayment.APPaymentEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a document is successfully saved.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterSave(AutoCount.ARAP.APPayment.APPaymentEventArgs e)
        {
        }

        /// <summary>
        /// Occurs before cancel
        /// </summary>
        /// <param name="e"></param>
        public void BeforeCancel(AutoCount.ARAP.APPayment.APPaymentBeforeSaveEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do checking before delete, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeDelete(AutoCount.ARAP.APPayment.APPaymentBeforeDeleteEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a document is successfully deleted.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterDelete(AutoCount.ARAP.APPayment.APPaymentEventArgs e)
        {
        }

        #endregion

        #region form events

        /// <summary>
        /// Occurs when the form data binding occurred
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnDataBinding(object sender, AutoCount.ARAP.APPayment.FormAPPaymentEdit.FormEventArgs e)
        {
        }

        /// <summary>
		/// Use this event to do form initialization
		/// </summary>
		/// <param name="sender">The form itself</param>
		/// <param name="e">The event argument</param>
		public void OnFormInitialize(object sender, AutoCount.ARAP.APPayment.FormAPPaymentEdit.FormInitializeEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do form initialization
        /// </summary>
        /// <param name="sender">The form itself</param>
        /// <param name="e">The event argument</param>
        public void OnFormClosed(object sender, AutoCount.ARAP.APPayment.FormAPPaymentEdit.FormClosedEventArgs e)
        {
        }

        /// <summary>
        /// Occurs on knock off column changed
        /// </summary>
        /// <param name="e"></param>
        public void OnKnockOffColumnChanged(AutoCount.ARAP.APPayment.FormAPPaymentEdit.APPaymentKnockOffColumnChangedEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when the edit is switch from View mode to Edit mode
        /// </summary>
        /// <param name="sender">The form itself</param>
        /// <param name="e">The event argument</param>
        public void OnSwitchToEditMode(object sender, AutoCount.ARAP.APPayment.FormAPPaymentEdit.FormEventArgs e)
        {
        }

        /// <summary>
        /// Occurs with discount
        /// </summary>
        /// <param name="e"></param>
        public void WithDiscount(AutoCount.ARAP.APPayment.FormAPPaymentEdit.APPaymentWithDiscountEventArgs e)
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

        #region Simple AP Payment
        /// <summary>
        /// Use this event to do form initialization
        /// </summary>
        /// <param name="sender">The form itself</param>
        /// <param name="e">The event argument</param>
        public void OnFormInitialize(AutoCount.ARAP.APPayment.FormSimpleAPPaymentEdit.FormInitializeEventArgs e)
        {
        }

        /// <summary>
        /// Occurs on form before save
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnFormBeforeSave(object sender, AutoCount.ARAP.APPayment.FormSimpleAPPaymentEdit.FormInitializeEventArgs e)
        {
        }

        /// <summary>
        /// Occurs on form closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnFormClosed(object sender, AutoCount.ARAP.APPayment.FormSimpleAPPaymentEdit.FormClosedEventArgs e)
        {
        }
        #endregion
    }
}
