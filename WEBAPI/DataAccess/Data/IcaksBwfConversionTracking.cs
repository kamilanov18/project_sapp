using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksBwfConversionTracking
{
    public ulong Id { get; set; }

    public ulong ContactId { get; set; }

    public string? UtmSource { get; set; }

    public string? UtmMedium { get; set; }

    public string? UtmCampaign { get; set; }

    public string? UtmTerm { get; set; }

    public string? UtmContent { get; set; }

    public string? ClickId { get; set; }

    /// <summary>
    /// 1- optin 2- wc_order 3- edd_order
    /// </summary>
    public byte? Type { get; set; }

    public string? Value { get; set; }

    public ulong StepId { get; set; }

    public ulong FunnelId { get; set; }

    public ulong AutomationId { get; set; }

    public DateTime FirstClick { get; set; }

    public string? Referrer { get; set; }

    public ulong Source { get; set; }

    public string? Device { get; set; }

    public string? Browser { get; set; }

    public string? Country { get; set; }

    public DateTime Timestamp { get; set; }
}
