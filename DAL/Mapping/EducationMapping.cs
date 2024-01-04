using DATA;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace DAL.Mapping
{
    public class EducationMapping : IEntityTypeConfiguration<Education>
    {
        public void Configure(EntityTypeBuilder<Education> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(30);
            builder.Property(x => x.Description).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Duration).IsRequired();

            // Tablolar arasındaki ilişkiler
            builder.HasMany(x => x.Classrooms).WithOne(y => y.Education).HasForeignKey(y => y.EducationID);

            builder.HasQueryFilter(f => f.IsActive);
        }
    }
}
