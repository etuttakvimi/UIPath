using System.Linq;
using UIPath.Models;

namespace UIPath.Services
{
    public interface IGroupRepository
    {
        IQueryable<Group> Groups { get; }
        void Add(Group group);
        Group GetById(int? id);
        bool Delete(int id);
        void Update(Group group);
    }
}