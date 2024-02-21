using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksSappOrder
{
    public int Id { get; set; }

    public int StatusId { get; set; }

    public int ForeignOrderTableId { get; set; }

    public ulong ForeignOrderId { get; set; }

    public bool IsPossibleDuplicate { get; set; }
}
