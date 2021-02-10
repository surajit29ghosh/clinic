using Form.API.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Form.API.Infrastructure.EntityConfigurations
{
	public class SchemaInfoEntityTypeConfiguration : IEntityTypeConfiguration<SchemaInfo>
	{
		public void Configure(EntityTypeBuilder<SchemaInfo> builder)
		{
            builder.ToTable("SchemaInfo");

            builder.HasKey(e => new { e.FormId, e.FieldId });

            builder.Property(e => e.FieldActive)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            builder.Property(e => e.FieldLabel)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.FieldName)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.FieldOptions).IsUnicode(false);

            builder.Property(e => e.FieldPlaceholder)
                .HasMaxLength(255)
                .IsUnicode(false);

            builder.Property(e => e.FieldStyle)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.FieldType)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.FieldVisible)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            builder.HasOne(d => d.Form)
                   .WithMany(p => p.Schemas)
                   .HasForeignKey(d => d.FormId)
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("FK_SchemaInfo_FormInfo");
        }
	}
}
