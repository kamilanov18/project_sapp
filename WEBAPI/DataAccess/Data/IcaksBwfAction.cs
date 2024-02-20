using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksBwfAction
{
    public ulong Id { get; set; }

    public DateTime CDate { get; set; }

    public int ETime { get; set; }

    public string Hook { get; set; } = null!;

    public string? Args { get; set; }

    /// <summary>
    /// 0 - Pending | 1 - Running
    /// </summary>
    public int Status { get; set; }

    public int RecurringInterval { get; set; }

    public string GroupSlug { get; set; } = null!;

    public ulong ClaimId { get; set; }
}
