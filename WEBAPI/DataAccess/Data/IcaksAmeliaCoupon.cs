using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksAmeliaCoupon
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public double Discount { get; set; }

    public double Deduction { get; set; }

    public double Limit { get; set; }

    public double CustomerLimit { get; set; }

    public string Status { get; set; } = null!;

    public int NotificationInterval { get; set; }

    public bool NotificationRecurring { get; set; }

    public DateTime? ExpirationDate { get; set; }
}
