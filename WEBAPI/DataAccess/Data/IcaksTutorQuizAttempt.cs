using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksTutorQuizAttempt
{
    public long AttemptId { get; set; }

    public long? CourseId { get; set; }

    public long? QuizId { get; set; }

    public long? UserId { get; set; }

    public int? TotalQuestions { get; set; }

    public int? TotalAnsweredQuestions { get; set; }

    public decimal? TotalMarks { get; set; }

    public decimal? EarnedMarks { get; set; }

    public string? AttemptInfo { get; set; }

    public string? AttemptStatus { get; set; }

    public string? AttemptIp { get; set; }

    public DateTime? AttemptStartedAt { get; set; }

    public DateTime? AttemptEndedAt { get; set; }

    public int? IsManuallyReviewed { get; set; }

    public DateTime? ManuallyReviewedAt { get; set; }
}
