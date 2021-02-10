using Masterdata.API.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Masterdata.API.Infrastructure.EntityConfigurations
{
	public class PatientInfoEntityTypeConfiguration : IEntityTypeConfiguration<PatientInfo>
	{
		public void Configure(EntityTypeBuilder<PatientInfo> builder)
		{
            builder.ToTable("PatientInfo");

            builder.HasKey(e => e.PatientId)
                    .HasName("PK_PatientMaster");

            builder.Property(e => e.PatientId).ValueGeneratedNever();

            builder.Property(e => e.PatientEmail).HasMaxLength(100);

            builder.Property(e => e.PatientGender)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength(true);

            builder.Property(e => e.PatientName).HasMaxLength(50);

            builder.Property(e => e.PatientPhone)
                .HasMaxLength(10)
                .IsFixedLength(true);
        }
	}
}
