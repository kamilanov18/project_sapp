using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksBwfanMessageUnsubscribe
{
    public ulong Id { get; set; }

    public string? Recipient { get; set; }

    /// <summary>
    /// 1 - Email 2 - SMS
    /// </summary>
    public bool? Mode { get; set; }

    public DateTime CDate { get; set; }

    public ulong? AutomationId { get; set; }

    /// <summary>
    /// 1 - Automation 2 - Broadcast 3 - Manual 4 - Form
    /// </summary>
    public bool? CType { get; set; }

    /// <summary>
    /// Step ID
    /// </summary>
    public ulong Sid { get; set; }
}
