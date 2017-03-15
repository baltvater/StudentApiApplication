using System.Collections.Generic;

namespace StudentApiApplication.Models
{
    internal interface IStudentRepository
    {
        IEnumerable<Student> GetAllStudents();
        Student AddStudent(Student student);
    }
}