using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Owin.Security.Provider;
using OpenXmlPowerTools;
using System.Collections.Generic;
using ToGet_List_of_string.Models;

namespace ToGet_List_of_string.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet("studentName")]

        public ActionResult<IEnumerable<string>> Getstudents()
        {
            List<string> studentname = StudentRepository.Students.Select(x => x.studentName).ToList();


            return Ok(studentname);

        }
        [HttpGet("id:int")]
        public Student GetStudentById(int id)
        {

            return StudentRepository.Students.Where(n => n.id == id).FirstOrDefault();

        }
        [HttpGet("All")]

        public IEnumerable<Student> GetStudents()
        {

            return StudentRepository.Students.ToList();

        }
       




    } 
}

