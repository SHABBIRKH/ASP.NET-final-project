using System;
using System.Collections.Generic;

namespace E_project.Models;

public partial class Payment
{
    public int PaymentId { get; set; }

    public int? PolicyId { get; set; }

    public int? PolicyHolder { get; set; }

    public DateOnly PaymentDate { get; set; }

    public decimal? PaymentAmount { get; set; }

    public virtual Policy? Policy { get; set; }

    public virtual PolicyHolder? PolicyHolderNavigation { get; set; }
}
