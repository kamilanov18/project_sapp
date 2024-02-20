using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksEEvent
{
    public ulong Id { get; set; }

    public string? EventData { get; set; }

    public DateTime CreatedAt { get; set; }
}
