using System;
using System.Collections.Generic;

namespace StudentApiApplication.Models
{
    public class StudentRepository : IStudentRepository
    {
        private readonly List<Student> _items = new List<Student>();
        private int _next = 1;

        public StudentRepository()
        {
            AddStudent(new Student { Id = 1, Name = "Ashish", City = "New Delhi", Course = "B.Tech" });
            AddStudent(new Student { Id = 2, Name = "Nimit", City = "Noida", Course = "MCA" });
            AddStudent(new Student { Id = 3, Name = "Prawah", City = "Dehradun", Course = "B.Tech" });
            AddStudent(new Student { Id = 4, Name = "Sumit", City = "Nainital", Course = "MCA" });
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _items;
        }

        public Student AddStudent(Student student)
        {
            if (_items == null)
            {
                throw new ArgumentNullException(nameof(student));
            }

            student.Id = _next++;
            _items.Add(student);
            return student;
        }
    }
}