using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TimetableApp.Data.Database
{
    public partial class TimetableDbContext : DbContext
    {
        public TimetableDbContext()
        {
        }

        public TimetableDbContext(DbContextOptions<TimetableDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Activity> Activities { get; set; } = null!;
        public virtual DbSet<Timetable> Timetables { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=TimetableDb;Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Activity>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("Activity_pk")
                    .IsClustered(false);

                entity.ToTable("Activity");

                entity.Property(e => e.Bcolor)
                    .HasColumnName("BColor")
                    .HasDefaultValueSql("((255))");

                entity.Property(e => e.Description).HasMaxLength(2048);

                entity.Property(e => e.Gcolor)
                    .HasColumnName("GColor")
                    .HasDefaultValueSql("((255))");

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.Property(e => e.Rcolor)
                    .HasColumnName("RColor")
                    .HasDefaultValueSql("((255))");

                entity.HasOne(d => d.Timetable)
                    .WithMany(p => p.Activities)
                    .HasForeignKey(d => d.TimetableId)
                    .HasConstraintName("Activity_Timetable_Id_fk");
            });

            modelBuilder.Entity<Timetable>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("Timetable_pk")
                    .IsClustered(false);

                entity.ToTable("Timetable");

                entity.Property(e => e.Description).HasMaxLength(2048);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
