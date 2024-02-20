using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksWoocommerceDownloadableProductPermission
{
    public ulong PermissionId { get; set; }

    public string DownloadId { get; set; } = null!;

    public ulong ProductId { get; set; }

    public ulong OrderId { get; set; }

    public string OrderKey { get; set; } = null!;

    public string UserEmail { get; set; } = null!;

    public ulong? UserId { get; set; }

    public string? DownloadsRemaining { get; set; }

    public DateTime AccessGranted { get; set; }

    public DateTime? AccessExpires { get; set; }

    public ulong DownloadCount { get; set; }
}
