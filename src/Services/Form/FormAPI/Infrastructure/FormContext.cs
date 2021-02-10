using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Form.API.Model;
using Form.API.Infrastructure.EntityConfigurations;
using Microsoft.EntityFrameworkCore.Design;

#nullable disable

namespace Form.API.Infrastructure
{
    public partial class FormContext : DbContext
    {
        public FormContext()
        {
        }

        public FormContext(DbContextOptions<FormContext> options)
            : base(options)
        {
        }

        public virtual DbSet<FormData> FormData { get; set; }
        public virtual DbSet<FormInfo> Forms { get; set; }
        public virtual DbSet<SchemaInfo> Schemas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.ApplyConfiguration(new FormDataEntityTypeConfiguration());

            modelBuilder.ApplyConfiguration(new FormInfoEntityTypeConfiguration());

            modelBuilder.ApplyConfiguration(new SchemaInfoEntityTypeConfiguration());

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }

    public class FormContextDesignFactory : IDesignTimeDbContextFactory<FormContext>
    {
        public FormContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<FormContext>()
                .UseSqlServer("Server=.;Database=Clinic.Data;User=sa;Password=sa123;");

            return new FormContext(optionsBuilder.Options);
        }
    }
}
