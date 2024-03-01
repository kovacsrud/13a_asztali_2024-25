using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WpfKutyakSqlite.mvvm.models;

public partial class KutyakContext : DbContext
{
    public KutyakContext()
    {
    }

    public KutyakContext(DbContextOptions<KutyakContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Kutya> Kutyak { get; set; }

    public virtual DbSet<Kutyafajtak> Kutyafajtak { get; set; }

    public virtual DbSet<Kutyanevek> Kutyanevek { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        => optionsBuilder.UseSqlite("Data Source=d:\\rud\\kutyak.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Kutya>(entity =>
        {
            entity.ToTable("kutya");

            entity.Property(e => e.Eletkor).HasColumnName("eletkor");
            entity.Property(e => e.Fajtaid).HasColumnName("fajtaid");
            entity.Property(e => e.Nevid).HasColumnName("nevid");
            entity.Property(e => e.Utolsoell)
                .HasColumnType("STRING")
                .HasColumnName("utolsoell");

            entity.HasOne(d => d.Fajta).WithMany(p => p.Kutyak)
                .HasForeignKey(d => d.Fajtaid)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Nev).WithMany(p => p.Kutyak)
                .HasForeignKey(d => d.Nevid)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Kutyafajtak>(entity =>
        {
            entity.ToTable("kutyafajtak");

            entity.Property(e => e.Eredetinev)
                .HasColumnType("VARCHAR")
                .HasColumnName("eredetinev");
            entity.Property(e => e.Nev)
                .HasColumnType("VARCHAR")
                .HasColumnName("nev");
        });

        modelBuilder.Entity<Kutyanevek>(entity =>
        {
            entity.ToTable("kutyanevek");

            entity.Property(e => e.Kutyanev)
                .HasColumnType("VARCHAR")
                .HasColumnName("kutyanev");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
