using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksWcProductAttributesLookup
{
    public long ProductId { get; set; }

    public long ProductOrParentId { get; set; }

    public string Taxonomy { get; set; } = null!;

    public long TermId { get; set; }

    public bool IsVariationAttribute { get; set; }

    public bool InStock { get; set; }
}
