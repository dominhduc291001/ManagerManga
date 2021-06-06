using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager_Manga.Services
{
    public class All_Service
    {
        public CategoryManga_service svCategoryManga = new CategoryManga_service();
        public Manga_service svManga = new Manga_service();
        public Chap_service svChap = new Chap_service();
    }
}
