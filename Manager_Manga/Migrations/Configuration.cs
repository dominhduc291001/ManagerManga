namespace Manager_Manga.Migrations
{
    using Manager_Manga.Data.Entities;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Manager_Manga.Data.DBcontext.MangaDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Manager_Manga.Data.DBcontext.MangaDBContext context)
        {
            IList<Category> defaultCategory = new List<Category>();
            defaultCategory.Add(new Category() { idCategory = "KIEMHIEP", nameCategory = "Kiếm hiệp" });
            defaultCategory.Add(new Category() { idCategory = "NGONTINH", nameCategory = "Ngôn tình" });
            defaultCategory.Add(new Category() { idCategory = "TIENHIEP", nameCategory = "Tiên hiệp" });
            defaultCategory.Add(new Category() { idCategory = "DAMMY", nameCategory = "Đam mỹ" });
            defaultCategory.Add(new Category() { idCategory = "KINHDI", nameCategory = "Kinh dị" });
            defaultCategory.Add(new Category() { idCategory = "TEEN", nameCategory = "Truyện teen" });
            defaultCategory.Add(new Category() { idCategory = "XUYENKHONG", nameCategory = "Xuyên không" });
            defaultCategory.Add(new Category() { idCategory = "DIGIOI", nameCategory = "Dị giới" });
            defaultCategory.Add(new Category() { idCategory = "TRINHTHAM", nameCategory = "Trinh thám" });
            context.Categories.AddRange(defaultCategory);
            base.Seed(context);
        }
    }
}
