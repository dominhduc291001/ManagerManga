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
    public partial class addCategory : Form
    {
        private MangaDBContext db = new MangaDBContext();
        public addCategory()
        {
            InitializeComponent();
        }

        private void addCategory_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Category newCate = new Category();
            newCate.idCategory = tbID.Text;
            newCate.nameCategory = tbName.Text;
            db.Categories.Add(newCate);
            db.SaveChanges();
            MessageBox.Show("Thêm thành công !!!");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
