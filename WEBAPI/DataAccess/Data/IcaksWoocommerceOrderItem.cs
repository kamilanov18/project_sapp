using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksWoocommerceOrderItem
{
    public ulong OrderItemId { get; set; }

    public string OrderItemName { get; set; } = null!;

    public string OrderItemType { get; set; } = null!;

    public ulong OrderId { get; set; }
}
