using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksWfcoConnectormetum
{
    public ulong Id { get; set; }

    public ulong ConnectorId { get; set; }

    public string? MetaKey { get; set; }

    public string? MetaValue { get; set; }
}
