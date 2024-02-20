using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksCartbounty
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Surname { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? Location { get; set; }

    public string? CartContents { get; set; }

    public decimal? CartTotal { get; set; }

    public string? Currency { get; set; }

    public DateTime? Time { get; set; }

    public string? SessionId { get; set; }

    public string? OtherFields { get; set; }

    public sbyte MailSent { get; set; }

    public sbyte? WpUnsubscribed { get; set; }

    public int? WpStepsCompleted { get; set; }

    public sbyte? WpComplete { get; set; }

    public string? Type { get; set; }

    public string? SavedVia { get; set; }
}
