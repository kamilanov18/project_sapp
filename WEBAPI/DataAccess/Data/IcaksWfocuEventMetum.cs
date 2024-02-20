using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksWfocuEventMetum
{
    public ulong MetaId { get; set; }

    public ulong EventId { get; set; }

    public string? MetaKey { get; set; }

    public string? MetaValue { get; set; }
}
