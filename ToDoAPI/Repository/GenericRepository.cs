using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoAPI.Data;
using ToDoAPI.IRepository;
using ToDoAPI.Model;

namespace ToDoAPI.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly AppDbContext _cxt;

        public GenericRepository(AppDbContext context)
        {
            _cxt = context;
        }

        public void Add(T entity)
        {
            _cxt.Add(entity);
        }

        public void Delete(int id)
        {
            var student = _cxt.Students.Find(id);
            if (student != null)
                _cxt.Students.Remove(student);
        }

        public async Task<Student> GetStudent(int id)
        {
            return await _cxt.Students.FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task<IEnumerable<Student>> GetStudents()
        {
            return await _cxt.Students.ToListAsync();
        }

        public async Task<bool> SaveAll()
        {
            return await _cxt.SaveChangesAsync() > 0;
        }

        public void Update(T entity)
        {
            _cxt.Entry(entity).State = EntityState.Modified;
        }
    }
}
