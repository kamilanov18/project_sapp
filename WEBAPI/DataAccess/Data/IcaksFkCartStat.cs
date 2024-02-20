using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksFkCartStat
{
    public ulong Id { get; set; }

    /// <summary>
    /// Order ID
    /// </summary>
    public ulong Oid { get; set; }

    /// <summary>
    /// Product ID
    /// </summary>
    public ulong Pid { get; set; }

    /// <summary>
    /// Contact ID
    /// </summary>
    public ulong Cid { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime DateCreatedGmt { get; set; }

    public byte Status { get; set; }
}
