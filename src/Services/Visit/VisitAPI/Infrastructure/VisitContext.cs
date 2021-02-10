using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Metadata;
using Visit.API.Infrastructure.EntityConfigurations;
using Visit.API.Model;

#nullable disable

namespace Visit.API.Infrastructure
{
    public partial class VisitContext : DbContext
    {
        public VisitContext()
        {
        }

        public VisitContext(DbContextOptions<VisitContext> options)
            : base(options)
        {
        }

        public virtual DbSet<VisitInfo> VisitInfos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.ApplyConfiguration(new VisitInfoEntityTypeConfiguration());

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }

    public class FormContextDesignFactory : IDesignTimeDbContextFactory<VisitContext>
    {
        public VisitContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<VisitContext>()
                .UseSqlServer("Server=.;Database=Clinic.Data;User=sa;Password=sa123;");

            return new VisitContext(optionsBuilder.Options);
        }
    }
}
