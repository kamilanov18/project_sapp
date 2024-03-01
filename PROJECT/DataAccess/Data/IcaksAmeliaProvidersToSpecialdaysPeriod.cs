using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksAmeliaProvidersToSpecialdaysPeriod
{
    public int Id { get; set; }

    public int SpecialDayId { get; set; }

    public int? LocationId { get; set; }

    public TimeSpan StartTime { get; set; }

    public TimeSpan EndTime { get; set; }
}
