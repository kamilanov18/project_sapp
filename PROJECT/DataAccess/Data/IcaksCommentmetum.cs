using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksCommentmetum
{
    public ulong MetaId { get; set; }

    public ulong CommentId { get; set; }

    public string? MetaKey { get; set; }

    public string? MetaValue { get; set; }
}
