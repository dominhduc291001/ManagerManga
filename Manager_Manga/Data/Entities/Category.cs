using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager_Manga.Data.Entities
{
    public class Category
    {
        public string idCategory { get; set; }
        public string nameCategory { get; set; }
        public virtual ICollection<CategoryManga> CategoryMangas { get; set; }
    }
}
