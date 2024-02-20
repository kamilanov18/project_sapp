using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksAmeliaCustomerBookingsToEventsPeriod
{
    public int Id { get; set; }

    public long CustomerBookingId { get; set; }

    public long EventPeriodId { get; set; }
}
