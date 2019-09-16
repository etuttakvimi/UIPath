using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UIPath.Models
{
    public class Group
    {
        public Group()
        {
            this.Statu = Status.Waiting;
        }
        public int Id { get; set; }
        public Status Statu { get; set; }
        public string LabName { get; set; }
        [Required(ErrorMessage = "Lütfen Grup adı giriniz!")]
        public string GroupName { get; set; }
        public string EndDate { get; set; }
        public string StartDate { get; set; }


        public int? ConsultantId { get; set; }
        public virtual Consultant Consultant { get; set; }
        public virtual ICollection<UIPathStudent> Students { get; set; }
    }
}