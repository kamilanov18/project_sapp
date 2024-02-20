using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksAmeliaCategory
{
    public int Id { get; set; }

    public string Status { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int Position { get; set; }

    public string? Translations { get; set; }

    public string Color { get; set; } = null!;

    public string? PictureFullPath { get; set; }

    public string? PictureThumbPath { get; set; }
}
