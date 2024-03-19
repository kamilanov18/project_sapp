using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksSappEcontPhone
{
    public int Id { get; set; }

    public string Phone { get; set; } = null!;

    public int ClientId { get; set; }
}
