using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksAmeliaCouponsToEvent
{
    public int Id { get; set; }

    public int CouponId { get; set; }

    public int EventId { get; set; }
}
