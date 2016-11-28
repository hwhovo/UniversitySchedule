using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UniversitySchedule.Models.Entity.Schedule
{
    public class Lesson
    {
        [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Weekday { get; set; }
        public bool Numerator { get; set; }

        public int? BunchId { get; set; }

        [ForeignKey("BunchId")]
        public virtual Bunch bunch { get; set; }

        public ICollection<LessonItem> lessonItems;

        public Lesson()
        {
            lessonItems = new List<LessonItem>();
        }
    }
}