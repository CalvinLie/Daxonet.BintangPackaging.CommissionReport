using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daxonet.BintangPackaging.CommissionReport
{
    public class OverdueLetterScript
    {
        /// <summary>
        /// Occurs when inquiry function is executed
        /// </summary>
        /// <param name="sender">The form itself</param>
        /// <param name="e">The event argument</param>
        public void OnFormInquiry(object sender, AutoCount.ARAP.AROverdue.FormOverdueLetter.FormInquiryEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do form initialization
        /// </summary>
        /// <param name="sender">The form itself</param>
        /// <param name="e">The event argument</param>
        public void OnFormInitialize(object sender, AutoCount.ARAP.AROverdue.FormOverdueLetter.FormInitializeEventArgs e)
        {
        }
    }
}
