using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksWfobStat
{
    public ulong Id { get; set; }

    public ulong Oid { get; set; }

    public ulong Bid { get; set; }

    public string Iid { get; set; } = null!;

    public bool Converted { get; set; }

    public string Total { get; set; } = null!;

    public DateTime Date { get; set; }

    public ulong Cid { get; set; }

    public ulong Fid { get; set; }
}
