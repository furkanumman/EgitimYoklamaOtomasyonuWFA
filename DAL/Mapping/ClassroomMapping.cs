using DATA;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Mapping
{
    public class ClassroomMapping : IEntityTypeConfiguration<Classroom>
    {
        public void Configure(EntityTypeBuilder<Classroom> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).HasMaxLength(15);
            builder.Property(x => x.EducationStartDate).HasColumnType("datetime2").IsRequired();
            builder.Property(x => x.EducationFinishDate).HasColumnType("datetime2").IsRequired();
            builder.Property(x => x.EducationStartTime).IsRequired();
            builder.Property(x => x.EducationFinishTime).IsRequired();
            builder.Property(x => x.DailyEducationHour).IsRequired();

            //Tablo ilişkileri
            builder.HasMany(x => x.Students).WithOne(y => y.Classroom);
            builder.HasMany(x => x.Educators).WithMany(y => y.Classrooms);

            builder.HasQueryFilter(f => f.IsActive);
        }
    }
}
