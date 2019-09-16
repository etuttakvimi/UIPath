using System;
using System.ComponentModel.DataAnnotations;

namespace UIPath.Models
{
    public class UIPathStudent
    {
        public UIPathStudent()
        {
            this.CreatedDate = DateTime.Now;
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
        public DateTime CreatedDate { get; set; }
        public int Seans { get; set; }
        public string Brans { get; set; }

        public string TCKN { get; set; }
        public string CourseStartDate { get; set; }
        public string CourseEndDate { get; set; }
        public bool IsStudent { get; set; }

        public int? GroupId { get; set; }
        public virtual Group Group { get; set; }
    }
}
