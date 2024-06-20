using System;
using System.Collections.Generic;

namespace E_project.Models;

public partial class Policyholdersss
{
    public int Id { get; set; }

    public string Firstname { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public DateOnly Dateofbirth { get; set; }

    public string Gender { get; set; } = null!;

    public int Cardno { get; set; }

    public int Cardexp { get; set; }

    public string Address { get; set; } = null!;

    public int Phoneno { get; set; }
}
