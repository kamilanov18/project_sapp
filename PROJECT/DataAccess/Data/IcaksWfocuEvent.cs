using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksWfocuEvent
{
    public ulong Id { get; set; }

    public long SessId { get; set; }

    public string ObjectType { get; set; } = null!;

    public string ObjectId { get; set; } = null!;

    public string ActionTypeId { get; set; } = null!;

    public string Value { get; set; } = null!;

    public DateTime Timestamp { get; set; }
}
