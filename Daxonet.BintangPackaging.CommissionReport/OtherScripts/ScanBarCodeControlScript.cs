using System;

namespace Daxonet.BintangPackaging.CommissionReport
{
    /// <summary>
    /// Implements script for ScanBarCodeControl.
    /// </summary>
	public class ScanBarCodeControlScript
    {
        /// <summary>
        /// Occurs when scan bar code
        /// </summary>
        /// <param name="e">A bar code event argument</param>
        public void ScanBarCode(AutoCount.Stock.ScanBarCodeEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when bar code is going to input into the corresponding entry form.
        /// </summary>
        /// <param name="e">A bar code input event argument</param>
        public void OnBarCodeInput(AutoCount.Stock.OnBarCodeInputEventArgs e)
        {
        }
    }
}
