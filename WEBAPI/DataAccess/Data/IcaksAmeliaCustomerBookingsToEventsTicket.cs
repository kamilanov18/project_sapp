using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksAmeliaCustomerBookingsToEventsTicket
{
    public int Id { get; set; }

    public long CustomerBookingId { get; set; }

    public long EventTicketId { get; set; }

    public double? Price { get; set; }

    public int Persons { get; set; }
}
