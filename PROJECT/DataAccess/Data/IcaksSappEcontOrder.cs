using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksSappEcontOrder
{
    public int Id { get; set; }

    public int OrderId { get; set; }

    public int ClientId { get; set; }

    public int AddressId { get; set; }

    public string? ShipmentNumber { get; set; }
}
