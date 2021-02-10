using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Masterdata.API.Model;
using Masterdata.API.Infrastructure.EntityConfigurations;
using Microsoft.EntityFrameworkCore.Design;

#nullable disable

namespace Masterdata.API.Infrastructure
{
    public partial class MasterdataContext : DbContext
    {
        public MasterdataContext()
        {
        }

        public MasterdataContext(DbContextOptions<MasterdataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DoctorInfo> Doctors { get; set; }
        public virtual DbSet<PatientInfo> Patients { get; set; }
        public virtual DbSet<VisitInfo> Visits { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.ApplyConfiguration(new DoctorInfoEntityTypeConfiguration());

            modelBuilder.ApplyConfiguration(new PatientInfoEntityTypeConfiguration());

            modelBuilder.ApplyConfiguration(new VisitInfoEntityTypeConfiguration());

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }

    public class MasterdataContextDesignFactory : IDesignTimeDbContextFactory<MasterdataContext>
    {
        public MasterdataContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MasterdataContext>()
                .UseSqlServer("Server=.;Database=Clinic.Data;User=sa;Password=sa123;");

            return new MasterdataContext(optionsBuilder.Options);
        }
    }
}
