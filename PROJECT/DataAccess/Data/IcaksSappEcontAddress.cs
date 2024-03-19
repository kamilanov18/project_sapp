using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksSappEcontAddress
{
    public int Id { get; set; }

    public int CityId { get; set; }

    public string Street { get; set; } = null!;

    public string? FullAddress { get; set; }

    public string? Num { get; set; }

    public string? Other { get; set; }

    public string? Quarter { get; set; }

    public string? Zip { get; set; }
}
