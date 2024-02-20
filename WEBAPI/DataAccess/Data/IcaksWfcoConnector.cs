using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksWfcoConnector
{
    public ulong Id { get; set; }

    public DateTime LastSync { get; set; }

    public string? Slug { get; set; }

    /// <summary>
    /// 1 - Active 2 - Inactive
    /// </summary>
    public bool Status { get; set; }
}
