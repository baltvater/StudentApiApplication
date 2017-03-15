using System.Collections.Generic;
using System.Web.Http;
using StudentApiApplication.Models;

namespace StudentApiApplication.Controllers
{
    public class StudentsController : ApiController
    {
        static readonly IStudentRepository StudentRepository = new StudentRepository();

        public IEnumerable<Student> GetAll()
        {
            return StudentRepository.GetAllStudents();
        }
    }
}
