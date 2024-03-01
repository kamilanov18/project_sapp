using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksWoocommerceLog
{
    public ulong LogId { get; set; }

    public DateTime Timestamp { get; set; }

    public short Level { get; set; }

    public string Source { get; set; } = null!;

    public string Message { get; set; } = null!;

    public string? Context { get; set; }
}
