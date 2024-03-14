using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksSappOrdersEcont
{
    public int Id { get; set; }

    public int OrderId { get; set; }

    public string? ShipmentNumber { get; set; }
}
