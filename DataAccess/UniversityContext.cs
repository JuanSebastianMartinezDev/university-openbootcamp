using Microsoft.EntityFrameworkCore;
using UniversityApiBackend.Models.DataModels;

namespace UniversityApiBackend.DataAccess
{
    public class UniversityContext: DbContext   
    {
        public DbSet<User>? User { get; set; }
        public DbSet<Course>? Course { get; set; }
        public UniversityContext(DbContextOptions<UniversityContext> options): base(options)
        {

        }
    }
}
