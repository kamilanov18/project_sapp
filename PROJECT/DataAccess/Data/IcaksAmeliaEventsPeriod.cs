using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksAmeliaEventsPeriod
{
    public int Id { get; set; }

    public long EventId { get; set; }

    public DateTime PeriodStart { get; set; }

    public DateTime PeriodEnd { get; set; }

    public string? ZoomMeeting { get; set; }

    public string? LessonSpace { get; set; }

    public string? GoogleCalendarEventId { get; set; }

    public string? GoogleMeetUrl { get; set; }

    public string? OutlookCalendarEventId { get; set; }
}
