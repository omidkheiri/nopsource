using System;
using System.Linq;

namespace Nop.Plugin.Misc.Invoice.Models
{


    public class InvoiceSellIUnit
    {
        public long InvoiceNo { get; set; }
        public string? KEY { get; set; }
        public long OrderNo { get; set; }
        public decimal ItemNo { get; set; }
        public string? EName { get; set; }
        public string? AName { get; set; }
        public short? UnitNo { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public decimal? Discount { get; set; }
        public decimal? Total { get; set; }
        public decimal? TaxRate1Percentage { get; set; }
        public decimal? TaxRate1Total { get; set; }
        public decimal? TotalPlusTax { get; set; }
    }
}
