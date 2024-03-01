using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksBwfWcCustomer
{
    public uint Id { get; set; }

    public int Cid { get; set; }

    public DateTime LOrderDate { get; set; }

    public DateTime FOrderDate { get; set; }

    public int TotalOrderCount { get; set; }

    public double TotalOrderValue { get; set; }

    public double Aov { get; set; }

    public string? PurchasedProducts { get; set; }

    public string? PurchasedProductsCats { get; set; }

    public string? PurchasedProductsTags { get; set; }

    public string? UsedCoupons { get; set; }
}
