using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksBwfanAutomationCompleteContact
{
    public ulong Id { get; set; }

    public ulong Cid { get; set; }

    public ulong Aid { get; set; }

    public string Event { get; set; } = null!;

    /// <summary>
    /// Start Date
    /// </summary>
    public DateTime SDate { get; set; }

    /// <summary>
    /// Completion Date
    /// </summary>
    public DateTime CDate { get; set; }

    public string? Data { get; set; }

    /// <summary>
    /// Trail ID
    /// </summary>
    public string? Trail { get; set; }
}
