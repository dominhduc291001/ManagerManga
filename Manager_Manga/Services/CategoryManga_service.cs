using Manager_Manga.Data.DBcontext;
using Manager_Manga.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager_Manga.Services
{
    public class CategoryManga_service
    {
        private MangaDBContext _context = new MangaDBContext();
        public List<Category> CategoryOfManga(string _idManga)
        {
            return _context.MangaCategories
                .Where(m => m.idManga == _idManga)
                .Select(s => s.Category)
                .ToList();
        }
    }
}
