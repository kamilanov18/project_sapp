using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksAmeliaPackagesCustomersToService
{
    public int Id { get; set; }

    public int PackageCustomerId { get; set; }

    public int ServiceId { get; set; }

    public int? ProviderId { get; set; }

    public int? LocationId { get; set; }

    public int? BookingsCount { get; set; }
}
