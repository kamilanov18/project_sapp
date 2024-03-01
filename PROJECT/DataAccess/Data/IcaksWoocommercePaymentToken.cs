using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksWoocommercePaymentToken
{
    public ulong TokenId { get; set; }

    public string GatewayId { get; set; } = null!;

    public string Token { get; set; } = null!;

    public ulong UserId { get; set; }

    public string Type { get; set; } = null!;

    public bool IsDefault { get; set; }
}
