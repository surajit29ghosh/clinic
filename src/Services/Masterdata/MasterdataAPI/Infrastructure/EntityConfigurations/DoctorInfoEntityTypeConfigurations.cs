using Masterdata.API.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Masterdata.API.Infrastructure.EntityConfigurations
{
	public class DoctorInfoEntityTypeConfiguration : IEntityTypeConfiguration<DoctorInfo>
	{
		public void Configure(EntityTypeBuilder<DoctorInfo> builder)
		{
            builder.ToTable("DoctorInfo");

            builder.HasKey(e => e.DoctorId)
                    .HasName("PK_DoctorMaster");

            builder.Property(e => e.DoctorId).ValueGeneratedNever();

            builder.Property(e => e.DoctorEmail).HasMaxLength(100);

            builder.Property(e => e.DoctorName).HasMaxLength(50);

            builder.Property(e => e.DoctorPhone)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength(true);
        }
	}
}
