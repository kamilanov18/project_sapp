using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksAmeliaCouponsToPackage
{
    public int Id { get; set; }

    public int CouponId { get; set; }

    public int PackageId { get; set; }
}
