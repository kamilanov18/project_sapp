using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksAmeliaCache
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int? PaymentId { get; set; }

    public string? Data { get; set; }
}
