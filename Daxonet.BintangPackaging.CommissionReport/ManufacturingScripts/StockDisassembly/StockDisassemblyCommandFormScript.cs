using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daxonet.BintangPackaging.CommissionReport
{
    public class StockDisassemblyCommandFormScript
    {
        /// <summary>
		/// Use this event to do form initialization
		/// </summary>
		/// <param name="e">The event argument</param>
        public void OnFormInitialize(AutoCount.Manufacturing.StockDisassembly.FormStockDisassemblyCmd.FormInitializeEventArgs e)
        {
        }

        /// <summary>
        /// Occurs when the form has loaded data
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormLoadData(AutoCount.Manufacturing.StockDisassembly.FormStockDisassemblyCmd.FormLoadDataEventArgs e)
        {
        }

        /// <summary>
        /// Use this event to do form finalization
        /// </summary>
        /// <param name="e">The event argument</param>
        public void OnFormClosed(AutoCount.Manufacturing.StockDisassembly.FormStockDisassemblyCmd.FormClosedEventArgs e)
        {
        }

        public void BeforePreviewDocument(AutoCount.Report.BeforePreviewDocumentEventArgs e)
        {
        }
    }
}
