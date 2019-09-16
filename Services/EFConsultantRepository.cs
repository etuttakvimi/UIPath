using System.Linq;
using UIPath.Models;
using UIPath.Models.Context;

namespace UIPath.Services
{
    public class EFConsultantRepository : IConsultanRepository
    {

        private ProjectContext _context;
        public EFConsultantRepository(ProjectContext context)
        {
            _context = context;
        }

        public IQueryable<Consultant> Consultants => _context.Consultants;

        public void Add(Consultant consultant)
        {
            _context.Consultants.Add(consultant);
            _context.SaveChanges();
        }

        public bool Delete(int id)
        {
            _context.Consultants.Remove(_context.Consultants.Find(id));
            return _context.SaveChanges() > 0;
        }

        public Consultant GetById(int? id)
        {
            return _context.Consultants.Find(id);
        }

        public void Update(Consultant consultant)
        {
            _context.Entry(consultant).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}