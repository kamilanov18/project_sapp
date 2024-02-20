using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksAmeliaNotificationsLog
{
    public int Id { get; set; }

    public int NotificationId { get; set; }

    public int? UserId { get; set; }

    public int? AppointmentId { get; set; }

    public int? EventId { get; set; }

    public int? PackageCustomerId { get; set; }

    public DateTime SentDateTime { get; set; }

    public bool? Sent { get; set; }

    public string? Data { get; set; }
}
