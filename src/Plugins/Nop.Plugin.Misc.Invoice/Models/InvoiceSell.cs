using System;
using System.Linq;

namespace Nop.Plugin.Misc.Invoice.Models
{
    public class InvoiceSell
    {
        public string? DateH { get; set; }
        public DateTime DateG { get; set; }
        public long InvoiceNo { get; set; }
        public string? EName { get; set; }
        public string? MainContact1 { get; set; }
        public string? AName { get; set; }
        public string? InvoiceVatid { get; set; }
        public decimal? ClientVendorNo { get; set; }

        public bool? IsVoid { get; set; }
        public bool? IsPosted { get; set; }
        public bool? IsPayments { get; set; }
        public bool? IsOutDelivery { get; set; }

        public decimal? SubNetTotalPlusTax { get; set; }
        public decimal? TaxRate1Total { get; set; }
        public decimal? SubNetTotal { get; set; }
        public decimal? SubTotalDiscount { get; set; }
        public decimal? SubQuantity { get; set; }
        public decimal? AmountLeftAfterAllBills { get; set; }
        public decimal? AmountLeft { get; set; }

        public List<InvoiceSellIUnit>? InvoiceSellIUnits { get; set; }
    }
}
