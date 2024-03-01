using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksAmeliaProvidersToSpecialday
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }
}
