using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksSappEcontCity
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string PostCode { get; set; } = null!;

    public string CountryCode { get; set; } = null!;
}
