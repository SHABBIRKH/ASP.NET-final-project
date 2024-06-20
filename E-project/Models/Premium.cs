using System;
using System.Collections.Generic;

namespace E_project.Models;

public partial class Premium
{
    public int PremiumId { get; set; }

    public int? PolicyId { get; set; }

    public int? PolicyHolder { get; set; }

    public decimal PremiumAmount { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public virtual Policy? Policy { get; set; }

    public virtual PolicyHolder? PolicyHolderNavigation { get; set; }
}
