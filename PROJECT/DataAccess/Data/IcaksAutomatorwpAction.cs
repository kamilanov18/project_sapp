using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksAutomatorwpAction
{
    public long Id { get; set; }

    public long AutomationId { get; set; }

    public string Title { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string Status { get; set; } = null!;

    public int Position { get; set; }

    public DateTime Date { get; set; }
}
