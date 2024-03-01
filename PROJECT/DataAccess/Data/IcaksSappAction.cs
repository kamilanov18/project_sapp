using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksSappAction
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public decimal Expense { get; set; }
}
