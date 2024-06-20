using System;
using System.Collections.Generic;

namespace E_project.Models;

public partial class Createloan
{
    public int Id { get; set; }

    public string Loanname { get; set; } = null!;

    public int Totalamount { get; set; }

    public string Totalduration { get; set; } = null!;
}
