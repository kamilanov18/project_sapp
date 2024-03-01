using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksUsermetum
{
    public ulong UmetaId { get; set; }

    public ulong UserId { get; set; }

    public string? MetaKey { get; set; }

    public string? MetaValue { get; set; }
}
