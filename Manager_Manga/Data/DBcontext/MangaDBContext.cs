using Manager_Manga.Data.Configurations;
using Manager_Manga.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager_Manga.Data.DBcontext
{
    public class MangaDBContext : DbContext
    {
        public MangaDBContext() : base("MangaConnection") {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MangaDBContext, Manager_Manga.Migrations.Configuration>());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Manga_Config());
            modelBuilder.Configurations.Add(new Chap_Config());
            modelBuilder.Configurations.Add(new Category_Config());
            modelBuilder.Configurations.Add(new CategoryManga_Config());
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Manga> Mangas { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryManga> MangaCategories { get; set; }
        public DbSet<Chap> Chaps { get; set; }
    }
}
