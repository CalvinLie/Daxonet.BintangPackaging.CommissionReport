using Microsoft.Win32;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Daxonet.BintangPackaging.CommissionReport
{
    /// <summary>
    /// PrintBarCodeScript contains all event handler which will be called from PrintBarCode.
    /// </summary>
    public class PrintBarCodeScript
    {
        /// <summary>
        /// Use this event to do form initialization
        /// </summary>
        /// <param name="sender">The form itself</param>
        /// <param name="e">The event argument</param>
        public void OnFormInitialize(object sender, AutoCount.Stock.PrintBarCode.FormPrintBarCode.FormInitializeEventArgs e)
        {
        }
    }
}
