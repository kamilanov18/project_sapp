using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksTutorWithdraw
{
    public long WithdrawId { get; set; }

    public long? UserId { get; set; }

    public decimal? Amount { get; set; }

    public string? MethodData { get; set; }

    public string? Status { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? CreatedAt { get; set; }
}
