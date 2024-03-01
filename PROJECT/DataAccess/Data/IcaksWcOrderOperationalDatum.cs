using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksWcOrderOperationalDatum
{
    public ulong Id { get; set; }

    public ulong? OrderId { get; set; }

    public string? CreatedVia { get; set; }

    public string? WoocommerceVersion { get; set; }

    public bool? PricesIncludeTax { get; set; }

    public bool? CouponUsagesAreCounted { get; set; }

    public bool? DownloadPermissionGranted { get; set; }

    public string? CartHash { get; set; }

    public bool? NewOrderEmailSent { get; set; }

    public string? OrderKey { get; set; }

    public bool? OrderStockReduced { get; set; }

    public DateTime? DatePaidGmt { get; set; }

    public DateTime? DateCompletedGmt { get; set; }

    public decimal? ShippingTaxAmount { get; set; }

    public decimal? ShippingTotalAmount { get; set; }

    public decimal? DiscountTaxAmount { get; set; }

    public decimal? DiscountTotalAmount { get; set; }

    public bool? RecordedSales { get; set; }
}
