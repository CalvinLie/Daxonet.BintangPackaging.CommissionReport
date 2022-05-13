using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daxonet.BintangPackaging.CommissionReport
{
    public class AccountantMaintenanceScript
    {
        /// <summary>
        /// Use this event to validate the data before save, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeSave(AutoCount.Options.AccountantBeforeSaveEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a Creditor Type is successfully saved.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterSave(AutoCount.Options.AccountantEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to initialize a new accountant
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewAccountant(AutoCount.Options.AccountantEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do checking before delete, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeDelete(AutoCount.Options.AccountantBeforeDeleteEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a Creditor Type is successfully deleted.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterDelete(AutoCount.Options.AccountantEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when any of the columns changed
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnColumnChanged(AutoCount.Options.AccountantColumnChangedEventArgs e)
        {
        }
    }
}
