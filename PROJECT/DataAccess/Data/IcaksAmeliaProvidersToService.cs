using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksAmeliaProvidersToService
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int ServiceId { get; set; }

    public double Price { get; set; }

    public int MinCapacity { get; set; }

    public int MaxCapacity { get; set; }

    public string? CustomPricing { get; set; }
}
