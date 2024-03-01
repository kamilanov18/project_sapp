using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksAmeliaNotificationsSmsHistory
{
    public int Id { get; set; }

    public int NotificationId { get; set; }

    public int? UserId { get; set; }

    public int? AppointmentId { get; set; }

    public int? EventId { get; set; }

    public int? PackageCustomerId { get; set; }

    public int? LogId { get; set; }

    public DateTime? DateTime { get; set; }

    public string Text { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string AlphaSenderId { get; set; } = null!;

    public string Status { get; set; } = null!;

    public double? Price { get; set; }

    public sbyte? Segments { get; set; }
}
