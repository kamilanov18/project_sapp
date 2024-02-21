using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksSappActionHistory
{
    public int Id { get; set; }

    public int OrderId { get; set; }

    public int UserId { get; set; }

    public int ActionId { get; set; }

    public DateTime Date { get; set; }
}
