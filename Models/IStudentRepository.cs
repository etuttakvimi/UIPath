using System.Linq;

namespace UIPath.Models
{
    public interface IStudentRepository
    {
        IQueryable<Student> Students { get; }
        void Add(Student student);
    } 
}