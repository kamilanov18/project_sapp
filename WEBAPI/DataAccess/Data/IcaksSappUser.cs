using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksSappUser
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public int RoleId { get; set; }

    public decimal? Wage { get; set; }
}
