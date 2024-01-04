using DATA;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace DAL.Mapping
{
    public class StudentMapping : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(30);
            builder.Property(x => x.Surname).IsRequired().HasMaxLength(30);
            builder.Property(x => x.Phone).IsRequired().HasMaxLength(20);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(50);
            builder.Property(x => x.DateofBirth).IsRequired().HasColumnType("datetime2");

            //Tablo İlişkileri
            builder.HasMany(x => x.Attendances).WithOne(y => y.Student).HasForeignKey(y => y.StudentID);

            builder.HasQueryFilter(f => f.IsActive);
        }
    }
}
