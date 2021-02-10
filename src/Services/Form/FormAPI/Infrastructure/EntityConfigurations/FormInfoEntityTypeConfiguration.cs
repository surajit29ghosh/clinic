using Form.API.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Form.API.Infrastructure.EntityConfigurations
{
	public class FormInfoEntityTypeConfiguration : IEntityTypeConfiguration<FormInfo>
	{
		public void Configure(EntityTypeBuilder<FormInfo> builder)
		{
			builder.ToTable("FormInfo");

			builder.HasKey(e => e.FormId);

			builder.Property(e => e.FormId).HasDefaultValueSql("(newid())");

			builder.Property(e => e.FormName)
				.HasMaxLength(255)
				.IsUnicode(false);
		}
	}
}
