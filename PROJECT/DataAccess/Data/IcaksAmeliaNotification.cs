using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksAmeliaNotification
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? CustomName { get; set; }

    public string Status { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string Entity { get; set; } = null!;

    public TimeSpan? Time { get; set; }

    public int? TimeBefore { get; set; }

    public int? TimeAfter { get; set; }

    public string SendTo { get; set; } = null!;

    public string Subject { get; set; } = null!;

    public string? Content { get; set; }

    public string? Translations { get; set; }

    public bool? SendOnlyMe { get; set; }

    public string? WhatsAppTemplate { get; set; }

    public string? MinimumTimeBeforeBooking { get; set; }
}
