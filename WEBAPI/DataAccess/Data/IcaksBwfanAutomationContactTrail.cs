using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksBwfanAutomationContactTrail
{
    public ulong Id { get; set; }

    /// <summary>
    /// Trail ID
    /// </summary>
    public string Tid { get; set; } = null!;

    /// <summary>
    /// Contact ID
    /// </summary>
    public ulong Cid { get; set; }

    /// <summary>
    /// Automation ID
    /// </summary>
    public ulong Aid { get; set; }

    /// <summary>
    /// Step ID
    /// </summary>
    public ulong Sid { get; set; }

    public ulong CTime { get; set; }

    /// <summary>
    /// 1 - Success | 2 - Wait | 3 - Failed | 4 - Skipped
    /// </summary>
    public byte Status { get; set; }

    public string? Data { get; set; }
}
