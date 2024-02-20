using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksWoocommerceShippingZoneMethod
{
    public ulong ZoneId { get; set; }

    public ulong InstanceId { get; set; }

    public string MethodId { get; set; } = null!;

    public ulong MethodOrder { get; set; }

    public bool? IsEnabled { get; set; }
}
