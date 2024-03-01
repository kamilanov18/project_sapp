using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksWcOrder
{
    public ulong Id { get; set; }

    public string? Status { get; set; }

    public string? Currency { get; set; }

    public string? Type { get; set; }

    public decimal? TaxAmount { get; set; }

    public decimal? TotalAmount { get; set; }

    public ulong? CustomerId { get; set; }

    public string? BillingEmail { get; set; }

    public DateTime? DateCreatedGmt { get; set; }

    public DateTime? DateUpdatedGmt { get; set; }

    public ulong? ParentOrderId { get; set; }

    public string? PaymentMethod { get; set; }

    public string? PaymentMethodTitle { get; set; }

    public string? TransactionId { get; set; }

    public string? IpAddress { get; set; }

    public string? UserAgent { get; set; }

    public string? CustomerNote { get; set; }
}
