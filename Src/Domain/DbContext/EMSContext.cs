using System;
using Microsoft.EntityFrameworkCore;
using XM.Models.Entity;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Domain.DBContext
{
    public partial class EMSContext : DbContext
    {
        public EMSContext()
        {
        }

        public EMSContext(DbContextOptions<EMSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccessLevels> AccessLevels { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Choice> Choice { get; set; }
        public virtual DbSet<Duration> Duration { get; set; }
        public virtual DbSet<Genders> Genders { get; set; }
        public virtual DbSet<Languague> Languague { get; set; }
        public virtual DbSet<Paper> Paper { get; set; }
        public virtual DbSet<Photo> Photo { get; set; }
        public virtual DbSet<Question> Question { get; set; }
        public virtual DbSet<QuestionType> QuestionType { get; set; }
        public virtual DbSet<Registration> Registration { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<Test> Test { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=EMS;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<AccessLevels>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(250);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(400);
            });

            modelBuilder.Entity<Choice>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Label).HasMaxLength(400);

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.Choice)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Choice_QuestionID");
            });

            modelBuilder.Entity<Duration>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AnswredTime).HasColumnType("date");

                entity.Property(e => e.LeaveTime).HasColumnType("date");

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.Property(e => e.RegistrationId).HasColumnName("RegistrationID");

                entity.Property(e => e.RequestTime).HasColumnType("date");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.Duration)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Duration_QuestionID");

                entity.HasOne(d => d.Registration)
                    .WithMany(p => p.Duration)
                    .HasForeignKey(d => d.RegistrationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Duration_RegistrationID");
            });

            modelBuilder.Entity<Genders>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Languague>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<Paper>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Answer).HasMaxLength(400);

                entity.Property(e => e.ChoiceId).HasColumnName("ChoiceID");

                entity.Property(e => e.RegistrationId).HasColumnName("RegistrationID");

                entity.HasOne(d => d.Choice)
                    .WithMany(p => p.Paper)
                    .HasForeignKey(d => d.ChoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Paper_ChoiceID");

                entity.HasOne(d => d.Registration)
                    .WithMany(p => p.Paper)
                    .HasForeignKey(d => d.RegistrationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Paper_RegistrationID");
            });

            modelBuilder.Entity<Photo>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Base64).IsUnicode(false);

                entity.Property(e => e.ContentType)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Descriptions).HasMaxLength(400);

                entity.Property(e => e.FileName).HasColumnName("fileName");

                entity.Property(e => e.Path)
                    .HasColumnName("path")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RecordId).HasColumnName("RecordID");
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.QuestionTypeId).HasColumnName("QuestionTypeID");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Question)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Question_CategoryID");

                entity.HasOne(d => d.QuestionType)
                    .WithMany(p => p.Question)
                    .HasForeignKey(d => d.QuestionTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Question_TypeID");
            });

            modelBuilder.Entity<QuestionType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Registration>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccessLevelId).HasColumnName("AccessLevelID");

                entity.Property(e => e.RegistrationDate).HasColumnType("date");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.TestId).HasColumnName("TestID");

                entity.Property(e => e.Toaken).HasMaxLength(400);

                entity.Property(e => e.TokenExpireTime).HasColumnType("date");

                entity.HasOne(d => d.AccessLevel)
                    .WithMany(p => p.Registration)
                    .HasForeignKey(d => d.AccessLevelId)
                    .HasConstraintName("FK_Registration_AccessLevelID");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Registration)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK_Registration_StudentID");

                entity.HasOne(d => d.Test)
                    .WithMany(p => p.Registration)
                    .HasForeignKey(d => d.TestId)
                    .HasConstraintName("FK_Registration_TestID");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FatherName).HasMaxLength(400);

                entity.Property(e => e.GenderId).HasColumnName("GenderID");

                entity.Property(e => e.Name).HasMaxLength(400);

                entity.Property(e => e.Nid)
                    .HasColumnName("NID")
                    .HasMaxLength(20);

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.Student)
                    .HasForeignKey(d => d.GenderId)
                    .HasConstraintName("FK_Student_GenderID");
            });

            modelBuilder.Entity<Test>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description).HasMaxLength(400);

                entity.Property(e => e.Name).HasMaxLength(400);
            });
        }
    }
}
