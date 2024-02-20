using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksTutorQuizQuestionAnswer
{
    public long AnswerId { get; set; }

    public long? BelongsQuestionId { get; set; }

    public string? BelongsQuestionType { get; set; }

    public string? AnswerTitle { get; set; }

    public sbyte? IsCorrect { get; set; }

    public long? ImageId { get; set; }

    public string? AnswerTwoGapMatch { get; set; }

    public string? AnswerViewFormat { get; set; }

    public string? AnswerSettings { get; set; }

    public int? AnswerOrder { get; set; }
}
