using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daxonet.BintangPackaging.CommissionReport
{
    public class DepartmentScript
    {
        #region department

        /// <summary>
        /// Occurs when any of the columns changed
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnColumnChanged(AutoCount.GeneralMaint.Project.DepartmentColumnChangedEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to initialize a new price category
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewDepartment(AutoCount.GeneralMaint.Project.DepartmentEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to validate the data before save, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeSave(AutoCount.GeneralMaint.Project.DepartmentBeforeSaveEventArgs e)
        {
        }

        /// <summary>
		/// Occurs after a Project is successfully saved.
		/// </summary>
        /// <param name="e">The event argument</param>
        public void AfterSave(AutoCount.GeneralMaint.Project.DepartmentEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do checking before delete, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeDelete(AutoCount.GeneralMaint.Project.DepartmentBeforeDeleteEventArgs e)
        {
        }

        /// <summary>
		/// Occurs after a Project is successfully deleted.
		/// </summary>
        /// <param name="e">The event argument</param>
        public void AfterDelete(AutoCount.GeneralMaint.Project.DepartmentEventArgs e)
        {
        }

        #endregion
    }
}
