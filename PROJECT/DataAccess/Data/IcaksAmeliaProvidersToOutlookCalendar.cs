using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksAmeliaProvidersToOutlookCalendar
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string Token { get; set; } = null!;

    public string? CalendarId { get; set; }
}
