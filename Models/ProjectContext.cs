using Microsoft.EntityFrameworkCore;

namespace UIPath.Models
{
    public class ProjectContext : DbContext
    {
        public ProjectContext(DbContextOptions<ProjectContext> options)
        : base(options)
        {

        }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Code> Codes { get; set; }
    }
}