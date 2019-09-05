using System.Linq;

namespace UIPath.Models
{
   public interface ICodeRepository
    {
        IQueryable<Code> Codes { get; }
        void Add(Code code);
    }
}