using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UniversitySchedule.Models.Entity.Content
{
    public class MenuItem
    {
        [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Header { get; set; }  // заголовок меню
        public string Url { get; set; } // адрес ссылки
        public int MenuType { get; set; } // header menu or left panel menu
        public int? Order { get; set; }  // порядок следования пункта в подменю
        public int? ParentId { get; set; }  // ссылка на id родительского меню
        public MenuItem Parent { get; set; }    // родительское меню

        public ICollection<MenuItem> Children { get; set; }   // дочерние пункты меню
        public MenuItem()
        {
            Children = new List<MenuItem>();
        }

        public int? LanguageId { get; set; }

        [ForeignKey("LanguaeId")]
        public virtual Language Language { get; set; }
    }
}