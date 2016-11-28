using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UniversitySchedule.Models.Entity.Schedule
{
    public class LessonItem
    {
        [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(20)]
        public String Subject { get; set; }

        [MaxLength(20)]
        public String Room { get; set; }

        [MaxLength(20)]
        public String Time { get; set; }

        public int? LessonId { get; set; }
        public virtual Lesson lesson { get; set; }
    }
}