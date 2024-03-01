using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksAmeliaExtra
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public double Price { get; set; }

    public int MaxQuantity { get; set; }

    public int? Duration { get; set; }

    public int ServiceId { get; set; }

    public int Position { get; set; }

    public bool? AggregatedPrice { get; set; }

    public string? Translations { get; set; }
}
