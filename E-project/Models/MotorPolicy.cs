using System;
using System.Collections.Generic;

namespace E_project.Models;

public partial class MotorPolicy
{
    public int Id { get; set; }

    public string Details { get; set; } = null!;

    public DateOnly EffectiveDate { get; set; }

    public DateOnly ExpirationDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateOnly CreationDate { get; set; }

    public int Premium { get; set; }
}
