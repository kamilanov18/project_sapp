using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksAmeliaEventsTag
{
    public int Id { get; set; }

    public long EventId { get; set; }

    public string Name { get; set; } = null!;
}
