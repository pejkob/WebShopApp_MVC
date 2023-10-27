using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebShop_MVC_DbtoM.Models;

public partial class WebshopMvcContext : DbContext
{
    public WebshopMvcContext()
    {
    }

    public WebshopMvcContext(DbContextOptions<WebshopMvcContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Efmigrationshistory> Efmigrationshistories { get; set; }

    public virtual DbSet<Kategorium> Kategoria { get; set; }

    public virtual DbSet<Termek> Termek { get; set; }

   
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Efmigrationshistory>(entity =>
        {
            entity.HasKey(e => e.MigrationId).HasName("PRIMARY");

            entity.ToTable("__efmigrationshistory");

            entity.Property(e => e.MigrationId).HasMaxLength(150);
            entity.Property(e => e.ProductVersion).HasMaxLength(32);
        });

        modelBuilder.Entity<Kategorium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("kategoria");

            entity.Property(e => e.Id).HasColumnType("int(11)");
            entity.Property(e => e.Leiras).HasDefaultValueSql("'NULL'");
            entity.Property(e => e.Nev).HasDefaultValueSql("'NULL'");
        });

        modelBuilder.Entity<Termek>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("termek");

            entity.HasIndex(e => e.KategoriaId, "KategoriaId");

            entity.Property(e => e.Id).HasColumnType("int(11)");
            entity.Property(e => e.FenykepUtvonal).HasDefaultValueSql("'NULL'");
            entity.Property(e => e.KategoriaId).HasColumnType("int(11)");
            entity.Property(e => e.Leiras).HasDefaultValueSql("'NULL'");
            entity.Property(e => e.Nev).HasDefaultValueSql("'NULL'");

            entity.HasOne(d => d.Kategoria).WithMany(p => p.Termeks)
                .HasForeignKey(d => d.KategoriaId)
                .HasConstraintName("termek_ibfk_1");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
