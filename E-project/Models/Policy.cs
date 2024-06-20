using System;
using System.Collections.Generic;

namespace E_project.Models;

public partial class Policy
{
    public int PolicyId { get; set; }

    public string PolicyName { get; set; } = null!;

    public string PolicyDetails { get; set; } = null!;

    public DateOnly EffectiveDate { get; set; }

    public DateOnly ExpirationDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string CreatedDate { get; set; } = null!;

    public int? PolicyAmount { get; set; }

    public virtual ICollection<Loan> Loans { get; set; } = new List<Loan>();
}
