using System;
using System.Collections.Generic;
using System.Text;

namespace Daxonet.BintangPackaging.CommissionReport
{
    public class SerialNoEntryScript
    {
        /// <summary>
        /// Use this event to do form initialization
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormInitialize(AutoCount.SerialNumber.FormSerialNumberEntry.FormInitializeEventArgs e)
        {
        }

        /// <summary>
        /// Occurs on scan bar code
        /// </summary>
        /// <param name="e"></param>
        public void OnScanBarCode(AutoCount.SerialNumber.FormSerialNumberEntry.ScanBarCodeEventArgs e)
        {
        }
    }
}
