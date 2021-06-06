using Manager_Manga.Data.DBcontext;
using Manager_Manga.Data.Entities;
using Manager_Manga.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager_Manga.Views
{
    public partial class addChap : Form
    {
        private MangaDBContext db = new MangaDBContext();
        private All_Service sv = new All_Service();
        public addChap()
        {
            InitializeComponent();
        }

        public addChap(string nameManga):this()
        {
            lbNameManga.Text = nameManga;
        }

        private void addChap_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Chap newChap = new Chap();
            var myManga = db.Mangas.Where(s => s.name == lbNameManga.Text).FirstOrDefault();
            newChap.idManga = myManga.idManga;
            newChap.nameChap = tbNameChap.Text;
            newChap.ContentManga = rtbContentChap.Text;
            Manga manga = db.Mangas.Find(myManga.idManga);
            manga.numberChap += 1;
            db.Chaps.Add(newChap);
            db.SaveChanges();
            MessageBox.Show("Thêm thành công");
            this.Close();
        }

    }
}
