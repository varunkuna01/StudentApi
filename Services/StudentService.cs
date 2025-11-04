using System.Collections.Generic;
using StudentApi.Models;
using StudentApi.Repositories;

namespace StudentApi.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _repository;

        public StudentService(IStudentRepository repository)        
        {
            _repository = repository;
        }

        public IEnumerable<Student> GetAllStudents() => _repository.GetAll();

        public Student? GetStudentById(int id) => _repository.GetById(id);

        public Student AddStudent(Student student)
        {
            _repository.Add(student);
            return student;
        }

        public bool UpdateStudent(int id, Student student)
        {
            if (id != student.Id) return false;
            return _repository.Update(student);
        }

        public bool DeleteStudent(int id) => _repository.Delete(id);
    }
}