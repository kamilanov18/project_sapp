using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksAmeliaAppointment
{
    public int Id { get; set; }

    public string? Status { get; set; }

    public DateTime BookingStart { get; set; }

    public DateTime BookingEnd { get; set; }

    public bool NotifyParticipants { get; set; }

    public int ServiceId { get; set; }

    public int? PackageId { get; set; }

    public int ProviderId { get; set; }

    public int? LocationId { get; set; }

    public string? InternalNotes { get; set; }

    public string? GoogleCalendarEventId { get; set; }

    public string? GoogleMeetUrl { get; set; }

    public string? OutlookCalendarEventId { get; set; }

    public string? ZoomMeeting { get; set; }

    public string? LessonSpace { get; set; }

    public int? ParentId { get; set; }
}
