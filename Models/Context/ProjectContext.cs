using Microsoft.EntityFrameworkCore;

namespace UIPath.Models.Context
{
    public class ProjectContext : DbContext
    {
        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options) { }

        public virtual DbSet<Code> Codes { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Consultant> Consultants { get; set; }
        public virtual DbSet<UIPathStudent> UIPathStudents { get; set; }
    }
}