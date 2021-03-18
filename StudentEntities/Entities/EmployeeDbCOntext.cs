using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;



namespace StudentEntities.Entities
{
    public partial class EmployeeDbCOntext : DbContext
    {
        public EmployeeDbCOntext()
        {
        }

        public EmployeeDbCOntext(DbContextOptions<EmployeeDbCOntext> options)
            : base(options)
        {
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<StudentsTable> StudentsTables { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=StudentData;User ID=Harman;Password=Happy@123;");
//            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Catagory)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExpiryDate).HasColumnType("date");

                entity.Property(e => e.ProductColor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductDiscription)
                    .IsRequired()
                    .HasMaxLength(50)
                    ;

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(50)
                    ;
            });

            modelBuilder.Entity<StudentsTable>(entity =>
            {
                entity.HasKey(e => e.StudentId);

                entity.ToTable("StudentsTable");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.StudentName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
