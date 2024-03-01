using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksBwfanAutomationContact
{
    public ulong Id { get; set; }

    public ulong Cid { get; set; }

    public ulong Aid { get; set; }

    public string Event { get; set; } = null!;

    /// <summary>
    /// Start Date
    /// </summary>
    public DateTime CDate { get; set; }

    public ulong ETime { get; set; }

    /// <summary>
    /// 1 - Active | 2 - Failed | 3 - Paused | 4 - Waiting | 5 - Terminate | 6 - Retry
    /// </summary>
    public byte Status { get; set; }

    public ulong Last { get; set; }

    public ulong LastTime { get; set; }

    public string? Data { get; set; }

    public ulong ClaimId { get; set; }

    public byte Attempts { get; set; }

    /// <summary>
    /// Trail ID
    /// </summary>
    public string? Trail { get; set; }
}
