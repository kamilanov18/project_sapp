using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksWoocommerceTaxRateLocation
{
    public ulong LocationId { get; set; }

    public string LocationCode { get; set; } = null!;

    public ulong TaxRateId { get; set; }

    public string LocationType { get; set; } = null!;
}
