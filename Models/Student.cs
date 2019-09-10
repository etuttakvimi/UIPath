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
        [Required(ErrorMessage = "Lütfen adınızı giriniz!")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Lütfen soyadınızı giriniz!")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Lütfen mail adresinizi giriniz!")]
        [EmailAddress]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Geçerli bir mail giriniz!")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Lütfen telefon numaranızı giriniz!")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Lütfen size verilen kodu giriniz!")]
        public string Code { get; set; }
        public DateTime StartDate { get; set; }
  
        public string TCKN { get; set; }
    }
}