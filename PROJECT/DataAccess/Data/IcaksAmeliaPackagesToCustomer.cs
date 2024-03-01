using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksAmeliaPackagesToCustomer
{
    public int Id { get; set; }

    public int PackageId { get; set; }

    public int CustomerId { get; set; }

    public double Price { get; set; }

    public DateTime? Start { get; set; }

    public DateTime? End { get; set; }

    public DateTime Purchased { get; set; }

    public string? Status { get; set; }

    public int? BookingsCount { get; set; }

    public int? CouponId { get; set; }
}
