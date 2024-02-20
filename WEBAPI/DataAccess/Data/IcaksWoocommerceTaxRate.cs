using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksWoocommerceTaxRate
{
    public ulong TaxRateId { get; set; }

    public string TaxRateCountry { get; set; } = null!;

    public string TaxRateState { get; set; } = null!;

    public string TaxRate { get; set; } = null!;

    public string TaxRateName { get; set; } = null!;

    public ulong TaxRatePriority { get; set; }

    public int TaxRateCompound { get; set; }

    public int TaxRateShipping { get; set; }

    public ulong TaxRateOrder { get; set; }

    public string TaxRateClass { get; set; } = null!;
}
