using System.Linq;

namespace UIPath.Models
{
    public class EFUIpathStudentRepository : IUIpathStudentRepository
    {

        private ProjectContext _context;
        public EFUIpathStudentRepository(ProjectContext context)
        {
            _context = context;
        }

        public IQueryable<UIPathStudent> Students => _context.UIPathStudents;

        public void Add(UIPathStudent student)
        {
            _context.UIPathStudents.Add(student);
            _context.SaveChanges();
        }

        public bool Delete(int id)
        {
            _context.UIPathStudents.Remove(_context.UIPathStudents.Find(id));
            return _context.SaveChanges() > 0;
        } 
    }
}