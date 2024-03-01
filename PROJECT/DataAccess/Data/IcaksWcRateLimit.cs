using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksWcRateLimit
{
    public ulong RateLimitId { get; set; }

    public string RateLimitKey { get; set; } = null!;

    public ulong RateLimitExpiry { get; set; }

    public short RateLimitRemaining { get; set; }
}
