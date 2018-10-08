using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FilipMaleckiLab5.Dtos;
using System.Web.Http.Description;

namespace FilipMaleckiLab5.Controllers
{
    [RoutePrefix("api/students")]
    public class StudentsController : ApiController
    {
        /// <summary>
        /// Lista studentow
        /// </summary>
        private static readonly List<StudentDto> students;

        /// <summary>
        /// Konstruktor kontrolera
        /// </summary>
        static StudentsController()
        {
            students = new List<StudentDto>
            {
                new StudentDto { Id = 1, FirstName = "Jan", LastName = "Kowalski", City = "Wrocław"},
                new StudentDto { Id = 2, FirstName = "Maciej", LastName = "Nowak", City = "Kraków"},
                new StudentDto { Id = 3, FirstName = "Adam", LastName = "Zięba", City = "Warszawa"}
            };
        }
        /// <summary>
        /// Obsluga zdarzenia get
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route("")]
        [ResponseType(typeof(List<StudentDto>))]
        public IHttpActionResult Get()
        {
            return Ok(students);
        }
        /// <summary>
        /// Obsluga zdarzenia get dla statudenta z konkretnym id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet, Route("{id:int}", Name = "GetStudent")]
        [ResponseType(typeof(StudentDto))]
        public IHttpActionResult Get(int id)
        {
            var student = students.SingleOrDefault(x => x.Id == id);

            if(student == null)
            {
                return NotFound();
            }
            return Ok(student);
        }
        /// <summary>
        /// Obsluga zdarzenia Post. Dodaje nowego studenta
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        [HttpPost, Route("")]
        public IHttpActionResult Post([FromBody] StudentDto student)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var maxId = students.Max(x => x.Id);
            student.Id = ++maxId;

            students.Add(student);

            return CreatedAtRoute("GetStudent", new { id = student.Id }, student);
        }
        /// <summary>
        /// Obsluga zdarzenia Put. Edytuje studenta o konkretnym id
        /// </summary>
        /// <param name="student"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut, Route("{id:int}")]
        public IHttpActionResult Put([FromBody] StudentDto student, int id)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var studentToEdit = students.SingleOrDefault(x => x.Id == id);

            if (studentToEdit == null)
            {
                return NotFound();
            }

            studentToEdit.FirstName = student.FirstName;
            studentToEdit.LastName = student.LastName;
            studentToEdit.City = student.City;

            return StatusCode(HttpStatusCode.NoContent);
        }
        /// <summary>
        /// Obsluga zdarzenia Delete. Usuwa studenta o konkretnym Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete, Route("{id:int}")]
        public IHttpActionResult Delete(int id)
        {
            var student = students.SingleOrDefault(x => x.Id == id);

            if(student == null)
            {
                return NotFound();
            }

            students.Remove(student);

            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}
