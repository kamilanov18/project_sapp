using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksAmeliaLocationsView
{
    public int Id { get; set; }

    public int LocationId { get; set; }

    public DateTime Date { get; set; }

    public int Views { get; set; }
}
