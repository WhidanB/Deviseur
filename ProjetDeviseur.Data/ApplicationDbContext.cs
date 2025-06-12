using Projet_Deviseur.Models;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Projet_Deviseur.ProjetDeviseur.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Marque> Marques { get; set; }
        public DbSet<Moteur> Moteurs { get; set; }
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Coloris> Coloris { get; set; }
        public DbSet<Finition> Finitions { get; set; }
        public DbSet<OptionAuto> OptionsAuto { get; set; }
        public DbSet<Modele> Modeles { get; set; }
        public DbSet<Configuration> Configurations { get; set; }
        public DbSet<Devis> Devis { get; set; }

        // Tables de liaison n-n
        public DbSet<ModeleMoteur> ModeleMoteurs { get; set; }
        public DbSet<ModeleCategorie> ModeleCategories { get; set; }
        public DbSet<ModeleColoris> ModeleColoris { get; set; }
        public DbSet<ModeleFinition> ModeleFinitions { get; set; }
        public DbSet<ModeleOption> ModeleOptions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=Deviseur;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Table de liaison : ModeleMoteur (n-n)
            modelBuilder.Entity<ModeleMoteur>()
                .HasKey(mm => new { mm.IdModele, mm.IdMoteur });
            modelBuilder.Entity<ModeleMoteur>()
                .HasOne(mm => mm.Modele)
                .WithMany(m => m.ModeleMoteurs)
                .HasForeignKey(mm => mm.IdModele);
            modelBuilder.Entity<ModeleMoteur>()
                .HasOne(mm => mm.Moteur)
                .WithMany(mo => mo.ModeleMoteurs)
                .HasForeignKey(mm => mm.IdMoteur);

            // Table de liaison : ModeleCategorie (n-n)
            modelBuilder.Entity<ModeleCategorie>()
                .HasKey(mc => new { mc.IdModele, mc.IdCategorie });
            modelBuilder.Entity<ModeleCategorie>()
                .HasOne(mc => mc.Modele)
                .WithMany(m => m.ModeleCategories)
                .HasForeignKey(mc => mc.IdModele);
            modelBuilder.Entity<ModeleCategorie>()
                .HasOne(mc => mc.Categorie)
                .WithMany(c => c.ModeleCategories)
                .HasForeignKey(mc => mc.IdCategorie);

            // Table de liaison : ModeleColoris (n-n)
            modelBuilder.Entity<ModeleColoris>()
                .HasKey(mc => new { mc.IdModele, mc.IdColoris });
            modelBuilder.Entity<ModeleColoris>()
                .HasOne(mc => mc.Modele)
                .WithMany(m => m.ModeleColoris)
                .HasForeignKey(mc => mc.IdModele);
            modelBuilder.Entity<ModeleColoris>()
                .HasOne(mc => mc.Coloris)
                .WithMany(c => c.ModeleColoris)
                .HasForeignKey(mc => mc.IdColoris);

            // Table de liaison : ModeleFinition (n-n)
            modelBuilder.Entity<ModeleFinition>()
                .HasKey(mf => new { mf.IdModele, mf.IdFinition });
            modelBuilder.Entity<ModeleFinition>()
                .HasOne(mf => mf.Modele)
                .WithMany(m => m.ModeleFinitions)
                .HasForeignKey(mf => mf.IdModele);
            modelBuilder.Entity<ModeleFinition>()
                .HasOne(mf => mf.Finition)
                .WithMany(f => f.ModeleFinitions)
                .HasForeignKey(mf => mf.IdFinition);

            // Table de liaison : ModeleOption (n-n)
            modelBuilder.Entity<ModeleOption>()
                .HasKey(mo => new { mo.IdModele, mo.IdOption });
            modelBuilder.Entity<ModeleOption>()
                .HasOne(mo => mo.Modele)
                .WithMany(m => m.ModeleOptions)
                .HasForeignKey(mo => mo.IdModele);
            modelBuilder.Entity<ModeleOption>()
                .HasOne(mo => mo.OptionAuto)
                .WithMany(o => o.ModeleOptions)
                .HasForeignKey(mo => mo.IdOption);
        }
    }
}
