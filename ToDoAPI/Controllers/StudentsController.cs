using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoAPI.IRepository;
using ToDoAPI.Model;

namespace ToDoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IGenericRepository<Student> _repository;

        public StudentsController(IGenericRepository<Student> repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<IActionResult> Students()
        {
            var student = await _repository.GetStudents();
            return Ok(student);
        }
    }
}
