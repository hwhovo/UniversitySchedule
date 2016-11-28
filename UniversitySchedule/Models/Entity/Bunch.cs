using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UniversitySchedule.Models.Entity
{
    public class Bunch
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, MaxLength(20)]
        public string bunchName { get; set; }

        public int? facultyId { get; set; }

        [ForeignKey("facultyId")]
        public virtual Faculty faculty { get; set; }

        public int? courseId { get; set; }

        [ForeignKey("courseId")]
        public virtual Course course { get; set; }
    }
}