using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksAmeliaCustomerBookingsToExtra
{
    public int Id { get; set; }

    public int CustomerBookingId { get; set; }

    public int ExtraId { get; set; }

    public int Quantity { get; set; }

    public double Price { get; set; }

    public bool? AggregatedPrice { get; set; }
}
