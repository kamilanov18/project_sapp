using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksWoocommerceShippingZone
{
    public ulong ZoneId { get; set; }

    public string ZoneName { get; set; } = null!;

    public ulong ZoneOrder { get; set; }
}
