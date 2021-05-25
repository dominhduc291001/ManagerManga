using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager_Manga.Data.Entities
{
    public class CategoryManga
    {
        public string idManga { get; set; }
        public string idCategory { get; set; }
        public virtual Category Category { get; set; }
        public virtual Manga Manga { get; set; }

    }
}
