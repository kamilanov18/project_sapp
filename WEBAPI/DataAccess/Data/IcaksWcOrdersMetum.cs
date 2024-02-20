using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksWcOrdersMetum
{
    public ulong Id { get; set; }

    public ulong? OrderId { get; set; }

    public string? MetaKey { get; set; }

    public string? MetaValue { get; set; }
}
