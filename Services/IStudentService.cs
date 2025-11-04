using System.Collections.Generic;
using StudentApi.Models;

namespace StudentApi.Services
{
    public interface IStudentService
    {
        IEnumerable<Student> GetAllStudents();
        Student? GetStudentById(int id);
        Student AddStudent(Student student);
        bool UpdateStudent(int id, Student student);
        bool DeleteStudent(int id);
    }
}