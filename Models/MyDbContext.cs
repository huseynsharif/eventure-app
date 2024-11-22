using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EventureApp.Models;

public partial class MyDbContext : DbContext
{
    public MyDbContext()
    {
    }

    public MyDbContext(DbContextOptions<MyDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Attendee> Attendees { get; set; }

    public virtual DbSet<Event> Events { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-B0HVO22\\SQLEXPRESS;Database=eventuredb;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Attendee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Attendee__3214EC0726C454DC");

            entity.ToTable("Attendee");

            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.EventId).HasColumnName("Event_id");
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.Surname).HasMaxLength(255);
            entity.Property(e => e.UserId).HasColumnName("User_id");

            entity.HasOne(d => d.Event).WithMany(p => p.Attendees)
                .HasForeignKey(d => d.EventId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Attendee_Event");

            entity.HasOne(d => d.User).WithMany(p => p.Attendees)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Attendee_User");
        });

        modelBuilder.Entity<Event>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Event__3214EC0722A57926");

            entity.ToTable("Event");

            entity.Property(e => e.EndDateTime).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.StartDateTime).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("User_id");

            entity.HasOne(d => d.User).WithMany(p => p.Events)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Event_User");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__User__3214EC074093EF8D");

            entity.ToTable("User");

            entity.HasIndex(e => e.Username, "UQ__User__536C85E4C0151FB8").IsUnique();

            entity.Property(e => e.Password).HasMaxLength(255);
            entity.Property(e => e.Username).HasMaxLength(255);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
