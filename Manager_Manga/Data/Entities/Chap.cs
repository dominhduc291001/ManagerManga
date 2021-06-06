using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager_Manga.Data.Entities
{
    public class Chap
    {
        public int id { get; set; }
        public string idManga { get; set; }
        public string nameChap { get; set; }
        public string ContentManga { get; set; }
        public virtual Manga Manga { get; set; }
    }
}
