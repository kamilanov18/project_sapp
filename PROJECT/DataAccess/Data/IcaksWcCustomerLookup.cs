using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksWcCustomerLookup
{
    public ulong CustomerId { get; set; }

    public ulong? UserId { get; set; }

    public string Username { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? Email { get; set; }

    public DateTime? DateLastActive { get; set; }

    public DateTime? DateRegistered { get; set; }

    public string Country { get; set; } = null!;

    public string Postcode { get; set; } = null!;

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;
}
