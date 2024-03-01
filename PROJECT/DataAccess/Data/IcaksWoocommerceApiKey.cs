using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksWoocommerceApiKey
{
    public ulong KeyId { get; set; }

    public ulong UserId { get; set; }

    public string? Description { get; set; }

    public string Permissions { get; set; } = null!;

    public string ConsumerKey { get; set; } = null!;

    public string ConsumerSecret { get; set; } = null!;

    public string? Nonces { get; set; }

    public string TruncatedKey { get; set; } = null!;

    public DateTime? LastAccess { get; set; }
}
