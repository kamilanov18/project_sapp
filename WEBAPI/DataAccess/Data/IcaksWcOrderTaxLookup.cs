using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksWcOrderTaxLookup
{
    public ulong OrderId { get; set; }

    public ulong TaxRateId { get; set; }

    public DateTime DateCreated { get; set; }

    public double ShippingTax { get; set; }

    public double OrderTax { get; set; }

    public double TotalTax { get; set; }
}
