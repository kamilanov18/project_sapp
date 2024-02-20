using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksBwfContact
{
    public uint Id { get; set; }

    public int Wpid { get; set; }

    public string Uid { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? FName { get; set; }

    public string? LName { get; set; }

    public string? ContactNo { get; set; }

    public string? Country { get; set; }

    public string? State { get; set; }

    public string? Timezone { get; set; }

    public string? Type { get; set; }

    public string? Source { get; set; }

    public ulong Points { get; set; }

    public string? Tags { get; set; }

    public string? Lists { get; set; }

    public DateTime LastModified { get; set; }

    public DateTime CreationDate { get; set; }

    public int Status { get; set; }
}
