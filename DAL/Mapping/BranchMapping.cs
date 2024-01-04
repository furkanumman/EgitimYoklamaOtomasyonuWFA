using DATA;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Mapping
{
    public class BranchMapping : IEntityTypeConfiguration<Branch>
    {
        public void Configure(EntityTypeBuilder<Branch> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Name).HasColumnType("nvarchar").HasMaxLength(20).IsRequired();
            builder.Property(x => x.Mail).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Phone).HasMaxLength(20).IsRequired();
            builder.Property(x => x.Adress).HasColumnType("nvarchar").HasMaxLength(140).IsRequired();

            // Tablo ilişkilerini tamamladık.
            builder.HasMany(x => x.Classrooms).WithOne(y => y.Branch).HasForeignKey(y => y.BranchID);
            builder.HasMany(x => x.Coordinators).WithOne(y => y.Branch).HasForeignKey(y => y.BranchID).IsRequired(false);
            builder.HasMany(x => x.Educators).WithOne(y => y.Branch).HasForeignKey(y => y.BranchID).IsRequired(true); ;

            builder.HasQueryFilter(f => f.IsActive);
        }
    }
}
