using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace GameSaver.Entities;

public partial class GestionjeuContext : DbContext
{
    public GestionjeuContext()
    {
    }

    public GestionjeuContext(DbContextOptions<GestionjeuContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Droit> Droits { get; set; }

    public virtual DbSet<Jeux> Jeuxes { get; set; }

    public virtual DbSet<Joueur> Joueurs { get; set; }

    public virtual DbSet<Lignepartie> Ligneparties { get; set; }

    public virtual DbSet<Participe> Participes { get; set; }

    public virtual DbSet<Partie> Parties { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;user=userJeu;password=azertyuiookjhgfdsdfghjkl;database=gestionjeu", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.3.0-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Droit>(entity =>
        {
            entity.HasKey(e => e.Iddroit).HasName("PRIMARY");

            entity.ToTable("droit");

            entity.Property(e => e.Iddroit).HasColumnName("IDDROIT");
            entity.Property(e => e.Lbldroit)
                .HasMaxLength(15)
                .HasColumnName("LBLDROIT");
        });

        modelBuilder.Entity<Jeux>(entity =>
        {
            entity.HasKey(e => e.Idjeux).HasName("PRIMARY");

            entity.ToTable("jeux");

            entity.HasIndex(e => e.Lbljeux, "LBLJEUX").IsUnique();

            entity.Property(e => e.Idjeux).HasColumnName("IDJEUX");
            entity.Property(e => e.Descriptions)
                .HasMaxLength(500)
                .HasColumnName("DESCRIPTIONS");
            entity.Property(e => e.Lbljeux)
                .HasMaxLength(50)
                .HasColumnName("LBLJEUX");
            entity.Property(e => e.Nbjoumax).HasColumnName("NBJOUMAX");
            entity.Property(e => e.Nbjoumin).HasColumnName("NBJOUMIN");
            entity.Property(e => e.Scoretype)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("SCORETYPE");
        });

        modelBuilder.Entity<Joueur>(entity =>
        {
            entity.HasKey(e => e.Idjoueur).HasName("PRIMARY");

            entity.ToTable("joueur");

            entity.HasIndex(e => e.Iddroit, "IDDROIT");

            entity.HasIndex(e => new { e.Nom, e.Prenom }, "IDENTITE").IsUnique();

            entity.HasIndex(e => e.Pseudo, "PSEUDO").IsUnique();

            entity.Property(e => e.Idjoueur).HasColumnName("IDJOUEUR");
            entity.Property(e => e.Avatar)
                .HasColumnType("mediumblob")
                .HasColumnName("AVATAR");
            entity.Property(e => e.Iddroit).HasColumnName("IDDROIT");
            entity.Property(e => e.Motdepasse)
                .HasMaxLength(30)
                .HasColumnName("MOTDEPASSE");
            entity.Property(e => e.Nom)
                .HasMaxLength(50)
                .HasColumnName("NOM");
            entity.Property(e => e.Prenom)
                .HasMaxLength(50)
                .HasColumnName("PRENOM");
            entity.Property(e => e.Pseudo)
                .HasMaxLength(40)
                .HasColumnName("PSEUDO");

            entity.HasOne(d => d.IddroitNavigation).WithMany(p => p.Joueurs)
                .HasForeignKey(d => d.Iddroit)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("joueur_ibfk_1");
        });

        modelBuilder.Entity<Lignepartie>(entity =>
        {
            entity.HasKey(e => new { e.Idpartjou, e.Idtour })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("lignepartie");

            entity.HasIndex(e => e.Idpartjou, "IDPARTJOU");

            entity.Property(e => e.Idpartjou).HasColumnName("IDPARTJOU");
            entity.Property(e => e.Idtour).HasColumnName("IDTOUR");
            entity.Property(e => e.Bonus).HasColumnName("BONUS");
            entity.Property(e => e.Detail)
                .HasMaxLength(100)
                .HasColumnName("DETAIL");
            entity.Property(e => e.Score).HasColumnName("SCORE");
        });

        modelBuilder.Entity<Participe>(entity =>
        {
            entity.HasKey(e => e.Idpartjou).HasName("PRIMARY");

            entity.ToTable("participe");

            entity.HasIndex(e => e.Idjoueur, "IDJOUEUR");

            entity.HasIndex(e => e.Idpartie, "IDPARTIE");

            entity.Property(e => e.Idpartjou).HasColumnName("IDPARTJOU");
            entity.Property(e => e.Classement).HasColumnName("CLASSEMENT");
            entity.Property(e => e.Idjoueur).HasColumnName("IDJOUEUR");
            entity.Property(e => e.Idpartie).HasColumnName("IDPARTIE");
        });

        modelBuilder.Entity<Partie>(entity =>
        {
            entity.HasKey(e => e.Idpartie).HasName("PRIMARY");

            entity.ToTable("partie");

            entity.HasIndex(e => e.Idjeux, "IDJEUX");

            entity.Property(e => e.Idpartie).HasColumnName("IDPARTIE");
            entity.Property(e => e.Datepartie).HasColumnName("DATEPARTIE");
            entity.Property(e => e.Idjeux).HasColumnName("IDJEUX");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
