using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksBwfFunnelmetum
{
    public ulong MetaId { get; set; }

    public ulong BwfFunnelId { get; set; }

    public string? MetaKey { get; set; }

    public string? MetaValue { get; set; }
}
