using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksAmeliaCustomerBooking
{
    public int Id { get; set; }

    public int? AppointmentId { get; set; }

    public int CustomerId { get; set; }

    public string? Status { get; set; }

    public double Price { get; set; }

    public int Persons { get; set; }

    public int? CouponId { get; set; }

    public string? Token { get; set; }

    public string? CustomFields { get; set; }

    public string? Info { get; set; }

    public int? UtcOffset { get; set; }

    public bool? AggregatedPrice { get; set; }

    public int? PackageCustomerServiceId { get; set; }

    public int? Duration { get; set; }

    public DateTime? Created { get; set; }

    public bool? ActionsCompleted { get; set; }
}
