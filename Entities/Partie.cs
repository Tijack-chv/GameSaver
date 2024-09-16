using System;
using System.Collections.Generic;

namespace GameSaver.Entities;

public partial class Partie
{
    public int Idpartie { get; set; }

    public int Idjeux { get; set; }

    public DateOnly Datepartie { get; set; }
}
