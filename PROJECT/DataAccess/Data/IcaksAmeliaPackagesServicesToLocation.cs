using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksAmeliaPackagesServicesToLocation
{
    public int Id { get; set; }

    public int PackageServiceId { get; set; }

    public int LocationId { get; set; }
}
