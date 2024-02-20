using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksTutorQuizAttemptAnswer
{
    public long AttemptAnswerId { get; set; }

    public long? UserId { get; set; }

    public long? QuizId { get; set; }

    public long? QuestionId { get; set; }

    public long? QuizAttemptId { get; set; }

    public string? GivenAnswer { get; set; }

    public decimal? QuestionMark { get; set; }

    public decimal? AchievedMark { get; set; }

    public decimal? MinusMark { get; set; }

    public sbyte? IsCorrect { get; set; }
}
