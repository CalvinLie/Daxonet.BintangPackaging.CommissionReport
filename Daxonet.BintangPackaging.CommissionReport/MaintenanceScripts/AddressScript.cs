using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daxonet.BintangPackaging.CommissionReport
{
    public class AddressScript
    {
        /// <summary>
        /// Use this event to validate the data before save, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeSave(AutoCount.GeneralMaint.Area.AreaBeforeSaveEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after a Creditor Type is successfully saved.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterSave(AutoCount.GeneralMaint.Area.AreaEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to initialize a new area
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewArea(AutoCount.GeneralMaint.Area.AreaEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do checking before delete, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeDelete(AutoCount.GeneralMaint.Area.AreaBeforeDeleteEventArgs e)
        {
        }

        // <summary>
        /// Occurs after a Creditor Type is successfully deleted.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterDelete(AutoCount.GeneralMaint.Area.AreaEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when any of the columns changed
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnColumnChanged(AutoCount.GeneralMaint.Area.AreaColumnChangedEventArgs e)
        {
        }
    }
}
