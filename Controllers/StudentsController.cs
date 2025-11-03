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

        [HttpPost]
        public ActionResult Post(Student student)
        {
            _studentService.AddStudent(student);
            return Ok(student);
        }
    }
}