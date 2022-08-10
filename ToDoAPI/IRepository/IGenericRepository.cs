using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoAPI.Model;

namespace ToDoAPI.IRepository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<Student>> GetStudents();
        Task<Student> GetStudent(int id);
        void Add(T entity);
        void Delete(int id);
        void Update(T entity);
        Task<bool> SaveAll();
    }
}
