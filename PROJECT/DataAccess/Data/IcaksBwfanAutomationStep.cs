using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksBwfanAutomationStep
{
    public ulong Id { get; set; }

    public ulong Aid { get; set; }

    /// <summary>
    /// 1 - Wait | 2 - Action | 3 - Goal | 4 - Conditional | 5 - Exit
    /// </summary>
    public byte Type { get; set; }

    public string? Action { get; set; }

    /// <summary>
    /// 1 - Active | 2 - Draft | 3 - Deleted
    /// </summary>
    public bool Status { get; set; }

    public string? Data { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
