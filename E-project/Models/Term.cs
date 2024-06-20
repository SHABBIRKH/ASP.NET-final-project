using System;
using System.Collections.Generic;

namespace E_project.Models;

public partial class Term
{
    public int TermId { get; set; }

    public string? TermName { get; set; }

    public string Description { get; set; } = null!;

    public virtual ICollection<Plan> Plans { get; set; } = new List<Plan>();
}
