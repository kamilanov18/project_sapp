using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksAmeliaServicesView
{
    public int Id { get; set; }

    public int ServiceId { get; set; }

    public DateTime Date { get; set; }

    public int Views { get; set; }
}
