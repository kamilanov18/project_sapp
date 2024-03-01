using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksBwfanAbandonedcart
{
    public ulong Id { get; set; }

    public string Email { get; set; } = null!;

    public int Status { get; set; }

    public long UserId { get; set; }

    public DateTime LastModified { get; set; }

    public DateTime CreatedTime { get; set; }

    public string? Items { get; set; }

    public string? Coupons { get; set; }

    public string? Fees { get; set; }

    public string? ShippingTaxTotal { get; set; }

    public string? ShippingTotal { get; set; }

    public string? Total { get; set; }

    public string? TotalBase { get; set; }

    public string Token { get; set; } = null!;

    public string Currency { get; set; } = null!;

    public string CookieKey { get; set; } = null!;

    public string? CheckoutData { get; set; }

    public long OrderId { get; set; }

    public long CheckoutPageId { get; set; }
}
