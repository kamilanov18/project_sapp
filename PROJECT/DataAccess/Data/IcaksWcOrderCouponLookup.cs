using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksWcOrderCouponLookup
{
    public ulong OrderId { get; set; }

    public long CouponId { get; set; }

    public DateTime DateCreated { get; set; }

    public double DiscountAmount { get; set; }
}
