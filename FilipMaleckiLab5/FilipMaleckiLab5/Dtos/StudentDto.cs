using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FilipMaleckiLab5.Dtos
{
    public class StudentDto
    {
        /// <summary>
        /// Id studenta
        /// </summary>
        public int Id { get; set; } 
        /// <summary>
        /// Imie studenta
        /// </summary>
        [Required]
        public string FirstName { get; set; }
        /// <summary>
        /// Nazwisko studenta
        /// </summary>
        [Required]
        public string LastName { get; set; }
        /// <summary>
        /// Miasto z ktorego pochodzi student
        /// </summary>
        public string City { get; set; }
    }
}