using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UniversitySchedule.Models.Entity
{
    public class University
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, MaxLength(20)]
        public string UniversityName { get; set; }

        public ICollection<Faculty> Faculties { get; set; }

        public University()
        {
            Faculties = new List<Faculty>();
        }
    }
}