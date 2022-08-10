using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoAPI.IRepository;
using ToDoAPI.Model;
using ToDoAPI.ModelDto;

namespace ToDoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IGenericRepository<Student> _repository;
        private readonly IMapper _map;

        public StudentsController(IGenericRepository<Student> repository, IMapper mapper)
        {
            _repository = repository;
            _map = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> Students()
        {
            var student = await _repository.GetStudents();
            return Ok(student);
        }
        [HttpGet("{id:int}", Name = "Student")]
        public async Task<IActionResult> Student(int id)
        {
            var student = await _repository.GetStudent(id);
            return Ok(student);

        }
        [HttpPost]
        public async Task<IActionResult> AddStudent([FromBody] StudentDto studentdto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var student = _map.Map<Student>(studentdto);
            _repository.Add(student);
            await _repository.SaveAll();
            return Ok();
        }
        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateStudent(int id, StudentDto studentdto)
        {
            if (!ModelState.IsValid || id < 1)
            {
                return BadRequest(ModelState);
            }
            var studentId = await _repository.GetStudent(id);
            if (studentId == null)
            {
                return BadRequest();
            }
            _map.Map(studentdto, studentId);
            _repository.Update(studentId);
            await _repository.SaveAll();
            return NoContent();

        }
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            if (id < 1)
                return BadRequest("Student Not found");
            var student = await _repository.GetStudent(id);
            if (student == null)
            {
                return BadRequest("Failed to delete");
            }
            _repository.Delete(id);
            await _repository.SaveAll();
            return NoContent();
        }
    }
}
