using System;
using System.Collections.Generic;

namespace GameSaver.Entities;

public partial class Joueur
{
    public int Idjoueur { get; set; }

    public string Pseudo { get; set; } = null!;

    public string Motdepasse { get; set; } = null!;

    public string Nom { get; set; } = null!;

    public string Prenom { get; set; } = null!;

    public int Iddroit { get; set; }

    public byte[] Avatar { get; set; } = null!;

    public virtual Droit IddroitNavigation { get; set; } = null!;
}
