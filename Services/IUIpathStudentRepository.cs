using System.Linq;

namespace UIPath.Models
{
    public interface IUIpathStudentRepository
    {

        IQueryable<UIPathStudent> Students { get; }
        void Add(UIPathStudent student);
        bool Delete(int id);

        UIPathStudent GetById(int? id);

        void Update(UIPathStudent student);
    }

}