using System;
using System.Collections.Generic;

namespace Nop.Plugin.Misc.Invoice.Domain
{
    public partial class InvoiceSellUnit
    {
        public long InvoiceNo { get; set; }
        public decimal BuildingNo { get; set; }
        public int OrderNo { get; set; }
        public decimal ItemNo { get; set; }
        public short? UnitNo { get; set; }
        public string AName { get; set; } = null!;
        public string? EName { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal? QuantityFinished { get; set; }
        public decimal? Discount { get; set; }
        public decimal? DiscountPercent { get; set; }
        public decimal? DiscountTotal { get; set; }
        public decimal? Total { get; set; }
        public decimal? TotalPlusTax { get; set; }
        public bool? IsPosted { get; set; }
        public bool? IsGlposted { get; set; }
        public bool? IsPrint { get; set; }
        public long? LineTypeNo { get; set; }
        public decimal? ProjectNo { get; set; }
        public decimal? AccountNo { get; set; }
        public string? BarCode { get; set; }
        public decimal? CostAccountNo { get; set; }
        public decimal? Cost { get; set; }
        public DateTime? ExpirationDateG { get; set; }
        public long? StoreTransactionNo { get; set; }
        public decimal? BuyPriceCostPrice { get; set; }
        public decimal? BuyPriceCostPrice2 { get; set; }
        public bool? IsServiceCompleted { get; set; }
        public short? TaxCodeNo { get; set; }
        public decimal? TaxRate1Percentage { get; set; }
        public decimal? TaxRate2Percentage { get; set; }
        public short? TaxRateNo2 { get; set; }
        public decimal? TaxRate1Total { get; set; }
        public decimal? TaxRate2Total { get; set; }
        public bool? IsOneInvoiceUploaded { get; set; }
        public short? TaxRateNo { get; set; }
        public decimal? StoreNo { get; set; }
        public decimal? ItemCategoryNo { get; set; }
        public decimal? ItemClassificationTreeNo { get; set; }
        public decimal? ItemLocationNo { get; set; }
        public decimal? ProfitMarginTotal { get; set; }
        public decimal? ItemDepartmentNo { get; set; }
        public int? PrintNumOfCopies { get; set; }
        public string? ItemModel { get; set; }
        public int? PrimaryUnitSelectedUnitOrder { get; set; }
        public decimal? PrimaryUnitQuantity { get; set; }
        public decimal? PrimaryUnitConvertionMultiple { get; set; }
        public decimal? PrimaryUnitConvertionAddition { get; set; }
        public decimal ItemUnitLeastPriceAtThisTime { get; set; }
        public decimal? StoreQuantityBeforePost { get; set; }
        public decimal? AddsQuantity { get; set; }
        public decimal? AddsWeight { get; set; }
        public decimal? QuantityReturned { get; set; }
        public bool? IsReturnedFully { get; set; }
        public decimal? QuantityRemaining { get; set; }
        public decimal? ItemSize { get; set; }
        public string? InsuranceTime { get; set; }
        public string? InsuranceNote { get; set; }
        public string? SerialNo { get; set; }
        public string? SerialNo2 { get; set; }
        public decimal? BuyPrice2 { get; set; }
        public int? ImportOrderNo { get; set; }
        public bool? IsPauseExpiry { get; set; }
        public DateTime? PauseExpiryDateG { get; set; }
        public int? PauseDays { get; set; }
        public int? PauseNumberOfTimesTillNow { get; set; }
        public int? TotalPausedDaysTillNow { get; set; }
        public int? PriceSelectedNo { get; set; }
        public decimal? PriceDifferenceFromFirstPrice { get; set; }
        public decimal? PriceDifferenceFromFirstPriceTotal { get; set; }
        public decimal? RunningCostAvg { get; set; }
        public decimal? RunningCostAvgPerCurrentUnit { get; set; }
        public decimal? RunningCostAvgDiffrenceWhithPrice { get; set; }
        public decimal? RunningCostAvgDiffrenceWhithPriceTotal { get; set; }
        public decimal? ProfitMarginTotalFromAvgCost { get; set; }
        public long? DiscountMultiplicationTypeNo { get; set; }
        public string? Note { get; set; }
        public decimal? RunningCostAvgTotal { get; set; }
        public decimal? BuyPriceCostPriceTotal { get; set; }
        public bool? IsSourceOfContent { get; set; }
        public decimal? Weight { get; set; }
        public decimal? WeightTotal { get; set; }
        public byte[]? RowTimestamp { get; set; }
    }
}
