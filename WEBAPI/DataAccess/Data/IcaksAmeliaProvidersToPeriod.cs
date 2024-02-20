using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksAmeliaProvidersToPeriod
{
    public int Id { get; set; }

    public int WeekDayId { get; set; }

    public int? LocationId { get; set; }

    public TimeSpan StartTime { get; set; }

    public TimeSpan EndTime { get; set; }
}
