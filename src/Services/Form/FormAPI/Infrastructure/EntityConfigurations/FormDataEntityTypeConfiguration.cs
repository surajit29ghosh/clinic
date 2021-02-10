using Form.API.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Form.API.Infrastructure.EntityConfigurations
{
	public class FormDataEntityTypeConfiguration : IEntityTypeConfiguration<FormData>
	{
		public void Configure(EntityTypeBuilder<FormData> builder)
		{
			builder.HasKey(e => e.DetailsId);

			builder.Property(e => e.DetailsId).HasDefaultValueSql("(newid())");

			builder.HasOne(d => d.Form)
				.WithMany(p => p.FormData)
				.HasForeignKey(d => d.FormId)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_FormData_FormInfo");
		}
	}
}
