using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksBwfOptinEntry
{
    public ulong Id { get; set; }

    public ulong StepId { get; set; }

    public ulong FunnelId { get; set; }

    public ulong Cid { get; set; }

    public string Opid { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Data { get; set; }

    public DateTime Date { get; set; }
}
