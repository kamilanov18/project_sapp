using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksBwfContactMetum
{
    public ulong MetaId { get; set; }

    public ulong ContactId { get; set; }

    public string? MetaKey { get; set; }

    public string? MetaValue { get; set; }
}
