using Manager_Manga.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager_Manga.Data.Configurations
{
    public class Chap_Config : EntityTypeConfiguration<Chap>
    {
        public Chap_Config()
        {
            this.ToTable("Chap");

            this.HasKey(x => x.id);

            this.HasRequired<Manga>(x => x.Manga)
                .WithMany(g => g.Chaps)
                .HasForeignKey<string>(s => s.idManga);
        }
    }
}
