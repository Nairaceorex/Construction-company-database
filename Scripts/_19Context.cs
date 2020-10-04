using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Scripts
{
    public partial class _19Context : DbContext
    {
        public _19Context()
        {
        }

        public _19Context(DbContextOptions<_19Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Brigades> Brigades { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Materials> Materials { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Positions> Positions { get; set; }
        public virtual DbSet<Staff> Staff { get; set; }
        public virtual DbSet<TypesOfJobs> TypesOfJobs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlite("Data Source=N:\\Construction-company-database\\Data_Base\\19.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brigades>(entity =>
            {
                entity.HasKey(e => e.IdBrigade);

                entity.Property(e => e.IdBrigade)
                    .HasColumnName("ID_Brigade")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdEmployee)
                    .HasColumnName("ID_Employee")
                    .HasColumnType("INT");

                entity.Property(e => e.IdEmployee3idEmployee)
                    .HasColumnName("ID_Employee_3ID_Employee")
                    .HasColumnType("INT");

                entity.HasOne(d => d.IdEmployeeNavigation)
                    .WithMany(p => p.BrigadesIdEmployeeNavigation)
                    .HasForeignKey(d => d.IdEmployee)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdEmployee3idEmployeeNavigation)
                    .WithMany(p => p.BrigadesIdEmployee3idEmployeeNavigation)
                    .HasForeignKey(d => d.IdEmployee3idEmployee)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.HasKey(e => e.IdCustomer);

                entity.Property(e => e.IdCustomer)
                    .HasColumnName("ID_Customer")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnType("VARCHAR");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasColumnName("Full_Name")
                    .HasColumnType("VARCHAR");

                entity.Property(e => e.PassportData)
                    .HasColumnName("Passport_data")
                    .HasColumnType("INT");

                entity.Property(e => e.Phone).HasColumnType("INT");
            });

            modelBuilder.Entity<Materials>(entity =>
            {
                entity.HasKey(e => e.IdMaterial);

                entity.Property(e => e.IdMaterial)
                    .HasColumnName("ID_Material")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdMaterials2idType)
                    .HasColumnName("ID_Materials_2ID_Type")
                    .HasColumnType("INT");

                entity.Property(e => e.IdMaterials3idType)
                    .HasColumnName("ID_Materials_3ID_Type")
                    .HasColumnType("INT");

                entity.Property(e => e.IdType)
                    .HasColumnName("ID_Type")
                    .HasColumnType("INT");

                entity.HasOne(d => d.IdMaterials2idTypeNavigation)
                    .WithMany(p => p.MaterialsIdMaterials2idTypeNavigation)
                    .HasForeignKey(d => d.IdMaterials2idType)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdMaterials3idTypeNavigation)
                    .WithMany(p => p.MaterialsIdMaterials3idTypeNavigation)
                    .HasForeignKey(d => d.IdMaterials3idType)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdTypeNavigation)
                    .WithMany(p => p.MaterialsIdTypeNavigation)
                    .HasForeignKey(d => d.IdType)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasKey(e => e.IdOrder);

                entity.Property(e => e.IdOrder)
                    .HasColumnName("ID_Order")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.AboutPayment)
                    .IsRequired()
                    .HasColumnName("About_payment")
                    .HasColumnType("VARCHAR");

                entity.Property(e => e.CompletionMark)
                    .IsRequired()
                    .HasColumnName("Completion_mark")
                    .HasColumnType("VARCHAR");

                entity.Property(e => e.Cost).HasColumnType("INT");

                entity.Property(e => e.ExpirationDate)
                    .IsRequired()
                    .HasColumnName("Expiration_date")
                    .HasColumnType("DATE");

                entity.Property(e => e.IdBrigade)
                    .HasColumnName("ID_Brigade")
                    .HasColumnType("INT");

                entity.Property(e => e.IdCustomer)
                    .HasColumnName("ID_Customer_")
                    .HasColumnType("INT");

                entity.Property(e => e.IdType)
                    .HasColumnName("ID_Type")
                    .HasColumnType("INT");

                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasColumnName("Start_date")
                    .HasColumnType("DATE");

                entity.HasOne(d => d.IdBrigadeNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.IdBrigade);

                entity.HasOne(d => d.IdCustomerNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.IdCustomer)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdTypeNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.IdType)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Positions>(entity =>
            {
                entity.HasKey(e => e.IdPosition);

                entity.Property(e => e.IdPosition)
                    .HasColumnName("ID_Position")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.Duties)
                    .IsRequired()
                    .HasColumnType("VARCHAR");

                entity.Property(e => e.JobTitle)
                    .IsRequired()
                    .HasColumnName("Job_title")
                    .HasColumnType("VARCHAR");

                entity.Property(e => e.Requirements)
                    .IsRequired()
                    .HasColumnType("VARCHAR");

                entity.Property(e => e.Salary).HasColumnType("INT");
            });

            modelBuilder.Entity<Staff>(entity =>
            {
                entity.HasKey(e => e.IdEmployee);

                entity.Property(e => e.IdEmployee)
                    .HasColumnName("ID_Employee")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnType("VARCHAR");

                entity.Property(e => e.Age).HasColumnType("INT");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasColumnName("Full_Name")
                    .HasColumnType("VARCHAR");

                entity.Property(e => e.IdBrigade)
                    .HasColumnName("ID_Brigade")
                    .HasColumnType("INT");

                entity.Property(e => e.IdPosition)
                    .HasColumnName("ID_Position")
                    .HasColumnType("INT");

                entity.Property(e => e.PassportData)
                    .HasColumnName("Passport_data")
                    .HasColumnType("INT");

                entity.Property(e => e.Phone).HasColumnType("INT");

                entity.Property(e => e.Sex)
                    .IsRequired()
                    .HasColumnType("VARCHAR");

                entity.HasOne(d => d.IdBrigadeNavigation)
                    .WithMany(p => p.Staff)
                    .HasForeignKey(d => d.IdBrigade)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdPositionNavigation)
                    .WithMany(p => p.Staff)
                    .HasForeignKey(d => d.IdPosition);
            });

            modelBuilder.Entity<TypesOfJobs>(entity =>
            {
                entity.HasKey(e => e.IdType);

                entity.ToTable("Types_of_jobs");

                entity.Property(e => e.IdType)
                    .HasColumnName("ID_Type")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("_Description")
                    .HasColumnType("VARCHAR");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("_Name")
                    .HasColumnType("VARCHAR");

                entity.Property(e => e.PriceOfWork)
                    .HasColumnName("Price_of_work")
                    .HasColumnType("INT");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
