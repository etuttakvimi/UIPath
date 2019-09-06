using System.ComponentModel.DataAnnotations;
using System;

namespace UIPath.Models
{
    public class Student
    {
        public Student()
        {
            this.StartDate = DateTime.Now;
        }
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Must be a valid Email Address")]
        public string Mail { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Code { get; set; }
        public DateTime StartDate { get; set; }
    }
}