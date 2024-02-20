using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksWcOrderStat
{
    public ulong OrderId { get; set; }

    public ulong ParentId { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime DateCreatedGmt { get; set; }

    public DateTime? DatePaid { get; set; }

    public DateTime? DateCompleted { get; set; }

    public int NumItemsSold { get; set; }

    public double TotalSales { get; set; }

    public double TaxTotal { get; set; }

    public double ShippingTotal { get; set; }

    public double NetTotal { get; set; }

    public bool? ReturningCustomer { get; set; }

    public string Status { get; set; } = null!;

    public ulong CustomerId { get; set; }
}
