using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksWcOrderAddress
{
    public ulong Id { get; set; }

    public ulong OrderId { get; set; }

    public string? AddressType { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Company { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Postcode { get; set; }

    public string? Country { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }
}
