using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksWcProductDownloadDirectory
{
    public ulong UrlId { get; set; }

    public string Url { get; set; } = null!;

    public bool Enabled { get; set; }
}
