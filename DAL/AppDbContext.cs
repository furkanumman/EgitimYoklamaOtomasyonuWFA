using DAL.Mapping;
using DATA;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class AppDbContext : DbContext
    {
        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<Coordinator> Coordinators { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Educator> Educators { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<EducatorClassroom> EducatorsClassrooms { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source =.\sqlexpress; Initial Catalog = EgitimYoklamaOtomasyonu; Integrated Security = true; TrustServerCertificate=true");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new AdministratorMapping().Configure(modelBuilder.Entity<Administrator>());
            new AttendanceMapping().Configure(modelBuilder.Entity<Attendance>());
            new BranchMapping().Configure(modelBuilder.Entity<Branch>());
            new ClassroomMapping().Configure(modelBuilder.Entity<Classroom>());
            new CoordinatorMapping().Configure(modelBuilder.Entity<Coordinator>());
            new EducationMapping().Configure(modelBuilder.Entity<Education>());
            new EducatorMapping().Configure(modelBuilder.Entity<Educator>());
            new StudentMapping().Configure(modelBuilder.Entity<Student>());
            new EducatorClassroomMapping().Configure(modelBuilder.Entity<EducatorClassroom>());

            base.OnModelCreating(modelBuilder);
        }
    }
}
