using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UniversitySchedule.Models.Entity
{
    public class Faculty
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required, MaxLength(20)]
        public string FacultyName { get; set; }

        public int? UniversityId { get; set; }

        [ForeignKey("universityId")]
        public virtual University university {get;set;}

        public ICollection<Course> courses { get; set; }
        public ICollection<Bunch> bunches { get; set; }

        public Faculty()
        {
            bunches = new List<Bunch>();
            courses = new List<Course>();
        }
    }
}