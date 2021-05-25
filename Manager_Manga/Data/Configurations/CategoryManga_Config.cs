using Manager_Manga.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager_Manga.Data.Configurations
{
    public class CategoryManga_Config : EntityTypeConfiguration<CategoryManga>
    {
        public CategoryManga_Config()
        {
            this.ToTable("CategoryManga");

            this.HasKey(t => new {t.idCategory,t.idManga });

            this.HasRequired<Manga>(x => x.Manga)
                .WithMany(g => g.CategoryMangas)
                .HasForeignKey<string>(s => s.idManga)
                .WillCascadeOnDelete(true);

            this.HasRequired<Category>(x => x.Category)
                .WithMany(g => g.CategoryMangas)
                .HasForeignKey<string>(s => s.idCategory)
                .WillCascadeOnDelete(true);
        }
    }
}
