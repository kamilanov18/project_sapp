using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksSappProduct
{
    public int Id { get; set; }

    public long ProductId { get; set; }

    public decimal? Weight { get; set; }
}
