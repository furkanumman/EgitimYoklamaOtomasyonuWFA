using DATA;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Mapping
{
    public class AttendanceMapping : IEntityTypeConfiguration<Attendance>
    {
        public void Configure(EntityTypeBuilder<Attendance> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Date).IsRequired();
            builder.Property(x => x.StudentID).IsRequired();
        }
    }
}
