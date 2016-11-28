using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UniversitySchedule.Models.Entity
{
    public class Course
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public int CourseNumber { get; set; }

        public ICollection<Faculty> faculties { get; set; }
        public ICollection<Bunch> bunches { get; set; }


        public Course()
        {
            faculties = new List<Faculty>();
            bunches = new List<Bunch>();
        }

    }
}