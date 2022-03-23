using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;


namespace OnlineExamSystemApp.Models
{
    public partial class OnlineExamDbContext : DbContext
    {
        public OnlineExamDbContext(DbContextOptions<OnlineExamDbContext> options)
            : base(options)
        {

        }

        public virtual DbSet<Answerbank> Answerbank { get; set; }
        public virtual DbSet<Correctanswer> Correctanswer { get; set; }
        public virtual DbSet<Difficultylevel> Difficultylevel { get; set; }
        public virtual DbSet<Examcategory> Examcategory { get; set; }
        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<Questionbank> Questionbank { get; set; }
        public virtual DbSet<Registration> Registration { get; set; }
        public virtual DbSet<Userexamrecord> Userexamrecord { get; set; }
        public virtual DbSet<Usertype> Usertype { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        //        optionsBuilder.UseSqlServer("server=.;database=OnlineExamDb;user id=sa;password=sqlserver2017;");
        //    }
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Answerbank>(entity =>
            {
                entity.HasKey(e => e.AnsId)
                    .HasName("PK__answerba__24F9FB17E6ADFA10");

                entity.ToTable("answerbank");

                entity.Property(e => e.AnsId).HasColumnName("ans_id");

                entity.Property(e => e.AnsText)
                    .HasColumnName("ans_text")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QId).HasColumnName("q_id");

                entity.HasOne(d => d.Q)
                    .WithMany(p => p.Answerbank)
                    .HasForeignKey(d => d.QId)
                    .HasConstraintName("FK_OBank_ABank_Id");
            });

            modelBuilder.Entity<Correctanswer>(entity =>
            {
                entity.HasKey(e => e.CorrectAnsId)
                    .HasName("PK__correcta__99C9B7148B3E6D37");

                entity.ToTable("correctanswer");

                entity.Property(e => e.CorrectAnsId).HasColumnName("correct_ans_id");

                entity.Property(e => e.AnsId).HasColumnName("ans_id");

                entity.Property(e => e.QId).HasColumnName("q_id");

                entity.HasOne(d => d.Ans)
                    .WithMany(p => p.Correctanswer)
                    .HasForeignKey(d => d.AnsId)
                    .HasConstraintName("FK_ABank_CrtAns_Id");

                entity.HasOne(d => d.Q)
                    .WithMany(p => p.Correctanswer)
                    .HasForeignKey(d => d.QId)
                    .HasConstraintName("FK_QBank_CrtAns_Id");
            });

            modelBuilder.Entity<Difficultylevel>(entity =>
            {
                entity.HasKey(e => e.LevelId)
                    .HasName("PK__difficul__03461643AA4342A4");

                entity.ToTable("difficultylevel");

                entity.Property(e => e.LevelId).HasColumnName("level_id");

                entity.Property(e => e.LevelName).HasColumnName("level_name");
            });

            modelBuilder.Entity<Examcategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PK__examcate__D54EE9B41E000F92");

                entity.ToTable("examcategory");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasColumnName("category_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.HasKey(e => e.EmailId)
                    .HasName("PK__login__3FEF876664F0A551");

                entity.ToTable("login");

                entity.Property(e => e.EmailId)
                    .HasColumnName("email_id")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Login)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_UType_Login_ID");
            });

            modelBuilder.Entity<Questionbank>(entity =>
            {
                entity.HasKey(e => e.QId)
                    .HasName("PK__question__3D59B3104EDDE90F");

                entity.ToTable("questionbank");

                entity.Property(e => e.QId).HasColumnName("q_id");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.LevelId).HasColumnName("level_id");

                entity.Property(e => e.QText)
                    .IsRequired()
                    .HasColumnName("q_text")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Questionbank)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_Cetg_QBank_Id");

                entity.HasOne(d => d.Level)
                    .WithMany(p => p.Questionbank)
                    .HasForeignKey(d => d.LevelId)
                    .HasConstraintName("FK_Level_QBank_Id");
            });

            modelBuilder.Entity<Registration>(entity =>
            {
                entity.HasKey(e => e.RegId)
                    .HasName("PK__registra__7403877280229C06");

                entity.ToTable("registration");

                entity.Property(e => e.RegId)
                    .HasColumnName("reg_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("city")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompletionYr)
                    .HasColumnName("completion_yr")
                    .HasColumnType("date");

                entity.Property(e => e.Dob)
                    .HasColumnName("dob")
                    .HasColumnType("date");

                entity.Property(e => e.EmailId)
                    .HasColumnName("email_id")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Qualification)
                    .IsRequired()
                    .HasColumnName("qualification")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasColumnName("state")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnName("user_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Email)
                    .WithMany(p => p.Registration)
                    .HasForeignKey(d => d.EmailId)
                    .HasConstraintName("FK_Login_Reg_ID");
            });

            modelBuilder.Entity<Userexamrecord>(entity =>
            {
                entity.HasKey(e => e.ExamEntryId)
                    .HasName("PK__userexam__509F803F4A9B88B7");

                entity.ToTable("userexamrecord");

                entity.Property(e => e.ExamEntryId)
                    .HasColumnName("exam_entry_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EmailId)
                    .HasColumnName("email_id")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LevelId).HasColumnName("level_id");

                entity.Property(e => e.Score).HasColumnName("score");

                entity.HasOne(d => d.Email)
                    .WithMany(p => p.Userexamrecord)
                    .HasForeignKey(d => d.EmailId)
                    .HasConstraintName("FK_Login_UExamRec_ID");

                entity.HasOne(d => d.Level)
                    .WithMany(p => p.Userexamrecord)
                    .HasForeignKey(d => d.LevelId)
                    .HasConstraintName("FK_DLevel_ID");
            });

            modelBuilder.Entity<Usertype>(entity =>
            {
                entity.HasKey(e => e.TypeId)
                    .HasName("PK__usertype__2C0005985EE93F8E");

                entity.ToTable("usertype");

                entity.Property(e => e.TypeId)
                    .HasColumnName("type_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasColumnName("type_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
