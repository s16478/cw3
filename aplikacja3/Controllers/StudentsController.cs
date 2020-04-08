using System;
using aplikacja3.DAL;
using aplikacja3.Models;
using Microsoft.AspNetCore.Mvc;


namespace aplikacja3.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentsController : ControllerBase
    {
        private readonly IDbService _dbService;

        public StudentsController(IDbService dbService)
        {
            _dbService = dbService;
        }

        [HttpGet]
        public IActionResult GetStudent(string orderBy)
        {
            return Ok(_dbService.GetStudent());
        }

        [HttpGet("{id}")]
      
        public IActionResult GetStudent(int id)
        {
            if (id == 1)
            {
                return Ok("Kowalski");
            }
            else if (id == 2) {
                return Ok("Malewski");
            }
            return NotFound("Student not found");
        }

        [HttpPost]
        public IActionResult CreateStudent(Student student)
        {
            // add to database
            // generating index number
            student.IndexNumber = $"s{new Random().Next(1, 20000)}";
            return Ok(student);
        }

        // moje metody

        [HttpPut("{id}")]

        public IActionResult PutStudent(int id)
        {
      
            return Ok("Update successful");
        }


        [HttpDelete("{id}")]

        public IActionResult DeleteStudent(int id)
        {
            
            return Ok("Student deleted");
        }
    }
}