using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksAutomatorwpLog
{
    public long Id { get; set; }

    public string Title { get; set; } = null!;

    public string Type { get; set; } = null!;

    public long ObjectId { get; set; }

    public long UserId { get; set; }

    public long PostId { get; set; }

    public DateTime Date { get; set; }
}
