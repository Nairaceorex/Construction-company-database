using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Script
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

        public virtual DbSet<Бригада> Бригада { get; set; }
        public virtual DbSet<ВидыРабот> ВидыРабот { get; set; }
        public virtual DbSet<Должности> Должности { get; set; }
        public virtual DbSet<Заказчики> Заказчики { get; set; }
        public virtual DbSet<Заказы> Заказы { get; set; }
        public virtual DbSet<Материалы> Материалы { get; set; }
        public virtual DbSet<Сотрудники> Сотрудники { get; set; }

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
            modelBuilder.Entity<Бригада>(entity =>
            {
                entity.HasKey(e => e.КодБригада);

                entity.Property(e => e.КодБригада)
                    .HasColumnName("Код_бригада")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.КодСотрудника)
                    .HasColumnName("Код_сотрудника")
                    .HasColumnType("INT");

                entity.Property(e => e.КодСотрудника3кодСотрудника)
                    .HasColumnName("Код_сотрудника_3Код_сотрудника")
                    .HasColumnType("INT");

                entity.HasOne(d => d.КодСотрудникаNavigation)
                    .WithMany(p => p.БригадаКодСотрудникаNavigation)
                    .HasForeignKey(d => d.КодСотрудника)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.КодСотрудника3кодСотрудникаNavigation)
                    .WithMany(p => p.БригадаКодСотрудника3кодСотрудникаNavigation)
                    .HasForeignKey(d => d.КодСотрудника3кодСотрудника)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ВидыРабот>(entity =>
            {
                entity.HasKey(e => e.КодВида);

                entity.ToTable("Виды_работ");

                entity.Property(e => e.КодВида)
                    .HasColumnName("Код_вида")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.Наименование)
                    .IsRequired()
                    .HasColumnName("_Наименование")
                    .HasColumnType("VARCHAR");

                entity.Property(e => e.Описание)
                    .IsRequired()
                    .HasColumnName("_Описание")
                    .HasColumnType("VARCHAR");

                entity.Property(e => e.ЦенаРаботы)
                    .HasColumnName("Цена_работы")
                    .HasColumnType("INT");
            });

            modelBuilder.Entity<Должности>(entity =>
            {
                entity.HasKey(e => e.КодДолжности);

                entity.Property(e => e.КодДолжности)
                    .HasColumnName("Код_должности")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.НаименованиеДолжности)
                    .IsRequired()
                    .HasColumnName("Наименование_должности")
                    .HasColumnType("VARCHAR");

                entity.Property(e => e.Обязанности)
                    .IsRequired()
                    .HasColumnType("VARCHAR");

                entity.Property(e => e.Оклад).HasColumnType("INT");

                entity.Property(e => e.Требования)
                    .IsRequired()
                    .HasColumnType("VARCHAR");
            });

            modelBuilder.Entity<Заказчики>(entity =>
            {
                entity.HasKey(e => e.КодЗаказчика);

                entity.Property(e => e.КодЗаказчика)
                    .HasColumnName("Код_заказчика")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.Адрес)
                    .IsRequired()
                    .HasColumnType("VARCHAR");

                entity.Property(e => e.ПаспортныеДанные)
                    .HasColumnName("Паспортные_данные")
                    .HasColumnType("INT");

                entity.Property(e => e.Телефон).HasColumnType("INT");

                entity.Property(e => e.Фио)
                    .IsRequired()
                    .HasColumnName("ФИО")
                    .HasColumnType("VARCHAR");
            });

            modelBuilder.Entity<Заказы>(entity =>
            {
                entity.HasKey(e => e.КодЗаказа);

                entity.Property(e => e.КодЗаказа)
                    .HasColumnName("Код_заказа")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.ДатаНачала)
                    .IsRequired()
                    .HasColumnName("Дата_начала")
                    .HasColumnType("DATE");

                entity.Property(e => e.ДатаОкончания)
                    .IsRequired()
                    .HasColumnName("Дата_окончания")
                    .HasColumnType("DATE");

                entity.Property(e => e.КодБригада)
                    .HasColumnName("Код_бригада")
                    .HasColumnType("INT");

                entity.Property(e => e.КодВида)
                    .HasColumnName("Код_вида")
                    .HasColumnType("INT");

                entity.Property(e => e.КодЗаказчика)
                    .HasColumnName("Код_заказчика")
                    .HasColumnType("INT");

                entity.Property(e => e.ОбОплате)
                    .IsRequired()
                    .HasColumnName("Об_оплате")
                    .HasColumnType("VARCHAR");

                entity.Property(e => e.ОтметкаОЗавершении)
                    .IsRequired()
                    .HasColumnName("Отметка_о_завершении")
                    .HasColumnType("VARCHAR");

                entity.Property(e => e.Стоимость).HasColumnType("INT");

                entity.HasOne(d => d.КодБригадаNavigation)
                    .WithMany(p => p.Заказы)
                    .HasForeignKey(d => d.КодБригада);

                entity.HasOne(d => d.КодВидаNavigation)
                    .WithMany(p => p.Заказы)
                    .HasForeignKey(d => d.КодВида)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.КодЗаказчикаNavigation)
                    .WithMany(p => p.Заказы)
                    .HasForeignKey(d => d.КодЗаказчика)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Материалы>(entity =>
            {
                entity.HasKey(e => e.КодМатериала);

                entity.Property(e => e.КодМатериала)
                    .HasColumnName("Код_материала")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.КодВида)
                    .HasColumnName("Код_вида")
                    .HasColumnType("INT");

                entity.Property(e => e.КодМатериала2кодВида)
                    .HasColumnName("Код_материала_2Код_вида")
                    .HasColumnType("INT");

                entity.Property(e => e.КодМатериала3кодВида)
                    .HasColumnName("Код_материала_3Код_вида")
                    .HasColumnType("INT");

                entity.HasOne(d => d.КодВидаNavigation)
                    .WithMany(p => p.МатериалыКодВидаNavigation)
                    .HasForeignKey(d => d.КодВида)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.КодМатериала2кодВидаNavigation)
                    .WithMany(p => p.МатериалыКодМатериала2кодВидаNavigation)
                    .HasForeignKey(d => d.КодМатериала2кодВида)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.КодМатериала3кодВидаNavigation)
                    .WithMany(p => p.МатериалыКодМатериала3кодВидаNavigation)
                    .HasForeignKey(d => d.КодМатериала3кодВида)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Сотрудники>(entity =>
            {
                entity.HasKey(e => e.КодСотрудника);

                entity.Property(e => e.КодСотрудника)
                    .HasColumnName("Код_сотрудника")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.Адрес)
                    .IsRequired()
                    .HasColumnType("VARCHAR");

                entity.Property(e => e.Возраст).HasColumnType("INT");

                entity.Property(e => e.КодБригада)
                    .HasColumnName("Код_бригада")
                    .HasColumnType("INT");

                entity.Property(e => e.КодДолжности)
                    .HasColumnName("Код_должности")
                    .HasColumnType("INT");

                entity.Property(e => e.ПаспортныеДанные)
                    .HasColumnName("Паспортные_данные")
                    .HasColumnType("INT");

                entity.Property(e => e.Пол)
                    .IsRequired()
                    .HasColumnType("VARCHAR");

                entity.Property(e => e.Телефон).HasColumnType("INT");

                entity.Property(e => e.Фио)
                    .IsRequired()
                    .HasColumnName("ФИО")
                    .HasColumnType("VARCHAR");

                entity.HasOne(d => d.КодБригадаNavigation)
                    .WithMany(p => p.Сотрудники)
                    .HasForeignKey(d => d.КодБригада)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.КодДолжностиNavigation)
                    .WithMany(p => p.Сотрудники)
                    .HasForeignKey(d => d.КодДолжности);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
