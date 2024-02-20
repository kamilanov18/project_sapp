using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksAmeliaService
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string Color { get; set; } = null!;

    public double Price { get; set; }

    public string Status { get; set; } = null!;

    public int CategoryId { get; set; }

    public int MinCapacity { get; set; }

    public int MaxCapacity { get; set; }

    public int Duration { get; set; }

    public int? TimeBefore { get; set; }

    public int? TimeAfter { get; set; }

    public bool? BringingAnyone { get; set; }

    public string Priority { get; set; } = null!;

    public string? PictureFullPath { get; set; }

    public string? PictureThumbPath { get; set; }

    public int? Position { get; set; }

    public bool? Show { get; set; }

    public bool? AggregatedPrice { get; set; }

    public string? Settings { get; set; }

    public string? RecurringCycle { get; set; }

    public string? RecurringSub { get; set; }

    public int? RecurringPayment { get; set; }

    public string? Translations { get; set; }

    public string? DepositPayment { get; set; }

    public bool? DepositPerPerson { get; set; }

    public double? Deposit { get; set; }

    public bool? FullPayment { get; set; }

    public bool? MandatoryExtra { get; set; }

    public int? MinSelectedExtras { get; set; }

    public string? CustomPricing { get; set; }

    public int? MaxExtraPeople { get; set; }

    public string? LimitPerCustomer { get; set; }
}
