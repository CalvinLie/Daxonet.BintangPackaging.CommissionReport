using System;
using System.Collections.Generic;
using System.Text;

namespace Daxonet.BintangPackaging.CommissionReport
{
    /// <summary>
    /// LocationScript contains the skeleton of the event handler for Location
    /// </summary>
    public class LocationScript
    {
        #region Logic events

        /// <summary>
        /// Occurs when any of the columns changed
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnColumnChanged(AutoCount.Stock.Location.LocationColumnChangedEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to initialize a new item group
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnNewItemGroup(AutoCount.Stock.Location.LocationEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to validate the data before save, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeSave(AutoCount.Stock.Location.LocationBeforeSaveEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after an Item Group is successfully saved.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterSave(AutoCount.Stock.Location.LocationEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do checking before delete, if the data is invalid, you can assign your error message to e.ErrorMessage.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void BeforeDelete(AutoCount.Stock.Location.LocationBeforeDeleteEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after an Item Group is successfully deleted.
        /// </summary>
        /// <param name="e">The event argument</param>
        public void AfterDelete(AutoCount.Stock.Location.LocationEventArgs e)
        {
        }

        #endregion

        #region Edit Form events

        /// <summary>
        /// Use this event to do form initialization
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormInitialize(AutoCount.Stock.Location.FormLocationEdit.FormInitializeEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when the form is shown
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormShow(AutoCount.Stock.Location.FormLocationEdit.FormShowEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do form finalization
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormClosed(AutoCount.Stock.Location.FormLocationEdit.FormClosedEventArgs e)
        {
        }

        #endregion
    }
}
