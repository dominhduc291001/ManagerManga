using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using Manager_Manga.Data.Entities;

namespace Manager_Manga.Data.Configurations
{
    public class Manga_Config : EntityTypeConfiguration<Manga>
    {
        public Manga_Config()
        {
            this.ToTable("Manga");

            this.HasKey(x => x.idManga);

            this.Property(x => x.name)
                .HasMaxLength(80)
                .IsRequired();

            this.Property(x => x.author)
                .HasMaxLength(30);

            this.HasMany<Chap>(g => g.Chaps)
                .WithRequired(s => s.Manga)
                .WillCascadeOnDelete();
        }
    }
}
