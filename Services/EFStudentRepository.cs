using System.Linq;
using UIPath.Models.Context;

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

        public Student GetById(int? id)
        {
            return _context.Students.Find(id);
        }
    }
}