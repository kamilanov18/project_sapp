using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksWfcoReportView
{
    public ulong Id { get; set; }

    public DateTime Date { get; set; }

    public int NoOfSessions { get; set; }

    public long? ObjectId { get; set; }

    /// <summary>
    /// 1 - Abandonment 2 - Landing visited 3 - Landing converted 4 - Aero visited 5- Thank you visited 6 - NextMove 7 - Funnel session 8-Optin visited 9-Optin converted 10- Optin thank you visited 11- Optin thank you converted
    /// </summary>
    public sbyte Type { get; set; }
}
