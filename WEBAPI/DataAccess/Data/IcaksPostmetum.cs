﻿using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksPostmetum
{
    public ulong MetaId { get; set; }

    public ulong PostId { get; set; }

    public string? MetaKey { get; set; }

    public string? MetaValue { get; set; }
}
