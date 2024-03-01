using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksWcReservedStock
{
    public long OrderId { get; set; }

    public long ProductId { get; set; }

    public double StockQuantity { get; set; }

    public DateTime Timestamp { get; set; }

    public DateTime Expires { get; set; }
}
