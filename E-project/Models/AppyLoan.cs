using System;
using System.Collections.Generic;

namespace E_project.Models;

public partial class AppyLoan
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string LastName { get; set; } = null!;

    public int? Age { get; set; }

    public int? Cnicno { get; set; }

    public string? IssueDate { get; set; }

    public string? Expiredat { get; set; }

    public string? PermentAddress { get; set; }

    public string? Dob { get; set; }

    public string? Email { get; set; }

    public int? ContactNo { get; set; }

    public string? Gender { get; set; }

    public string? Occupation { get; set; }

    public string? WhyYouWantLoan { get; set; }

    public string? AmountIntrest { get; set; }

    public string? Duration { get; set; }

    public string? Photo { get; set; }

    public string? CnicPhoto { get; set; }

    public string? ApprovelStatus { get; set; }
}
