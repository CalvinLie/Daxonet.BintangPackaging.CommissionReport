using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daxonet.BintangPackaging.CommissionReport
{
    public class SimpleAPPaymentScript
    {
        /// <summary>
        /// Use this event to do form initialization
        /// </summary>
        /// <param name="sender">The form itself</param>
        /// <param name="e">The event argument</param>
        public void OnFormInitialize(AutoCount.ARAP.APPayment.FormAPPaymentEdit.FormInitializeEventArgs e)
        {
        }

        /// <summary>
        /// Occurs on form before save
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnFormBeforeSave(object sender, AutoCount.ARAP.APPayment.FormAPPaymentEdit.FormInitializeEventArgs e)
        {
        }

        /// <summary>
        /// Occurs on form closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnFormClosed(object sender, AutoCount.ARAP.APPayment.FormAPPaymentEdit.FormClosedEventArgs e)
        {
        }
    }
}
