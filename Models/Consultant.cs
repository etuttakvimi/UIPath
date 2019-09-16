using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UIPath.Models
{
    public class Consultant
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Lütfen ismim giriniz!")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Lütfen soyisim giriniz!")]
        public string LastName { get; set; }


        [NotMapped]
        public string FullName
        {
            get
            {
                return this.FirstName + " " + this.LastName;
            }
        }

        public virtual ICollection<Group> Groups { get; set; }
    }
}