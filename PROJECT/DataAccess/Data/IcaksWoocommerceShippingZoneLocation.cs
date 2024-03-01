using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksWoocommerceShippingZoneLocation
{
    public ulong LocationId { get; set; }

    public ulong ZoneId { get; set; }

    public string LocationCode { get; set; } = null!;

    public string LocationType { get; set; } = null!;
}
