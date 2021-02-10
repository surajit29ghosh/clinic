using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Visit.API.Model;

namespace Visit.API.Infrastructure.EntityConfigurations
{
	public class VisitInfoEntityTypeConfiguration : IEntityTypeConfiguration<VisitInfo>
	{
		public void Configure(EntityTypeBuilder<VisitInfo> builder)
		{
			//builder.HasNoKey();

			builder.ToTable("VisitInfo");

			builder.HasKey(k => k.VisitId);

			builder.Property(e => e.VisitDate).HasColumnType("date");

			builder.Property(e => e.VisitTime)
				.IsRequired()
				.HasMaxLength(16)
				.IsUnicode(false)
				.IsFixedLength(true);
		}
	}
}
