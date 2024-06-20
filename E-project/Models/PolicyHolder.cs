using System;
using System.Collections.Generic;

namespace E_project.Models;

public partial class PolicyHolder
{
    public int PolicyholderId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public DateOnly DateOfBirth { get; set; }

    public string Gender { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string EmailAddress { get; set; } = null!;

    public int PhoneNumber { get; set; }

    public virtual ICollection<Loan> Loans { get; set; } = new List<Loan>();
}
