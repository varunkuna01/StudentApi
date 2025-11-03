using StudentApi.Models;
using System.Collections.Generic;

namespace StudentApi.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly List<Student> _students = new();

        public IEnumerable<Student> GetAll()
        {
            return _students;
        }

        public void Add(Student student)
        {
            student.Id = _students.Count + 1;
            _students.Add(student);
        }
    }
}