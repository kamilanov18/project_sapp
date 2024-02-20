using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksAmeliaPayment
{
    public int Id { get; set; }

    public int? CustomerBookingId { get; set; }

    public double Amount { get; set; }

    public DateTime? DateTime { get; set; }

    public string Status { get; set; } = null!;

    public string Gateway { get; set; } = null!;

    public string? GatewayTitle { get; set; }

    public string? Data { get; set; }

    public int? PackageCustomerId { get; set; }

    public int? ParentId { get; set; }

    public string? Entity { get; set; }

    public DateTime? Created { get; set; }

    public bool? ActionsCompleted { get; set; }

    public long? WcOrderId { get; set; }

    public string? TransactionId { get; set; }

    public long? WcOrderItemId { get; set; }
}
