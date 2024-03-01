using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksWfocuSession
{
    public ulong Id { get; set; }

    public long OrderId { get; set; }

    public string Email { get; set; } = null!;

    public string Total { get; set; } = null!;

    public string Gateway { get; set; } = null!;

    public ulong Cid { get; set; }

    public ulong Fid { get; set; }

    public DateTime Timestamp { get; set; }
}
