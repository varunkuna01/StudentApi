using System.Collections.Generic;
using StudentApi.Models;

namespace StudentApi.Repositories
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAll();
        Student? GetById(int id);
        void Add(Student student);
        bool Update(Student student);
        bool Delete(int id);
    }
}       