using System;
using System.Collections.Generic;

namespace E_project.Models;

public partial class Scheme
{
    public int SchemeId { get; set; }

    public string SchemeName { get; set; } = null!;

    public string SchemeDetails { get; set; } = null!;

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public int Status { get; set; }

    public int? UserId { get; set; }

    public virtual User? User { get; set; }
}
