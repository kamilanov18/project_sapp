﻿using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksOption
{
    public ulong OptionId { get; set; }

    public string OptionName { get; set; } = null!;

    public string OptionValue { get; set; } = null!;

    public string Autoload { get; set; } = null!;
}
