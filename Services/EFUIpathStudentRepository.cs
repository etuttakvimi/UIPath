using System.Linq;
using UIPath.Models.Context;

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

        public UIPathStudent GetById(int? id)
        {
            return _context.UIPathStudents.Find(id);
        }

        public void Update(UIPathStudent student)
        {
            _context.Entry(student).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}