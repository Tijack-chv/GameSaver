using System;
using System.Collections.Generic;

namespace GameSaver.Entities;

public partial class Droit
{
    public int Iddroit { get; set; }

    public string Lbldroit { get; set; } = null!;

    public virtual ICollection<Joueur> Joueurs { get; set; } = new List<Joueur>();
}
