using System.ComponentModel.DataAnnotations;

namespace UIPath.Models
{
    public class Code
    {
        public int Id { get; set; }
        [Required]
        public string LoginCode { get; set; }
    }
}