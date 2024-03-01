using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksAmeliaProvidersToWeekday
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public sbyte DayIndex { get; set; }

    public TimeSpan StartTime { get; set; }

    public TimeSpan EndTime { get; set; }
}
