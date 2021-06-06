using Manager_Manga.Data.DBcontext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager_Manga.Services
{
    public class Manga_service
    {
        private MangaDBContext db = new MangaDBContext();

        public List<string> listNameManga()
        {
            return db.Mangas.Select(x => x.name).ToList();
        }
    }
}
