using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksAutomatorwpAutomation
{
    public long Id { get; set; }

    public string Title { get; set; } = null!;

    public string Type { get; set; } = null!;

    public long UserId { get; set; }

    public bool Sequential { get; set; }

    public int TimesPerUser { get; set; }

    public int Times { get; set; }

    public string Status { get; set; } = null!;

    public DateTime Date { get; set; }
}
