using System;
using System.Collections.Generic;

namespace GameSaver.Entities;

public partial class Lignepartie
{
    public int Idpartjou { get; set; }

    public int Idtour { get; set; }

    public int Score { get; set; }

    public string? Detail { get; set; }

    public int? Bonus { get; set; }
}
