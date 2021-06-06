using Manager_Manga.Data.DBcontext;
using Manager_Manga.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager_Manga.Services
{
    public class Chap_service
    {
        private MangaDBContext db = new MangaDBContext();
        public Chap getFirtChap(string id)
        {
            return db.Chaps.Where(s => s.idManga == id).FirstOrDefault();
        }
        public List<Chap> listChap(string name)
        {
            var manga = db.Mangas.Where(s => s.name == name).FirstOrDefault();
            return db.Chaps.Where( s =>  s.idManga == manga.idManga).ToList();
        }
    }
}
