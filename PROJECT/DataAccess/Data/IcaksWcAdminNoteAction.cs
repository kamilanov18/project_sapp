using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksWcAdminNoteAction
{
    public ulong ActionId { get; set; }

    public ulong NoteId { get; set; }

    public string Name { get; set; } = null!;

    public string Label { get; set; } = null!;

    public string Query { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string ActionedText { get; set; } = null!;

    public string? NonceAction { get; set; }

    public string? NonceName { get; set; }
}
