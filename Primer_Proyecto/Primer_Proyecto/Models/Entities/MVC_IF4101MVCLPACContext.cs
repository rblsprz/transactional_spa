using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Primer_Proyecto.Models.Entities
{
    public partial class MVC_IF4101MVCLPACContext : DbContext
    {
        public MVC_IF4101MVCLPACContext()
        {
        }

        public MVC_IF4101MVCLPACContext(DbContextOptions<MVC_IF4101MVCLPACContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AcademicDegree> AcademicDegrees { get; set; }
        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<Canton> Cantons { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<District> Districts { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<PrivateMessage> PrivateMessages { get; set; }
        public virtual DbSet<Professor> Professors { get; set; }
        public virtual DbSet<ProfessorCourse> ProfessorCourses { get; set; }
        public virtual DbSet<Province> Provinces { get; set; }
        public virtual DbSet<PublicConsultation> PublicConsultations { get; set; }
        public virtual DbSet<RepliesPrivateMessage> RepliesPrivateMessages { get; set; }
        public virtual DbSet<RepliesPublicConsultation> RepliesPublicConsultations { get; set; }
        public virtual DbSet<SocialNetworksCatalog> SocialNetworksCatalogs { get; set; }
        public virtual DbSet<SocialNetworksStudent> SocialNetworksStudents { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudentCourse> StudentCourses { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=163.178.107.10;Initial Catalog=MVC_IF4101MVCLPAC;User ID=laboratorios;Password=KmZpo.2796");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<AcademicDegree>(entity =>
            {
                entity.ToTable("AcademicDegree");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.ToTable("Appointment");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.Motive)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK__Appointme__Cours__5070F446");

                entity.HasOne(d => d.Professor)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.ProfessorId)
                    .HasConstraintName("FK_Appointment_Professor");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK__Appointme__Stude__4F7CD00D");
            });

            modelBuilder.Entity<Canton>(entity =>
            {
                entity.ToTable("Canton");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.Cantons)
                    .HasForeignKey(d => d.ProvinceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Canton__Province__25869641");
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.ToTable("Course");

                entity.Property(e => e.Initials)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<District>(entity =>
            {
                entity.ToTable("District");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Canton)
                    .WithMany(p => p.Districts)
                    .HasForeignKey(d => d.CantonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__District__Canton__286302EC");
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.ToTable("Location");

                entity.HasOne(d => d.Canton)
                    .WithMany(p => p.Locations)
                    .HasForeignKey(d => d.CantonId)
                    .HasConstraintName("FK__Location__Canton__2C3393D0");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.Locations)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK__Location__Distri__2D27B809");

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.Locations)
                    .HasForeignKey(d => d.ProvinceId)
                    .HasConstraintName("FK__Location__Provin__2B3F6F97");
            });

            modelBuilder.Entity<PrivateMessage>(entity =>
            {
                entity.ToTable("PrivateMessage");

                entity.Property(e => e.DateTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Motive)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.PrivateMessages)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK__PrivateMe__Cours__5441852A");

                entity.HasOne(d => d.Professor)
                    .WithMany(p => p.PrivateMessages)
                    .HasForeignKey(d => d.ProfessorId)
                    .HasConstraintName("FK__PrivateMe__Profe__32AB8735");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.PrivateMessages)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK__PrivateMe__Stude__534D60F1");
            });

            modelBuilder.Entity<Professor>(entity =>
            {
                entity.ToTable("Professor");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Image)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.AcademicDegree)
                    .WithMany(p => p.Professors)
                    .HasForeignKey(d => d.AcademicDegreeId)
                    .HasConstraintName("FK__Professor__Acade__3D5E1FD2");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Professor)
                    .HasForeignKey<Professor>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Professor__Id__3F466844");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Professors)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("FK__Professor__Locat__3E52440B");
            });

            modelBuilder.Entity<ProfessorCourse>(entity =>
            {
                entity.HasKey(e => new { e.ProfessorId, e.CourseId })
                    .HasName("PK__Professo__FC918E530D4CC555");

                entity.ToTable("ProfessorCourse");

                entity.Property(e => e.CreateAt).HasColumnType("date");

                entity.Property(e => e.UpdatedAt).HasColumnType("date");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.ProfessorCourses)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Professor__Cours__4CA06362");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.ProfessorCourseCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK__Professor__Creat__628FA481");

                entity.HasOne(d => d.Professor)
                    .WithMany(p => p.ProfessorCourses)
                    .HasForeignKey(d => d.ProfessorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Professor__Profe__4BAC3F29");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.ProfessorCourseUpdatedByNavigations)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK__Professor__Updat__6383C8BA");
            });

            modelBuilder.Entity<Province>(entity =>
            {
                entity.ToTable("Province");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateAt).HasColumnType("date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt).HasColumnType("date");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.ProvinceCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK__Province__Create__6477ECF3");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.ProvinceUpdatedByNavigations)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK__Province__Update__656C112C");
            });

            modelBuilder.Entity<PublicConsultation>(entity =>
            {
                entity.ToTable("PublicConsultation");

                entity.Property(e => e.CreateAt).HasColumnType("date");

                entity.Property(e => e.DateTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Motive)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt).HasColumnType("date");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.PublicConsultations)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK__PublicCon__Cours__5812160E");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PublicConsultationCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK__PublicCon__Creat__66603565");

                entity.HasOne(d => d.Professor)
                    .WithMany(p => p.PublicConsultations)
                    .HasForeignKey(d => d.ProfessorId)
                    .HasConstraintName("FK__PublicCon__Profe__31B762FC");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.PublicConsultations)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK__PublicCon__Stude__571DF1D5");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.PublicConsultationUpdatedByNavigations)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK__PublicCon__Updat__6754599E");
            });

            modelBuilder.Entity<RepliesPrivateMessage>(entity =>
            {
                entity.ToTable("RepliesPrivateMessage");

                entity.Property(e => e.DateTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Motive)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.PrivateMessage)
                    .WithMany(p => p.RepliesPrivateMessages)
                    .HasForeignKey(d => d.PrivateMessageId)
                    .HasConstraintName("FK__RepliesPr__Priva__5FB337D6");

                entity.HasOne(d => d.Professor)
                    .WithMany(p => p.RepliesPrivateMessages)
                    .HasForeignKey(d => d.ProfessorId)
                    .HasConstraintName("FK__RepliesPr__Profe__619B8048");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.RepliesPrivateMessages)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK__RepliesPr__Stude__60A75C0F");
            });

            modelBuilder.Entity<RepliesPublicConsultation>(entity =>
            {
                entity.ToTable("RepliesPublicConsultation");

                entity.Property(e => e.DateTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Motive)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Professor)
                    .WithMany(p => p.RepliesPublicConsultations)
                    .HasForeignKey(d => d.ProfessorId)
                    .HasConstraintName("FK__RepliesPu__Profe__5CD6CB2B");

                entity.HasOne(d => d.PublicConsultation)
                    .WithMany(p => p.RepliesPublicConsultations)
                    .HasForeignKey(d => d.PublicConsultationId)
                    .HasConstraintName("FK__RepliesPu__Publi__5AEE82B9");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.RepliesPublicConsultations)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK__RepliesPu__Stude__5BE2A6F2");
            });

            modelBuilder.Entity<SocialNetworksCatalog>(entity =>
            {
                entity.ToTable("SocialNetworksCatalog");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SocialNetworksStudent>(entity =>
            {
                entity.ToTable("SocialNetworksStudent");

                entity.Property(e => e.CreateAt).HasColumnType("date");

                entity.Property(e => e.UpdatedAt).HasColumnType("date");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.SocialNetworksStudentCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK__SocialNet__Creat__6A30C649");

                entity.HasOne(d => d.SocialNetworksName)
                    .WithMany(p => p.SocialNetworksStudents)
                    .HasForeignKey(d => d.SocialNetworksNameId)
                    .HasConstraintName("FK__SocialNet__Socia__38996AB5");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.SocialNetworksStudents)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK__SocialNet__Stude__37A5467C");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.SocialNetworksStudentUpdatedByNavigations)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK__SocialNet__Updat__6B24EA82");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("Student");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Birthday)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateAt).HasColumnType("date");

                entity.Property(e => e.Image)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegistrationStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StudentCard)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StudentName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt).HasColumnType("date");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.StudentCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK__Student__Created__6C190EBB");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.StudentIdNavigation)
                    .HasForeignKey<Student>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Student__Id__32E0915F");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("FK__Student__Locatio__31EC6D26");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.StudentUpdatedByNavigations)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK__Student__Updated__6D0D32F4");
            });

            modelBuilder.Entity<StudentCourse>(entity =>
            {
                entity.HasKey(e => new { e.StudentId, e.CourseId })
                    .HasName("PK__StudentC__5E57FC83D4518050");

                entity.ToTable("StudentCourse");

                entity.Property(e => e.CreateAt).HasColumnType("date");

                entity.Property(e => e.UpdatedAt).HasColumnType("date");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.StudentCourses)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__StudentCo__Cours__48CFD27E");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.StudentCourseCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK__StudentCo__Creat__6E01572D");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.StudentCourses)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__StudentCo__Stude__47DBAE45");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.StudentCourseUpdatedByNavigations)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK__StudentCo__Updat__6EF57B66");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
