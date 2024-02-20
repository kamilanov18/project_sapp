using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksWcDownloadLog
{
    public ulong DownloadLogId { get; set; }

    public DateTime Timestamp { get; set; }

    public ulong PermissionId { get; set; }

    public ulong? UserId { get; set; }

    public string? UserIpAddress { get; set; }
}
