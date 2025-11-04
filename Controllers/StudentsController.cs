using Microsoft.AspNetCore.Mvc;
using StudentApi.Models;
using StudentApi.Services;
using System.Collections.Generic;

namespace StudentApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _studentService;
                
        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Student>> Get()
        {
            return Ok(_studentService.GetAllStudents());
        }

        [HttpGet("{id:int}")]
        public ActionResult<Student> GetById(int id)
        {
            var student = _studentService.GetStudentById(id);
            if (student == null) return NotFound();
            return Ok(student);
        }

        [HttpPost]
        public ActionResult<Student> Post(Student student)
        {
            _studentService.AddStudent(student);
            return CreatedAtAction(nameof(GetById), new { id = student.Id }, student);
        }

        [HttpPut("{id:int}")]
        public IActionResult Put(int id, Student student)
        {
            if (id != student.Id) return BadRequest();

            var updated = _studentService.UpdateStudent(id, student);
            if (!updated) return NotFound();

            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var deleted = _studentService.DeleteStudent(id);
            if (!deleted) return NotFound();
            return NoContent();
        }
    }
}