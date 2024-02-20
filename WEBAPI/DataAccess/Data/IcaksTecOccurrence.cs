using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksTecOccurrence
{
    public ulong OccurrenceId { get; set; }

    public ulong EventId { get; set; }

    public ulong PostId { get; set; }

    public string StartDate { get; set; } = null!;

    public string StartDateUtc { get; set; } = null!;

    public string EndDate { get; set; } = null!;

    public string EndDateUtc { get; set; } = null!;

    public int? Duration { get; set; }

    public string Hash { get; set; } = null!;

    public DateTime UpdatedAt { get; set; }
}
