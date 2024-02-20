using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksBwfanAutomation
{
    public ulong Id { get; set; }

    public string Source { get; set; } = null!;

    public string Event { get; set; } = null!;

    /// <summary>
    /// 1 - Active 2 - Inactive
    /// </summary>
    public bool Status { get; set; }

    public sbyte Priority { get; set; }

    public ulong Start { get; set; }

    public byte V { get; set; }

    public string? Benchmark { get; set; }

    public string? Title { get; set; }
}
