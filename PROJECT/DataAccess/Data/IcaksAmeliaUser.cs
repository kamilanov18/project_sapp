using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksAmeliaUser
{
    public int Id { get; set; }

    public string Status { get; set; } = null!;

    public string Type { get; set; } = null!;

    public long? ExternalId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? Email { get; set; }

    public DateTime? Birthday { get; set; }

    public string? Phone { get; set; }

    public string? Gender { get; set; }

    public string? Note { get; set; }

    public string? Description { get; set; }

    public string? PictureFullPath { get; set; }

    public string? PictureThumbPath { get; set; }

    public string? Password { get; set; }

    public string? UsedTokens { get; set; }

    public string? ZoomUserId { get; set; }

    public string? CountryPhoneIso { get; set; }

    public string? Translations { get; set; }

    public string? TimeZone { get; set; }

    public int? BadgeId { get; set; }
}
