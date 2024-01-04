using DATA;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Mapping
{
    public class EducatorClassroomMapping : IEntityTypeConfiguration<EducatorClassroom>
    {
        public void Configure(EntityTypeBuilder<EducatorClassroom> builder)
        {
            builder.HasQueryFilter(f => f.IsActive);
        }
    }
}
