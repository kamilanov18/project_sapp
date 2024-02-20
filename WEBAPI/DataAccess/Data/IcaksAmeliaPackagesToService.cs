using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksAmeliaPackagesToService
{
    public int Id { get; set; }

    public int ServiceId { get; set; }

    public int PackageId { get; set; }

    public int Quantity { get; set; }

    public int? MinimumScheduled { get; set; }

    public int? MaximumScheduled { get; set; }

    public bool? AllowProviderSelection { get; set; }
}
