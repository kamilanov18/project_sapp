using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksTermRelationship
{
    public ulong ObjectId { get; set; }

    public ulong TermTaxonomyId { get; set; }

    public int TermOrder { get; set; }
}
