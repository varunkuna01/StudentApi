using StudentApi.Models;
using System.Collections.Generic;

namespace StudentApi.Repositories
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAll();
        void Add(Student student);
    }
}