using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daxonet.BintangPackaging.CommissionReport
{
    public class ApproveCreditControlScript
    {
        /// <summary>
        /// Occurs before approval
        /// </summary>
        /// <param name="e"></param>
        public void BeforeApproval(AutoCount.Invoicing.FormApproveCreditControl.FormBeforeApprovalEventArgs e)
        {
        }

        /// <summary>
        /// Occurs after approval
        /// </summary>
        /// <param name="e"></param>
        public void AfterApproval(AutoCount.Invoicing.FormApproveCreditControl.FormAfterApprovalEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do form initialization
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormInitialize(AutoCount.Invoicing.FormApproveCreditControl.FormInitializeEventArgs e)
        {
        }
    }
}
