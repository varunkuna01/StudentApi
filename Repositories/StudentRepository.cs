using Microsoft.EntityFrameworkCore;
using StudentApi.Data;
using StudentApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace StudentApi.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly AppDbContext _context;

        public StudentRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Student> GetAll()
        {
            return _context.Students.AsNoTracking().ToList();
        }

        public Student? GetById(int id)
        {
            return _context.Students
                .AsNoTracking()
                .FirstOrDefault(s => s.Id == id);
        }

        public void Add(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }

        public bool Update(Student student)
        {
            var existing = _context.Students.Find(student.Id);
            if (existing == null) return false;

            // Update fields explicitly
            existing.Name = student.Name;
            existing.Age = student.Age;
            existing.Email = student.Email;
            existing.Course = student.Course;

            _context.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            var student = _context.Students.Find(id);
            if (student == null) return false;

            _context.Students.Remove(student);
            _context.SaveChanges();
            return true;
        }
    }
}