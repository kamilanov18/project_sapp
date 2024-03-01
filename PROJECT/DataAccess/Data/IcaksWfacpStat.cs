using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksWfacpStat
{
    public ulong Id { get; set; }

    public ulong OrderId { get; set; }

    public ulong WfacpId { get; set; }

    public string TotalRevenue { get; set; } = null!;

    public ulong Cid { get; set; }

    public ulong Fid { get; set; }

    public DateTime Date { get; set; }
}
