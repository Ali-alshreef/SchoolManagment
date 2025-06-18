using Microsoft.EntityFrameworkCore;
using SchoolManagment.Models;
namespace SchoolManagment.Data
{
    public class DBSchool : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string cn =
         "server=ALI-ALSHAREEF;database=SchoolDB;user id=sa;password=123;Trusted_Connection=true;Encrypt=false";
            base.OnConfiguring(optionsBuilder);
            optionsBuilder
            .UseSqlServer(cn);
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Subject> Subjects { get; set; }
    }
}
