using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksAmeliaEvent
{
    public int Id { get; set; }

    public long? ParentId { get; set; }

    public string Name { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateTime? BookingOpens { get; set; }

    public DateTime? BookingCloses { get; set; }

    public string? BookingOpensRec { get; set; }

    public string? BookingClosesRec { get; set; }

    public string? TicketRangeRec { get; set; }

    public string? RecurringCycle { get; set; }

    public int? RecurringOrder { get; set; }

    public int? RecurringInterval { get; set; }

    public string? RecurringMonthly { get; set; }

    public DateTime? MonthlyDate { get; set; }

    public string? MonthlyOnRepeat { get; set; }

    public string? MonthlyOnDay { get; set; }

    public DateTime? RecurringUntil { get; set; }

    public int MaxCapacity { get; set; }

    public int? MaxCustomCapacity { get; set; }

    public int? MaxExtraPeople { get; set; }

    public double Price { get; set; }

    public long? LocationId { get; set; }

    public string? CustomLocation { get; set; }

    public string? Description { get; set; }

    public string? Color { get; set; }

    public bool? Show { get; set; }

    public bool NotifyParticipants { get; set; }

    public DateTime Created { get; set; }

    public string? Settings { get; set; }

    public string? ZoomUserId { get; set; }

    public bool? BringingAnyone { get; set; }

    public bool? BookMultipleTimes { get; set; }

    public string? Translations { get; set; }

    public string? DepositPayment { get; set; }

    public bool? DepositPerPerson { get; set; }

    public bool? FullPayment { get; set; }

    public double? Deposit { get; set; }

    public bool? CustomPricing { get; set; }

    public long? OrganizerId { get; set; }

    public int? CloseAfterMin { get; set; }

    public bool? CloseAfterMinBookings { get; set; }

    public bool? AggregatedPrice { get; set; }
}
