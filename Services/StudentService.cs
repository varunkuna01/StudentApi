using StudentApi.Models;
using StudentApi.Repositories;
using System.Collections.Generic;

namespace StudentApi.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _repository;

        public StudentService(IStudentRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _repository.GetAll();
        }

        public void AddStudent(Student student)
        {
            _repository.Add(student);
        }
    }
}