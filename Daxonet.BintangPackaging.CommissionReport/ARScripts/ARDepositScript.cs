using System;

namespace Daxonet.BintangPackaging.CommissionReport
{
    /// <summary>
    /// APDepositScript contains all event handler which will be called from ARDeposit.
    /// </summary>
    public class ARDepositScript
    {
        #region logic events

        /// <summary>
        /// Occurs when any of the detail column changed
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnDetailColumnChanged(AutoCount.ARAP.ARDeposit.ARDepositDetailColumnChangedEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when any of the refund detail column changed
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnRefundDetailColumnChanged(AutoCount.ARAP.ARDeposit.ARDepositRefundDetailColumnChangedEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when any of the master column changed
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnMasterColumnChanged(AutoCount.ARAP.ARDeposit.ARDepositMasterColumnChangedEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to initialize a new document
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewDocument(AutoCount.ARAP.ARDeposit.ARDepositEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to initialize a new detail row
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewDetail(AutoCount.ARAP.ARDeposit.ARDepositNewDetailEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to initialize a new refund detail row
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewRefundDetail(AutoCount.ARAP.ARDeposit.ARDepositNewRefundDetailEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to validate the data before save, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeSave(AutoCount.ARAP.ARDeposit.ARDepositBeforeSaveEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after save
        /// </summary>
        /// <param name="e"></param>
        public void AfterSave(AutoCount.ARAP.ARDeposit.ARDepositEventArgs e)
        {
        }

        /// <summary>
        /// Occurs on get new refund document no
        /// </summary>
        /// <param name="e"></param>
        public void OnGetNewRefundDocumentNo(AutoCount.ARAP.ARDeposit.ARDepositEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a document is successfully saved.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnSave(AutoCount.ARAP.ARDeposit.ARDepositOnSaveEventArgs e)
        {
        }

        /// <summary>
        /// Occurs on get new document no
        /// </summary>
        /// <param name="e"></param>
        public void OnGetNewDocumentNo(AutoCount.ARAP.ARDeposit.ARDepositEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do checking before delete, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeDelete(AutoCount.ARAP.ARDeposit.ARDepositBeforeDeleteEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a document is successfully deleted.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterDelete(AutoCount.ARAP.ARDeposit.ARDepositEventArgs e)
        {
        }

        #endregion

        #region form events

        /// <summary>
        /// Use this event to do form initialization
        /// </summary>
        /// <param name="sender">The form itself</param>
        /// <param name="e">The event argument</param>
        public void OnFormInitialize(object sender, AutoCount.ARAP.ARDeposit.FormInitializeEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do form initialization
        /// </summary>
        /// <param name="sender">The form itself</param>
        /// <param name="e">The event argument</param>
        public void OnFormClosed(object sender, AutoCount.ARAP.ARDeposit.FormClosedEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when the edit is switch from View mode to Edit mode
        /// </summary>
        /// <param name="sender">The form itself</param>
        /// <param name="e">The event argument</param>
        public void OnSwitchToEditMode(object sender, AutoCount.ARAP.ARDeposit.FormEventArgs e)
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
