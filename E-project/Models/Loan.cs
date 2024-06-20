using System;
using System.Collections.Generic;

namespace E_project.Models;

public partial class Loan
{
    public int LoanId { get; set; }

    public int? PolicyId { get; set; }

    public int? PolicyHolder { get; set; }

    public decimal? LoanAmount { get; set; }

    public DateOnly LoanStartDate { get; set; }

    public DateOnly LoanEndDate { get; set; }

    public decimal? InterestRate { get; set; }

    public virtual Policy? Policy { get; set; }

    public virtual PolicyHolder? PolicyHolderNavigation { get; set; }
}
