using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Logging;

namespace EFCoreTesting.Performace.AutoMapper
{
    public partial class BigDataContext : DbContext
    {
        public BigDataContext()
        {
        }

        public BigDataContext(DbContextOptions<BigDataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BigDataSet> BigDataSets { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.EnableSensitiveDataLogging();
                optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
                optionsBuilder.EnableServiceProviderCaching(false);
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-H8N03VT\\SQLEXPRESS;Initial Catalog=BigData;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BigDataSet>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BigDataSet");

                entity.Property(e => e.A546u456u)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("a546u456u");

                entity.Property(e => e.Asdssdv)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("asdssdv");

                entity.Property(e => e.Cct)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cct");

                entity.Property(e => e.Dlfkjn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dlfkjn");

                entity.Property(e => e.Dlkfgldfng)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dlkfgldfng");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Fghjfghj)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fghjfghj");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("first_name");

                entity.Property(e => e.Gender)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gender");

                entity.Property(e => e.Gfd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gfd");

                entity.Property(e => e.Gs4t)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GS4T");

                entity.Property(e => e.I321)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("i321");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ioljloo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ioljloo");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ip_address");

                entity.Property(e => e.J147)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("j147");

                entity.Property(e => e.L546)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("last_name");

                entity.Property(e => e.O789)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("o789");

                entity.Property(e => e.P963)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("p963");

                entity.Property(e => e.R675r67)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("R675R67");

                entity.Property(e => e.Sdfgs)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SDFGS");

                entity.Property(e => e.Sdfsdfsd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sdfsdfsd");

                entity.Property(e => e.Sdhsdgsdfg)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sdhsdgsdfg");

                entity.Property(e => e.Sxg)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SXG");

                entity.Property(e => e.Vin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vin");

                entity.Property(e => e.W94085jhgjw45)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("w94085jhgjw45");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
