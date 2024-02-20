using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksTerm
{
    public ulong TermId { get; set; }

    public string Name { get; set; } = null!;

    public string Slug { get; set; } = null!;

    public long TermGroup { get; set; }
}
