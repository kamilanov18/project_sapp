using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksAmeliaPackage
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string Color { get; set; } = null!;

    public double Price { get; set; }

    public string Status { get; set; } = null!;

    public string? PictureFullPath { get; set; }

    public string? PictureThumbPath { get; set; }

    public int? Position { get; set; }

    public bool? CalculatedPrice { get; set; }

    public double Discount { get; set; }

    public DateTime? EndDate { get; set; }

    public string? DurationType { get; set; }

    public int? DurationCount { get; set; }

    public string? Settings { get; set; }

    public string? Translations { get; set; }

    public string? DepositPayment { get; set; }

    public double? Deposit { get; set; }

    public bool? FullPayment { get; set; }

    public bool? SharedCapacity { get; set; }

    public int? Quantity { get; set; }

    public string? LimitPerCustomer { get; set; }
}
