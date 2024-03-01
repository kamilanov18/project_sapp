using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksWoocommerceSession
{
    public ulong SessionId { get; set; }

    public string SessionKey { get; set; } = null!;

    public string SessionValue { get; set; } = null!;

    public ulong SessionExpiry { get; set; }
}
