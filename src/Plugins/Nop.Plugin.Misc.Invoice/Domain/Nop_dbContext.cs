using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Nop.Data;

namespace Nop.Plugin.Misc.Invoice.Domain
{
    public partial class Nop_dbContext : DbContext
    {
        public Nop_dbContext()
        {
        }

        public Nop_dbContext(DbContextOptions<Nop_dbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<InvoiceSell> InvoiceSells { get; set; } = null!;
        public virtual DbSet<InvoiceSellUnit> InvoiceSellUnits { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = DataSettingsManager.LoadSettings().ConnectionString;
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InvoiceSell>(entity =>
            {
                entity.HasKey(e => new { e.BuildingNo, e.InvoiceNo,e.Id })
                    .HasName("PK_Table_1");

                entity.ToTable("InvoiceSell");

                entity.Property(e => e.BuildingNo)
                    .HasColumnType("decimal(28, 0)")
                    .HasColumnName("buildingNo");

                entity.Property(e => e.InvoiceNo).HasColumnName("invoiceNo");

                entity.Property(e => e.AName)
                    .HasMaxLength(250)
                    .HasColumnName("aName");

                entity.Property(e => e.AccountNo)
                    .HasColumnType("decimal(21, 0)")
                    .HasColumnName("accountNo");

                entity.Property(e => e.AccountNoDiscount)
                    .HasColumnType("decimal(21, 0)")
                    .HasColumnName("accountNo_Discount");

                entity.Property(e => e.AccountNoPay)
                    .HasColumnType("decimal(21, 0)")
                    .HasColumnName("accountNo_Pay");

                entity.Property(e => e.AccountNoSecond)
                    .HasColumnType("decimal(21, 0)")
                    .HasColumnName("accountNo_Second");

                entity.Property(e => e.AccountNoShip)
                    .HasColumnType("decimal(21, 0)")
                    .HasColumnName("accountNo_Ship");

                entity.Property(e => e.AgentNo).HasColumnName("agentNo");

                entity.Property(e => e.AmountCalculated)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("amountCalculated");

                entity.Property(e => e.AmountCalculatedPayed)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("amountCalculatedPayed");

                entity.Property(e => e.AmountLeft)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("amountLeft");

                entity.Property(e => e.AmountLeftAfterAllBills)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("amountLeftAfterAllBills");

                entity.Property(e => e.AmountPayed01)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("amountPayed01");

                entity.Property(e => e.AmountPayed01BankAccountNo)
                    .HasColumnType("decimal(21, 0)")
                    .HasColumnName("amountPayed01_bankAccountNo");

                entity.Property(e => e.AmountPayed01VoucherNo)
                    .HasMaxLength(21)
                    .HasColumnName("amountPayed01_VoucherNo");

                entity.Property(e => e.AmountPayed02)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("amountPayed02");

                entity.Property(e => e.AmountPayed02BankAccountNo)
                    .HasColumnType("decimal(21, 0)")
                    .HasColumnName("amountPayed02_bankAccountNo");

                entity.Property(e => e.AmountPayed02VoucherNo)
                    .HasMaxLength(21)
                    .HasColumnName("amountPayed02_VoucherNo");

                entity.Property(e => e.AmountPayed03)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("amountPayed03");

                entity.Property(e => e.AmountPayed03BankAccountNo)
                    .HasColumnType("decimal(21, 0)")
                    .HasColumnName("amountPayed03_bankAccountNo");

                entity.Property(e => e.AmountPayed03VoucherNo)
                    .HasMaxLength(21)
                    .HasColumnName("amountPayed03_VoucherNo");

                entity.Property(e => e.AmountPayed04)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("amountPayed04");

                entity.Property(e => e.AmountPayed04BankAccountNo)
                    .HasColumnType("decimal(21, 0)")
                    .HasColumnName("amountPayed04_bankAccountNo");

                entity.Property(e => e.AmountPayed04VoucherNo)
                    .HasMaxLength(21)
                    .HasColumnName("amountPayed04_VoucherNo");

                entity.Property(e => e.AmountPayed05)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("amountPayed05");

                entity.Property(e => e.AmountPayed05BankAccountNo)
                    .HasColumnType("decimal(21, 0)")
                    .HasColumnName("amountPayed05_bankAccountNo");

                entity.Property(e => e.AmountPayed05VoucherNo)
                    .HasMaxLength(21)
                    .HasColumnName("amountPayed05_VoucherNo");

                entity.Property(e => e.BillCreatorAsOf).HasColumnName("billCreatorAsOf");

                entity.Property(e => e.BillNo).HasColumnName("billNo");

                entity.Property(e => e.BillPaperType).HasColumnName("billPaperType");

                entity.Property(e => e.BillTo)
                    .HasMaxLength(27)
                    .HasColumnName("billTo");

                entity.Property(e => e.BillToBuildingNo)
                    .HasColumnType("decimal(28, 0)")
                    .HasColumnName("billToBuildingNo");

                entity.Property(e => e.BillToTypeNo).HasColumnName("billToTypeNo");

                entity.Property(e => e.BillTypeNo).HasColumnName("billTypeNo");

                entity.Property(e => e.BuyPriceCostPriceTotal)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("buyPrice_costPriceTotal");

                entity.Property(e => e.CarNo).HasColumnName("carNo");

                entity.Property(e => e.CardAmountSpan)
                    .HasColumnType("decimal(13, 6)")
                    .HasColumnName("cardAmount_SPAN");

                entity.Property(e => e.CardAmountVisa)
                    .HasColumnType("decimal(13, 6)")
                    .HasColumnName("cardAmount_Visa");

                entity.Property(e => e.CashRegisterNoBuildingNo)
                    .HasColumnType("decimal(28, 0)")
                    .HasColumnName("cashRegisterNo_BuildingNo");

                entity.Property(e => e.ClientVendorNo)
                    .HasColumnType("decimal(21, 0)")
                    .HasColumnName("clientVendorNo");

                entity.Property(e => e.CollectedAmountFromOtherBills)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("collectedAmountFromOtherBills");

                entity.Property(e => e.CustomerCashGiven)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("customerCashGiven");

                entity.Property(e => e.CustomerCashReturned)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("customerCashReturned");

                entity.Property(e => e.DailyBillNo).HasColumnName("dailyBillNo");

                entity.Property(e => e.DateG)
                    .HasColumnType("date")
                    .HasColumnName("dateG");

                entity.Property(e => e.DateGGlposted)
                    .HasColumnType("date")
                    .HasColumnName("dateG_GLPosted");

                entity.Property(e => e.DateGPerDay)
                    .HasColumnType("date")
                    .HasColumnName("dateG_PerDay");

                entity.Property(e => e.DateGPerMonth).HasColumnName("dateG_PerMonth");

                entity.Property(e => e.DateGPerYear).HasColumnName("dateG_PerYear");

                entity.Property(e => e.DateGPerYearHalf).HasColumnName("dateG_PerYearHalf");

                entity.Property(e => e.DateGPerYearQuarter).HasColumnName("dateG_PerYearQuarter");

                entity.Property(e => e.DateGPosted)
                    .HasColumnType("date")
                    .HasColumnName("dateG_Posted");

                entity.Property(e => e.DateH)
                    .HasMaxLength(20)
                    .HasColumnName("dateH");

                entity.Property(e => e.DeliveredDate)
                    .HasColumnType("date")
                    .HasColumnName("deliveredDate");

                entity.Property(e => e.DeliveredDateH)
                    .HasMaxLength(20)
                    .HasColumnName("deliveredDateH");

                entity.Property(e => e.DeliveryDate)
                    .HasColumnType("date")
                    .HasColumnName("deliveryDate");

                entity.Property(e => e.DeliveryDateH)
                    .HasMaxLength(20)
                    .HasColumnName("deliveryDateH");

                entity.Property(e => e.DepositNo).HasColumnName("depositNo");

                entity.Property(e => e.Discount)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("discount");

                entity.Property(e => e.DriverName)
                    .HasMaxLength(250)
                    .HasColumnName("driverName");

                entity.Property(e => e.DriverNo).HasColumnName("driverNo");

                entity.Property(e => e.DueDate)
                    .HasColumnType("date")
                    .HasColumnName("dueDate");

                entity.Property(e => e.EName)
                    .HasMaxLength(250)
                    .HasColumnName("eName");

                entity.Property(e => e.ExportImportType).HasColumnName("exportImportType");

                entity.Property(e => e.GazElectricInNum)
                    .HasMaxLength(20)
                    .HasColumnName("gazElectric_InNum");

                entity.Property(e => e.GaztElectricOutNum)
                    .HasMaxLength(20)
                    .HasColumnName("gaztElectric_OutNum");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Idcard)
                    .HasMaxLength(27)
                    .HasColumnName("IDCard");

                entity.Property(e => e.Inventory1StaffNo).HasColumnName("inventory1StaffNo");

                entity.Property(e => e.Inventory2StaffNo).HasColumnName("inventory2StaffNo");

                entity.Property(e => e.InvoiceJobStatusNo).HasColumnName("invoiceJobStatusNo");

                entity.Property(e => e.InvoiceStatusNo).HasColumnName("invoiceStatusNo");

                entity.Property(e => e.InvoiceVatid)
                    .HasMaxLength(50)
                    .HasColumnName("invoiceVATID");

                entity.Property(e => e.IsAccountingForOthers).HasColumnName("isAccountingForOthers");

                entity.Property(e => e.IsCalculateTax2OnTax1).HasColumnName("isCalculateTax2OnTax1");

                entity.Property(e => e.IsCash).HasColumnName("isCash");

                entity.Property(e => e.IsCleared).HasColumnName("isCleared");

                entity.Property(e => e.IsCompleted).HasColumnName("isCompleted");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.IsDelivered).HasColumnName("isDelivered");

                entity.Property(e => e.IsDeposited).HasColumnName("isDeposited");

                entity.Property(e => e.IsFastInvoice).HasColumnName("isFastInvoice");

                entity.Property(e => e.IsGlposted).HasColumnName("isGLPosted");

                entity.Property(e => e.IsInventory1GaveIt).HasColumnName("isInventory1GaveIt");

                entity.Property(e => e.IsInventory2ReceivedIt).HasColumnName("isInventory2ReceivedIt");

                entity.Property(e => e.IsItemOrUnit).HasColumnName("isItemOrUnit");

                entity.Property(e => e.IsOneInvoiceUploaded).HasColumnName("isOneInvoiceUploaded");

                entity.Property(e => e.IsOutDelivery).HasColumnName("isOutDelivery");

                entity.Property(e => e.IsPayments).HasColumnName("isPayments");

                entity.Property(e => e.IsPosted).HasColumnName("isPosted");

                entity.Property(e => e.IsPostedStock).HasColumnName("isPostedStock");

                entity.Property(e => e.IsPostedToTransactions).HasColumnName("isPostedToTransactions");

                entity.Property(e => e.IsPrintPartial).HasColumnName("isPrintPartial");

                entity.Property(e => e.IsReturnedFullyByReturnInvoice).HasColumnName("isReturnedFullyByReturnInvoice");

                entity.Property(e => e.IsReturnedFullyByReturnInvoiceDate)
                    .HasColumnType("date")
                    .HasColumnName("isReturnedFullyByReturnInvoiceDate");

                entity.Property(e => e.IsTax1OnShipping).HasColumnName("isTax1OnShipping");

                entity.Property(e => e.IsTax2OnShipping).HasColumnName("isTax2OnShipping");

                entity.Property(e => e.IsUploadedToMainBranch).HasColumnName("isUploadedToMainBranch");

                entity.Property(e => e.IsUseInOutInvoice).HasColumnName("isUseInOutInvoice");

                entity.Property(e => e.IsVoid).HasColumnName("isVoid");

                entity.Property(e => e.ItemStatus).HasColumnName("itemStatus");

                entity.Property(e => e.LeftMoneyPaymentDate)
                    .HasColumnType("date")
                    .HasColumnName("leftMoneyPaymentDate");

                entity.Property(e => e.MainContact1)
                    .HasMaxLength(50)
                    .HasColumnName("mainContact1");

                entity.Property(e => e.MainContact2)
                    .HasMaxLength(50)
                    .HasColumnName("mainContact2");

                entity.Property(e => e.MainContact3)
                    .HasMaxLength(50)
                    .HasColumnName("mainContact3");

                entity.Property(e => e.ManGlposted).HasColumnName("manGLPosted");

                entity.Property(e => e.ManPosted).HasColumnName("manPosted");

                entity.Property(e => e.ManVoid).HasColumnName("manVoid");

                entity.Property(e => e.NameDiscount)
                    .HasMaxLength(150)
                    .HasColumnName("name_Discount");

                entity.Property(e => e.NamePay)
                    .HasMaxLength(150)
                    .HasColumnName("name_Pay");

                entity.Property(e => e.NameShip)
                    .HasMaxLength(150)
                    .HasColumnName("name_Ship");

                entity.Property(e => e.NormalCustomerTypeNo).HasColumnName("normalCustomerTypeNo");

                entity.Property(e => e.Note)
                    .HasMaxLength(250)
                    .HasColumnName("note");

                entity.Property(e => e.PackedDate)
                    .HasColumnType("date")
                    .HasColumnName("packedDate");

                entity.Property(e => e.PaperBillNum)
                    .HasMaxLength(20)
                    .HasColumnName("paperBillNum");

                entity.Property(e => e.PayBillNo)
                    .HasColumnType("decimal(28, 0)")
                    .HasColumnName("payBillNo");

                entity.Property(e => e.PaymentTermsId).HasColumnName("paymentTermsId");

                entity.Property(e => e.PaymentTypes)
                    .HasMaxLength(50)
                    .HasColumnName("paymentTypes");

                entity.Property(e => e.PersonNo).HasColumnName("personNo");

                entity.Property(e => e.PersonNo2).HasColumnName("personNo2");

                entity.Property(e => e.PickedDate)
                    .HasColumnType("date")
                    .HasColumnName("pickedDate");

                entity.Property(e => e.PriceDifferenceFromFirstPriceTotal)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("price_differenceFromFirstPriceTotal");

                entity.Property(e => e.PricingSchemeId).HasColumnName("pricingSchemeId");

                entity.Property(e => e.PrimaryUnitQuantityTotal)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("primaryUnit_QuantityTotal");

                entity.Property(e => e.PrintDateG)
                    .HasColumnType("date")
                    .HasColumnName("print_DateG");

                entity.Property(e => e.PrintNumOfCopies).HasColumnName("print_numOfCopies");

                entity.Property(e => e.ProfitMarginTotal)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("profitMarginTotal");

                entity.Property(e => e.ProfitMarginTotalFromAvgCost)
                    .HasColumnType("decimal(22, 6)")
                    .HasColumnName("profitMarginTotal_fromAvgCost");

                entity.Property(e => e.ProjectNo)
                    .HasColumnType("decimal(27, 0)")
                    .HasColumnName("projectNo");

                entity.Property(e => e.RegionNo)
                    .HasColumnType("decimal(27, 0)")
                    .HasColumnName("regionNo");

                entity.Property(e => e.RequestShipDate)
                    .HasColumnType("date")
                    .HasColumnName("requestShipDate");

                entity.Property(e => e.RowTimestamp)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("row_timestamp");

                entity.Property(e => e.RunningCostAvgDiffrenceWhithPriceTotal)
                    .HasColumnType("decimal(22, 6)")
                    .HasColumnName("runningCostAvg_diffrenceWhithPriceTotal");

                entity.Property(e => e.RunningCostAvgTotal)
                    .HasColumnType("decimal(22, 6)")
                    .HasColumnName("runningCostAvgTotal");

                entity.Property(e => e.ShipCost)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("shipCost");

                entity.Property(e => e.ShipTo)
                    .HasMaxLength(250)
                    .HasColumnName("shipTo");

                entity.Property(e => e.ShipType).HasColumnName("shipType");

                entity.Property(e => e.StaffNo1PersonNo).HasColumnName("staffNo1_personNo");

                entity.Property(e => e.StaffNo2PersonNo).HasColumnName("staffNo2_personNo");

                entity.Property(e => e.StaffNo3PersonNo).HasColumnName("staffNo3_personNo");

                entity.Property(e => e.StoreNo)
                    .HasColumnType("decimal(28, 0)")
                    .HasColumnName("storeNo");

                entity.Property(e => e.SubCount).HasColumnName("subCount");

                entity.Property(e => e.SubLeftQuantity)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("subLeftQuantity");

                entity.Property(e => e.SubNetTotal)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("subNetTotal");

                entity.Property(e => e.SubNetTotalExecludingTax)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("subNetTotal_ExecludingTax");

                entity.Property(e => e.SubNetTotalPlusTax)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("subNetTotalPlusTax");

                entity.Property(e => e.SubQuantity)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("subQuantity");

                entity.Property(e => e.SubTotal)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("subTotal");

                entity.Property(e => e.SubTotalDiscount)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("subTotalDiscount");

                entity.Property(e => e.SumPayed)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("sumPayed");

                entity.Property(e => e.TaxRate1Percentage)
                    .HasColumnType("decimal(12, 7)")
                    .HasColumnName("taxRate1_Percentage");

                entity.Property(e => e.TaxRate1Total)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("taxRate1_Total");

                entity.Property(e => e.TaxRate1aName)
                    .HasMaxLength(150)
                    .HasColumnName("taxRate1aName");

                entity.Property(e => e.TaxRate1eName)
                    .HasMaxLength(150)
                    .HasColumnName("taxRate1eName");

                entity.Property(e => e.TaxRate2Percentage)
                    .HasColumnType("decimal(12, 7)")
                    .HasColumnName("taxRate2_Percentage");

                entity.Property(e => e.TaxRate2Total)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("taxRate2_Total");

                entity.Property(e => e.TaxRate2aName)
                    .HasMaxLength(150)
                    .HasColumnName("taxRate2aName");

                entity.Property(e => e.TaxRate2eName)
                    .HasMaxLength(150)
                    .HasColumnName("taxRate2eName");

                entity.Property(e => e.TaxRateNo).HasColumnName("taxRateNo");

                entity.Property(e => e.TaxRateNo2).HasColumnName("taxRateNo2");

                entity.Property(e => e.TaxingSchemeNo).HasColumnName("taxingSchemeNo");

                entity.Property(e => e.Telephone)
                    .HasMaxLength(15)
                    .HasColumnName("telephone");

                entity.Property(e => e.TotalDiscount)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("totalDiscount");

                entity.Property(e => e.UserNumber)
                    .HasMaxLength(20)
                    .HasColumnName("userNumber");

                entity.Property(e => e.VatgroupNo).HasColumnName("VATGroupNo");

                entity.Property(e => e.VattypeNo).HasColumnName("VATTypeNo");

                entity.Property(e => e.WeightTotal)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("weightTotal");
            });

            modelBuilder.Entity<InvoiceSellUnit>(entity =>
            {
                entity.HasKey(e => new { e.InvoiceNo, e.BuildingNo, e.OrderNo });

                entity.ToTable("InvoiceSellUnit");

                entity.Property(e => e.InvoiceNo).HasColumnName("invoiceNo");

                entity.Property(e => e.BuildingNo)
                    .HasColumnType("decimal(28, 0)")
                    .HasColumnName("buildingNo");

                entity.Property(e => e.OrderNo).HasColumnName("orderNo");

                entity.Property(e => e.AName)
                    .HasMaxLength(250)
                    .HasColumnName("aName");

                entity.Property(e => e.AccountNo)
                    .HasColumnType("decimal(21, 0)")
                    .HasColumnName("accountNo");

                entity.Property(e => e.AddsQuantity)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("addsQuantity");

                entity.Property(e => e.AddsWeight)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("addsWeight");

                entity.Property(e => e.BarCode)
                    .HasMaxLength(24)
                    .HasColumnName("barCode");

                entity.Property(e => e.BuyPrice2)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("buyPrice2");

                entity.Property(e => e.BuyPriceCostPrice)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("buyPrice_costPrice");

                entity.Property(e => e.BuyPriceCostPrice2)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("buyPrice_costPrice2");

                entity.Property(e => e.BuyPriceCostPriceTotal)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("buyPrice_costPriceTotal");

                entity.Property(e => e.Cost)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("cost");

                entity.Property(e => e.CostAccountNo)
                    .HasColumnType("decimal(21, 0)")
                    .HasColumnName("costAccountNo");

                entity.Property(e => e.Discount)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("discount");

                entity.Property(e => e.DiscountMultiplicationTypeNo).HasColumnName("discountMultiplicationTypeNo");

                entity.Property(e => e.DiscountPercent)
                    .HasColumnType("decimal(12, 7)")
                    .HasColumnName("discountPercent");

                entity.Property(e => e.DiscountTotal)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("discountTotal");

                entity.Property(e => e.EName)
                    .HasMaxLength(250)
                    .HasColumnName("eName");

                entity.Property(e => e.ExpirationDateG)
                    .HasColumnType("date")
                    .HasColumnName("expirationDateG");

                entity.Property(e => e.ImportOrderNo).HasColumnName("importOrderNo");

                entity.Property(e => e.InsuranceNote)
                    .HasMaxLength(50)
                    .HasColumnName("insuranceNote");

                entity.Property(e => e.InsuranceTime)
                    .HasMaxLength(27)
                    .HasColumnName("insuranceTime");

                entity.Property(e => e.IsGlposted).HasColumnName("isGLPosted");

                entity.Property(e => e.IsOneInvoiceUploaded).HasColumnName("isOneInvoiceUploaded");

                entity.Property(e => e.IsPauseExpiry).HasColumnName("isPauseExpiry");

                entity.Property(e => e.IsPosted).HasColumnName("isPosted");

                entity.Property(e => e.IsPrint).HasColumnName("isPrint");

                entity.Property(e => e.IsReturnedFully).HasColumnName("isReturnedFully");

                entity.Property(e => e.IsServiceCompleted).HasColumnName("isServiceCompleted");

                entity.Property(e => e.IsSourceOfContent).HasColumnName("isSourceOfContent");

                entity.Property(e => e.ItemCategoryNo)
                    .HasColumnType("decimal(27, 0)")
                    .HasColumnName("itemCategoryNo");

                entity.Property(e => e.ItemClassificationTreeNo)
                    .HasColumnType("decimal(27, 0)")
                    .HasColumnName("itemClassificationTreeNo");

                entity.Property(e => e.ItemDepartmentNo)
                    .HasColumnType("decimal(27, 0)")
                    .HasColumnName("itemDepartmentNo");

                entity.Property(e => e.ItemLocationNo)
                    .HasColumnType("decimal(27, 0)")
                    .HasColumnName("itemLocationNo");

                entity.Property(e => e.ItemModel)
                    .HasMaxLength(60)
                    .HasColumnName("itemModel");

                entity.Property(e => e.ItemNo)
                    .HasColumnType("decimal(28, 0)")
                    .HasColumnName("itemNo");

                entity.Property(e => e.ItemSize)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("itemSize");

                entity.Property(e => e.ItemUnitLeastPriceAtThisTime)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("itemUnitLeastPriceAtThisTime");

                entity.Property(e => e.LineTypeNo).HasColumnName("lineTypeNo");

                entity.Property(e => e.Note)
                    .HasMaxLength(150)
                    .HasColumnName("note");

                entity.Property(e => e.PauseDays).HasColumnName("pauseDays");

                entity.Property(e => e.PauseExpiryDateG)
                    .HasColumnType("date")
                    .HasColumnName("pauseExpiryDateG");

                entity.Property(e => e.PauseNumberOfTimesTillNow).HasColumnName("pauseNumberOfTimesTillNow");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("price");

                entity.Property(e => e.PriceDifferenceFromFirstPrice)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("price_differenceFromFirstPrice");

                entity.Property(e => e.PriceDifferenceFromFirstPriceTotal)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("price_differenceFromFirstPriceTotal");

                entity.Property(e => e.PriceSelectedNo).HasColumnName("price_selectedNo");

                entity.Property(e => e.PrimaryUnitConvertionAddition)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("primaryUnit_ConvertionAddition");

                entity.Property(e => e.PrimaryUnitConvertionMultiple)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("primaryUnit_ConvertionMultiple");

                entity.Property(e => e.PrimaryUnitQuantity)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("primaryUnit_Quantity");

                entity.Property(e => e.PrimaryUnitSelectedUnitOrder).HasColumnName("primaryUnit_SelectedUnitOrder");

                entity.Property(e => e.PrintNumOfCopies).HasColumnName("print_numOfCopies");

                entity.Property(e => e.ProfitMarginTotal)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("profitMarginTotal");

                entity.Property(e => e.ProfitMarginTotalFromAvgCost)
                    .HasColumnType("decimal(22, 6)")
                    .HasColumnName("profitMarginTotal_fromAvgCost");

                entity.Property(e => e.ProjectNo)
                    .HasColumnType("decimal(27, 0)")
                    .HasColumnName("projectNo");

                entity.Property(e => e.Quantity)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("quantity");

                entity.Property(e => e.QuantityFinished)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("quantityFinished");

                entity.Property(e => e.QuantityRemaining)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("quantityRemaining");

                entity.Property(e => e.QuantityReturned)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("quantityReturned");

                entity.Property(e => e.RowTimestamp)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("row_timestamp");

                entity.Property(e => e.RunningCostAvg)
                    .HasColumnType("decimal(22, 6)")
                    .HasColumnName("runningCostAvg");

                entity.Property(e => e.RunningCostAvgDiffrenceWhithPrice)
                    .HasColumnType("decimal(22, 6)")
                    .HasColumnName("runningCostAvg_diffrenceWhithPrice");

                entity.Property(e => e.RunningCostAvgDiffrenceWhithPriceTotal)
                    .HasColumnType("decimal(22, 6)")
                    .HasColumnName("runningCostAvg_diffrenceWhithPriceTotal");

                entity.Property(e => e.RunningCostAvgPerCurrentUnit)
                    .HasColumnType("decimal(22, 6)")
                    .HasColumnName("runningCostAvg_perCurrentUnit");

                entity.Property(e => e.RunningCostAvgTotal)
                    .HasColumnType("decimal(22, 6)")
                    .HasColumnName("runningCostAvgTotal");

                entity.Property(e => e.SerialNo)
                    .HasMaxLength(24)
                    .HasColumnName("serialNo");

                entity.Property(e => e.SerialNo2)
                    .HasMaxLength(24)
                    .HasColumnName("serialNo2");

                entity.Property(e => e.StoreNo)
                    .HasColumnType("decimal(28, 0)")
                    .HasColumnName("storeNo");

                entity.Property(e => e.StoreQuantityBeforePost)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("store_QuantityBeforePost");

                entity.Property(e => e.StoreTransactionNo).HasColumnName("storeTransactionNo");

                entity.Property(e => e.TaxCodeNo).HasColumnName("taxCodeNo");

                entity.Property(e => e.TaxRate1Percentage)
                    .HasColumnType("decimal(12, 7)")
                    .HasColumnName("taxRate1_Percentage");

                entity.Property(e => e.TaxRate1Total)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("taxRate1_Total");

                entity.Property(e => e.TaxRate2Percentage)
                    .HasColumnType("decimal(12, 7)")
                    .HasColumnName("taxRate2_Percentage");

                entity.Property(e => e.TaxRate2Total)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("taxRate2_Total");

                entity.Property(e => e.TaxRateNo).HasColumnName("taxRateNo");

                entity.Property(e => e.TaxRateNo2).HasColumnName("taxRateNo2");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("total");

                entity.Property(e => e.TotalPausedDaysTillNow).HasColumnName("totalPausedDaysTillNow");

                entity.Property(e => e.TotalPlusTax)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("totalPlusTax");

                entity.Property(e => e.UnitNo).HasColumnName("unitNo");

                entity.Property(e => e.Weight)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("weight");

                entity.Property(e => e.WeightTotal)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("weightTotal");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
