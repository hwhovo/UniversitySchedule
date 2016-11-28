using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UniversitySchedule.Models.Entity.Content
{
    public class Language
    {
        [Required,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string DisplayText { get; set; }

        public ICollection<Weekday> Weekdays { get; set; }
        public ICollection<PostText> PostTexts { get; set; }
        public ICollection<MenuItem> MenuItems { get; set; }
        public ICollection<ErrorMessage> ErrorMessages { get; set; }

        public Language()
        {
            Weekdays = new List<Weekday>();
            PostTexts = new List<PostText>();
            MenuItems = new List<MenuItem>();
            ErrorMessages = new List<ErrorMessage>();
        }
    }
}