using StudentApi.Models;
using System.Collections.Generic;

namespace StudentApi.Services
{
    public interface IStudentService
    {
        IEnumerable<Student> GetAllStudents();
        void AddStudent(Student student);
    }
}