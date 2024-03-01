using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksAmeliaEventsToTicket
{
    public int Id { get; set; }

    public long EventId { get; set; }

    public bool? Enabled { get; set; }

    public string Name { get; set; } = null!;

    public double? Price { get; set; }

    public string? DateRanges { get; set; }

    public int Spots { get; set; }

    public string? Translations { get; set; }
}
