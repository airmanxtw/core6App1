using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace core6App1.Models
{
    public partial class EvaluateContext : DbContext
    {
        public EvaluateContext()
        {
        }

        public EvaluateContext(DbContextOptions<EvaluateContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Stud> Studs { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=db.stust.edu.tw;Initial Catalog=Evaluate;User ID=airmanx;Password=6005");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Stud>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("stud");

                entity.Property(e => e.ChiefId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("chief_id");

                entity.Property(e => e.ChiefName)
                    .HasMaxLength(6)
                    .HasColumnName("chief_name");

                entity.Property(e => e.ClassNa)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("class_na");

                entity.Property(e => e.ClassNo)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("class_no");

                entity.Property(e => e.DeptId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dept_id");

                entity.Property(e => e.DeptName)
                    .HasMaxLength(25)
                    .HasColumnName("dept_name");

                entity.Property(e => e.DeptNo)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("dept_no");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.ProgramName)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("program_name");

                entity.Property(e => e.Sex)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("sex");

                entity.Property(e => e.SortName)
                    .HasMaxLength(10)
                    .HasColumnName("sort_name");

                entity.Property(e => e.StudName)
                    .HasMaxLength(10)
                    .HasColumnName("stud_name");

                entity.Property(e => e.StudNo)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("stud_no");

                entity.Property(e => e.TeaCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("tea_code");

                entity.Property(e => e.TeaName)
                    .HasMaxLength(50)
                    .HasColumnName("tea_name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
