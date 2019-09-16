using System.Linq;
using UIPath.Models;

namespace UIPath.Services
{
    public interface IConsultanRepository
    {
        IQueryable<Consultant> Consultants { get; }
        void Add(Consultant consultant);
        Consultant GetById(int? id);
        bool Delete(int id);

        void Update(Consultant consultant);
    }
}