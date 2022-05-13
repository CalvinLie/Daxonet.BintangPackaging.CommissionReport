using System;

namespace Daxonet.BintangPackaging.CommissionReport
{
    /// <summary>
    /// PostingAccountGroupScript contains the skeleton of the event handler for Posting Account Group
    /// </summary>
    public class PostingAccountGroupScript
    {
        /// <summary>
        /// Occurs when any of the columns changed
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnColumnChanged(AutoCount.GL.PostingAccountGroup.PostingAccountGroupColumnChangedEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to initialize a new posting account group
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewPostingAccountGroup(AutoCount.GL.PostingAccountGroup.PostingAccountGroupEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to validate the data before save, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeSave(AutoCount.GL.PostingAccountGroup.PAGroupBeforeSaveEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a Posting Account Group is successfully saved.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterSave(AutoCount.GL.PostingAccountGroup.PostingAccountGroupEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do checking before delete, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeDelete(AutoCount.GL.PostingAccountGroup.PostingAccountGroupBeforeDeleteEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a Posting Account Group is successfully deleted.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterDelete(AutoCount.GL.PostingAccountGroup.PostingAccountGroupEventArgs e)
        {
        }
    }
}
