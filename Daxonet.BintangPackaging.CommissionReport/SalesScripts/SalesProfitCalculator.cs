using System;

namespace Daxonet.BintangPackaging.CommissionReport
{
    /// <summary>
    /// Implements script for SalesProfitCalculator.
    /// </summary>
    public class SalesProfitCalculatorScript
    {
        /// <summary>
        /// Use this event to provide your own unit cost used in Profit Calculator
        /// </summary>
        /// <param name="e">The event argument</param>
        public decimal GetUnitCost(AutoCount.Invoicing.Sales.SalesProfitCalculator.SalesProfitCalculatorEventArgs e)
        {
            return 0M;
        }
    }
}
