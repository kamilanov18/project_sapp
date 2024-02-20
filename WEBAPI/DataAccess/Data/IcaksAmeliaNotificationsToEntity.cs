using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksAmeliaNotificationsToEntity
{
    public int Id { get; set; }

    public int NotificationId { get; set; }

    public int EntityId { get; set; }

    public string Entity { get; set; } = null!;
}
