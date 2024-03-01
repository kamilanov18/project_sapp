using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksTecEvent
{
    public ulong EventId { get; set; }

    public ulong PostId { get; set; }

    public string StartDate { get; set; } = null!;

    public string? EndDate { get; set; }

    public string Timezone { get; set; } = null!;

    public string StartDateUtc { get; set; } = null!;

    public string? EndDateUtc { get; set; }

    public int? Duration { get; set; }

    public DateTime UpdatedAt { get; set; }

    public string Hash { get; set; } = null!;
}
