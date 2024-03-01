using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksAmeliaProvidersToDaysoff
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string Name { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public bool Repeat { get; set; }
}
