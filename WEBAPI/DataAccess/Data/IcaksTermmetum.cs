using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksTermmetum
{
    public ulong MetaId { get; set; }

    public ulong TermId { get; set; }

    public string? MetaKey { get; set; }

    public string? MetaValue { get; set; }
}
