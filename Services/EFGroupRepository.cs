using System.Linq;
using UIPath.Models;
using UIPath.Models.Context;

namespace UIPath.Services
{
    public class EFGroupRepository : IGroupRepository
    {

        private ProjectContext _context;
        public EFGroupRepository(ProjectContext context)
        {
            _context = context;
        }
        public IQueryable<Group> Groups => _context.Groups;

        public void Add(Group group)
        {
            _context.Groups.Add(group);
            _context.SaveChanges();
        }

        public bool Delete(int id)
        {
            _context.Groups.Remove(_context.Groups.Find(id));
            return _context.SaveChanges() > 0;
        }

        public Group GetById(int? id) => _context.Groups.Find(id);
        public void Update(Group group)
        {
            _context.Entry(group).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}