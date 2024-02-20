using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksAmeliaGallery
{
    public int Id { get; set; }

    public int EntityId { get; set; }

    public string EntityType { get; set; } = null!;

    public string? PictureFullPath { get; set; }

    public string? PictureThumbPath { get; set; }

    public int Position { get; set; }
}
