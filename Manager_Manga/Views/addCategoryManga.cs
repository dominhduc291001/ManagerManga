using Manager_Manga.Data.DBcontext;
using Manager_Manga.Data.Entities;
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
    public partial class addCategoryManga : Form
    {
        private MangaDBContext db = new MangaDBContext();
        public addCategoryManga()
        {
            InitializeComponent();
        }
        public addCategoryManga(string _nameManga) : this()
        {
            lbNameManga.Text = _nameManga;
        }

        private void addCategoryManga_Load(object sender, EventArgs e)
        {
            var listCategory = db.Categories.ToList();
            foreach(var item in listCategory)
            {
                cbCategory.Items.Add(item.nameCategory);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var _MyManga = db.Mangas.Where(x => x.name == lbNameManga.Text).FirstOrDefault();
            var _MyCategory = db.Categories.Where(s => s.nameCategory == cbCategory.Text).FirstOrDefault();
            CategoryManga newCT = new CategoryManga();
            newCT.idCategory = _MyCategory.idCategory;
            newCT.idManga = _MyManga.idManga;
            db.MangaCategories.Add(newCT);
            db.SaveChanges();
            MessageBox.Show("Thêm thành công!!!");
            this.Close();
        }
    }
}
