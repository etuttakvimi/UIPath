using System.Linq;

namespace UIPath.Models
{
    public class EFStudentRepository : IStudentRepository
    {
        private ProjectContext _context;
        public EFStudentRepository(ProjectContext context)
        {
            _context = context;
        }

        public IQueryable<Student> Students => _context.Students;

        public void Add(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }

        public bool Delete(int id)
        {
            _context.Students.Remove(_context.Students.Find(id));
            return _context.SaveChanges() > 0;
        }


    }
}