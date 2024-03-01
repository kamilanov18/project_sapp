using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksAmeliaResource
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int? Quantity { get; set; }

    public string? Shared { get; set; }

    public string Status { get; set; } = null!;

    public bool? CountAdditionalPeople { get; set; }
}
