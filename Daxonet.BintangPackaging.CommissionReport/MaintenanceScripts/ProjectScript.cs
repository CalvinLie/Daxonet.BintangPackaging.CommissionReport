using System;

namespace Daxonet.BintangPackaging.CommissionReport
{
    /// <summary>
    /// Summary description for ProjectScript.
    /// </summary>
    public class ProjectScript
    {
        #region project

        /// <summary>
        /// Occurs when any of the columns changed
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnColumnChanged(AutoCount.GeneralMaint.Project.ProjectColumnChangedEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to initialize a new price category
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewProject(AutoCount.GeneralMaint.Project.ProjectEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to validate the data before save, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeSave(AutoCount.GeneralMaint.Project.ProjectBeforeSaveEventArgs e)
        {
        }

        /// <summary>
		/// Occurs after a Project is successfully saved.
		/// </summary>
        /// <param name="e">The event argument</param>
        public void AfterSave(AutoCount.GeneralMaint.Project.ProjectEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do checking before delete, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeDelete(AutoCount.GeneralMaint.Project.ProjectBeforeDeleteEventArgs e)
        {
        }

        /// <summary>
		/// Occurs after a Project is successfully deleted.
		/// </summary>
        /// <param name="e">The event argument</param>
        public void AfterDelete(AutoCount.GeneralMaint.Project.ProjectEventArgs e)
        {
        }

        #endregion

    }
}
