using CRUDExample.Models;
using CRUDExample.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CRUDExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        StudentDataAccessLayer studentDataAccessLayer = null;
        public StudentController()
        {
            studentDataAccessLayer = new StudentDataAccessLayer();
        }

        // GET: api/<StudentController>
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            IEnumerable<Student> students = studentDataAccessLayer.GetAllStudent();
            return students;
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public Student Get(int id)
        {
            Student student = studentDataAccessLayer.GetStudentData(id);
            return student;
        }

        // POST api/<StudentController>
        [HttpPost]
        public void Post(Student student)
        {
            try
            {
                studentDataAccessLayer.AddStudent(student);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);  
            }
        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            studentDataAccessLayer.DeleteStudent(id);
        }
    }
}
