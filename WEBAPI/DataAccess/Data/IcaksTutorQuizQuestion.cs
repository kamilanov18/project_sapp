using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksTutorQuizQuestion
{
    public long QuestionId { get; set; }

    public long? QuizId { get; set; }

    public string? QuestionTitle { get; set; }

    public string? QuestionDescription { get; set; }

    public string? AnswerExplanation { get; set; }

    public string? QuestionType { get; set; }

    public decimal? QuestionMark { get; set; }

    public string? QuestionSettings { get; set; }

    public int? QuestionOrder { get; set; }
}
