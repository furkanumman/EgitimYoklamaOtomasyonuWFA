using DATA;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace DAL.Mapping
{
    public class EducatorMapping : IEntityTypeConfiguration<Educator>
    {
        public void Configure(EntityTypeBuilder<Educator> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(30);
            builder.Property(x => x.Surname).IsRequired().HasMaxLength(30);
            builder.Property(x => x.Phone).IsRequired().HasMaxLength(20);
            builder.Property(x => x.Role).IsRequired();
            builder.Property(x => x.Email).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Password).IsRequired().HasMaxLength(30);
            builder.Property(x => x.DateofBirth).IsRequired();

            builder.HasQueryFilter(f => f.IsActive);

            // ilişkiler, ilişkili tablolarda belirtildi.
            // - Branch
            // - Classroom tablolarında
        }
    }
}
