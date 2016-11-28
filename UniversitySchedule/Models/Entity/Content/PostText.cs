using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UniversitySchedule.Models.Entity.Content
{
    public class PostText
    {
        [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Index]
        [MaxLength(20)]
        public string Name { get; set; }
        public string Content { get; set; }
        public string Description { get; set; }

        public int? LanguaeId { get; set; }

        [ForeignKey("LanguaeId")]
        public virtual Language language { get; set; }
    }
}