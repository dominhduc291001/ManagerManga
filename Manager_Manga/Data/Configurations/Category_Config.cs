using Manager_Manga.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager_Manga.Data.Configurations
{
    public class Category_Config : EntityTypeConfiguration<Category>
    {
        public Category_Config()
        {
            this.ToTable("Category");

            this.HasKey(x => x.idCategory);

            this.Property(x => x.nameCategory)
                .HasMaxLength(50)
                .IsRequired();

        }
    }
}
