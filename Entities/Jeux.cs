using System;
using System.Collections.Generic;

namespace GameSaver.Entities;

public partial class Jeux
{
    public int Idjeux { get; set; }

    public string Lbljeux { get; set; } = null!;

    public string Descriptions { get; set; } = null!;

    public int Nbjoumin { get; set; }

    public int Nbjoumax { get; set; }

    public string Scoretype { get; set; } = null!;
}
