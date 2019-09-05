using System.Linq;

namespace UIPath.Models
{
    public class EFCodeRepository : ICodeRepository
    {
        private ProjectContext _context;
        public EFCodeRepository(ProjectContext context)
        {
            _context = context;
        }

        public IQueryable<Code> Codes => _context.Codes;
        public void Add(Code code)
        {
            _context.Codes.Add(code);
            _context.SaveChanges();
        }
    }
}