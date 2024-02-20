using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksWoocommerceAttributeTaxonomy
{
    public ulong AttributeId { get; set; }

    public string AttributeName { get; set; } = null!;

    public string? AttributeLabel { get; set; }

    public string AttributeType { get; set; } = null!;

    public string AttributeOrderby { get; set; } = null!;

    public int AttributePublic { get; set; }
}
