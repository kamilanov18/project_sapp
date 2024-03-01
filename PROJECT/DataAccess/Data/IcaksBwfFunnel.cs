using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksBwfFunnel
{
    public ulong Id { get; set; }

    public string Title { get; set; } = null!;

    public string Desc { get; set; } = null!;

    public DateTime DateAdded { get; set; }

    public string? Steps { get; set; }
}
