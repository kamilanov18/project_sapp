using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksAmeliaCustomField
{
    public int Id { get; set; }

    public string Label { get; set; } = null!;

    public string Type { get; set; } = null!;

    public bool Required { get; set; }

    public int Position { get; set; }

    public string? Translations { get; set; }

    public bool? AllServices { get; set; }

    public bool? AllEvents { get; set; }

    public bool? UseAsLocation { get; set; }
}
