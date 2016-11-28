using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UniversitySchedule.Models.Entity.Content
{
    public class ErrorMessage
    {
        [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(20)]
        public string Name { get; set; }

        public string Message { get; set; }

        public int? LanguageId { get; set; }

        [ForeignKey("LanguaeId")]
        public virtual Language Language { get; set; }
    }
}