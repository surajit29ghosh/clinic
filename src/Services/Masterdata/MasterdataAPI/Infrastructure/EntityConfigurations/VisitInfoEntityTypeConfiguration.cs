using Masterdata.API.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Masterdata.API.Infrastructure.EntityConfigurations
{
	public class VisitInfoEntityTypeConfiguration : IEntityTypeConfiguration<VisitInfo>
	{
		public void Configure(EntityTypeBuilder<VisitInfo> builder)
		{
            builder.ToTable("VisitInfo");

            builder.HasKey(e => e.VisitId);

            builder.Property(e => e.VisitId).ValueGeneratedNever();

            builder.Property(e => e.VisitDate).HasColumnType("date");

            builder.Property(e => e.VisitTime)
                .IsRequired()
                .HasMaxLength(16)
                .IsUnicode(false)
                .IsFixedLength(true);

            builder.HasOne(d => d.Doctor)
                .WithMany(p => p.Visits)
                .HasForeignKey(d => d.DoctorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VisitInfo_DoctorInfo");

            builder.HasOne(d => d.Patient)
                .WithMany(p => p.Visits)
                .HasForeignKey(d => d.PatientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VisitInfo_PatientInfo");
        }
	}
}
