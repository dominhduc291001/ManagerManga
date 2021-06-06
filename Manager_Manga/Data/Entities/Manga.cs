using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager_Manga.Data.Entities
{
    public class Manga
    {
        public string idManga { get; set; }
        public string name { get; set; }
        public string author { get; set; }
        public string source { get; set; }  
        public int numberChap { get; set; }
        public virtual ICollection<Chap> Chaps { get; set; }
        public virtual ICollection<CategoryManga> CategoryMangas { get; set; }
    }
}
