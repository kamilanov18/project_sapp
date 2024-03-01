using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksWcTaxRateClass
{
    public ulong TaxRateClassId { get; set; }

    public string Name { get; set; } = null!;

    public string Slug { get; set; } = null!;
}
