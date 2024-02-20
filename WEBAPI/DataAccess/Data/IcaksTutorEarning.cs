using System;
using System.Collections.Generic;

namespace DataAccess.Data;

public partial class IcaksTutorEarning
{
    public long EarningId { get; set; }

    public long? UserId { get; set; }

    public long? CourseId { get; set; }

    public long? OrderId { get; set; }

    public string? OrderStatus { get; set; }

    public decimal? CoursePriceTotal { get; set; }

    public decimal? CoursePriceGrandTotal { get; set; }

    public decimal? InstructorAmount { get; set; }

    public decimal? InstructorRate { get; set; }

    public decimal? AdminAmount { get; set; }

    public decimal? AdminRate { get; set; }

    public string? CommissionType { get; set; }

    public decimal? DeductFeesAmount { get; set; }

    public string? DeductFeesName { get; set; }

    public string? DeductFeesType { get; set; }

    public string? ProcessBy { get; set; }

    public DateTime? CreatedAt { get; set; }
}
