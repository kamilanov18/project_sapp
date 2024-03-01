using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksAmeliaResourcesToEntity
{
    public int Id { get; set; }

    public int ResourceId { get; set; }

    public int EntityId { get; set; }

    public string EntityType { get; set; } = null!;
}
