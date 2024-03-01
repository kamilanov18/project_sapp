using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksBwfAbExperiment
{
    public ulong Id { get; set; }

    public string Title { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string Desc { get; set; } = null!;

    public string Type { get; set; } = null!;

    public DateTime DateAdded { get; set; }

    public DateTime DateStarted { get; set; }

    public DateTime LastResetDate { get; set; }

    public DateTime DateCompleted { get; set; }

    public string? Goal { get; set; }

    public ulong Control { get; set; }

    public string? Variants { get; set; }

    public string? Activity { get; set; }
}
