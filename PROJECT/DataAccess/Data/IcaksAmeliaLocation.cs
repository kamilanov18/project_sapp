using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksAmeliaLocation
{
    public int Id { get; set; }

    public string Status { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string Address { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public decimal Latitude { get; set; }

    public decimal Longitude { get; set; }

    public string? PictureFullPath { get; set; }

    public string? PictureThumbPath { get; set; }

    public string? Pin { get; set; }

    public string? Translations { get; set; }
}
