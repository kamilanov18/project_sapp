using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksAmeliaCustomFieldsOption
{
    public int Id { get; set; }

    public int CustomFieldId { get; set; }

    public string Label { get; set; } = null!;

    public int Position { get; set; }

    public string? Translations { get; set; }
}
