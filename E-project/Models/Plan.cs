using System;
using System.Collections.Generic;

namespace E_project.Models;

public partial class Plan
{
    public int PlanId { get; set; }

    public string PlanName { get; set; } = null!;

    public int? TermId { get; set; }

    public decimal? CoverageAmount { get; set; }

    public decimal? PremiumAmount { get; set; }

    public virtual Term? Term { get; set; }
}
