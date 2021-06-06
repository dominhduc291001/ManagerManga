using Manager_Manga.Data.DBcontext;
using Manager_Manga.Data.Entities;
using Manager_Manga.Services;
using Manager_Manga.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager_Manga
{
    public partial class FormMain : Form
    {
        private MangaDBContext db = new MangaDBContext();
        private All_Service sv = new All_Service();
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            db.Categories.Load();
            db.Mangas.Load();
            dgvManga.DataSource = db.Mangas.Local.ToBindingList();
            dgvManga.Columns.Remove("Chaps");
            dgvManga.Columns.Remove("CategoryMangas");
            changeNameManga();
            addBtnDeleteManga();        
            dgvManga.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            constructerChap();
            constructerCategory();
            constructerCategoryManga();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            db.Dispose();
        }
        private void addBtnDeleteManga()
        {
            var deleteManga = new DataGridViewButtonColumn();
            deleteManga.Name = "dgvDeleteManga";
            deleteManga.HeaderText = "";
            deleteManga.Text = "Xoá";
            deleteManga.UseColumnTextForButtonValue = true;
            dgvManga.Columns.Add(deleteManga);
        }

        private void constructerChap()
        {
            cbListManga.Text = db.Mangas.FirstOrDefault().name;
            var defaultChap = sv.svChap.getFirtChap(db.Mangas.FirstOrDefault().idManga);
            updateContentChap(defaultChap.id);       
            foreach(string item in sv.svManga.listNameManga())
            {
                cbListManga.Items.Add(item);
            }
            updateListChap();
            dgvChap.AutoGenerateColumns = false;
            dgvChap.Columns.Remove("idManga");
            dgvChap.Columns.Remove("ContentManga");
            dgvChap.Columns.Remove("Manga");
            dgvChap.Columns.Remove("id");
            dgvChap.Columns[0].HeaderText = "Tên chap";
            btnDeleteChap();
        }
        private void btnDeleteChap() {
            var deleteChap = new DataGridViewButtonColumn();
            deleteChap.Name = "dgvDeleteChap";
            deleteChap.HeaderText = "";
            deleteChap.Text = "Xoá";
            deleteChap.UseColumnTextForButtonValue = true;
            dgvChap.Columns.Add(deleteChap);
        }
        private void updateListChap()
        {
            db.Chaps.Load();
            dgvChap.DataSource = sv.svChap.listChap(cbListManga.Text);
            dgvChap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void updateContentChap(int id)
        {
            var myChap = db.Chaps.Find(id);
            lbThisChap.Text = myChap.nameChap;
            lbChap.Text = myChap.nameChap;
            rtChap.Text = myChap.ContentManga;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
            MessageBox.Show("Lưu dữ liệu thành công !!!");
        }
        private void changeNameManga()
        {
            string[] name = { "Mã truyện", "Tên truyện", "Tác giả", "Nguồn", "Số chương" };
            for (int i = 0; i < dgvManga.Columns.Count; i++)
            {
                dgvManga.Columns[i].HeaderText = name[i];
            }
        } 

        private void dgvManga_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dgvManga.NewRowIndex || e.RowIndex < 0)
                return;
            if (e.ColumnIndex == dgvManga.Columns["dgvDeleteManga"].Index)
            {
                var data = (Manga)dgvManga.Rows[e.RowIndex].DataBoundItem;
                db.Mangas.Remove(data);
                db.SaveChanges();
                MessageBox.Show("Xoá thành công");
                db.Mangas.Load();
                dgvManga.DataSource = db.Mangas.Local.ToBindingList();
            }
        }

        private void dgvChap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dgvChap.NewRowIndex || e.RowIndex < 0)
                return;
            if (e.ColumnIndex == dgvChap.Columns["dgvDeleteChap"].Index)
            {
                var data = (Chap)dgvChap.Rows[e.RowIndex].DataBoundItem;
                Chap mychap = db.Chaps.Find(data.id);
                db.Chaps.Remove(mychap);
                db.SaveChanges();
                MessageBox.Show("Xoá thành công");
                updateListChap();
            }
            if (e.ColumnIndex == dgvChap.Columns["nameChap"].Index)
            {
                var data = (Chap)dgvChap.Rows[e.RowIndex].DataBoundItem;
                updateContentChap(data.id);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            updateListChap();
            var Manga = db.Mangas.Where(s => s.name == cbListManga.Text).FirstOrDefault();
            var defaultChap = sv.svChap.getFirtChap(Manga.idManga);
            updateContentChap(defaultChap.id);
        }

        private void addChap_Click(object sender, EventArgs e)
        {
            addChap newChap = new addChap(cbListManga.Text);
            newChap.Show();
            newChap.FormClosed += new FormClosedEventHandler(Form_Closed);
        }
        void Form_Closed(object sender, FormClosedEventArgs e)
        {
            addChap newChap = (addChap)sender;
            updateListChap();
            db.Mangas.Load();
            dgvManga.DataSource = db.Mangas.Local.ToBindingList();
        }
        void addCT_Closed(object sender, FormClosedEventArgs e)
        {
            addCategory newCategory = (addCategory)sender;
            updateListChap();
            db.Categories.Load();
            dgvCategory.DataSource = db.Categories.Local.ToBindingList();
        }
        void newCT_Closed(object sender, FormClosedEventArgs e)
        {
            addCategoryManga newCategory = (addCategoryManga)sender;
            var _MyManga = db.Mangas.Where(x => x.name == cbMangaCT.Text).FirstOrDefault();
            dgvCateManga.DataSource = sv.svCategoryManga.CategoryOfManga(_MyManga.idManga);
        }

        private void btnSaveChap_Click(object sender, EventArgs e)
        {
            Chap thisChap = db.Chaps.Where(s => s.nameChap == lbThisChap.Text).SingleOrDefault();
            thisChap.nameChap = lbChap.Text;
            thisChap.ContentManga = rtChap.Text;
            db.SaveChanges();
            MessageBox.Show("Cập nhập thành công!!!");
            updateContentChap(thisChap.id);
            updateListChap();
        }
        private void constructerCategoryManga()
        {
            cbMangaCT.Text = db.Mangas.FirstOrDefault().name;
            foreach (string item in sv.svManga.listNameManga())
            {
                cbMangaCT.Items.Add(item);
            }
            
            dgvCateManga.DataSource = sv.svCategoryManga.CategoryOfManga(db.Mangas.FirstOrDefault().idManga);
            dgvCateManga.AutoGenerateColumns = false;
            dgvCateManga.Columns.Remove("idCategory"); 
            dgvCateManga.Columns.Remove("CategoryMangas");
            dgvCateManga.Columns[0].HeaderText = "Tên thể loại";
            dgvCateManga.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            bntDeleteCategoryManga();
        }
        private void constructerCategory()
        {
            db.Categories.Load();
            dgvCategory.DataSource = db.Categories.Local.ToBindingList();
            dgvCategory.AutoGenerateColumns = false;
            dgvCategory.Columns.Remove("CategoryMangas");
            dgvCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategory.Columns[0].HeaderText = "Mã thể loại";
            dgvCategory.Columns[1].HeaderText = "Tên thể loại";
            btnDeleteCategory();
        }
        private void btnDeleteCategory()
        {
            var deleteCategory = new DataGridViewButtonColumn();
            deleteCategory.Name = "dgvDeleteCategory";
            deleteCategory.HeaderText = "";
            deleteCategory.Text = "Xoá";
            deleteCategory.UseColumnTextForButtonValue = true;
            dgvCategory.Columns.Add(deleteCategory);
        }
        private void bntDeleteCategoryManga()
        {
            var deleteCategoryManga = new DataGridViewButtonColumn();
            deleteCategoryManga.Name = "dgvDeleteCategoryManga";
            deleteCategoryManga.HeaderText = "";
            deleteCategoryManga.Text = "Xoá";
            deleteCategoryManga.UseColumnTextForButtonValue = true;
            dgvCateManga.Columns.Add(deleteCategoryManga);
        }

        private void btnSaveCT_Click(object sender, EventArgs e)
        {
            addCategory adCT = new addCategory();
            adCT.Show();
            adCT.FormClosed += new FormClosedEventHandler(addCT_Closed);
        }

        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dgvCategory.NewRowIndex || e.RowIndex < 0)
                return;
            if (e.ColumnIndex == dgvCategory.Columns["dgvDeleteCategory"].Index)
            {
                var data = (Category)dgvCategory.Rows[e.RowIndex].DataBoundItem;
                var res = db.Categories.Find(data.idCategory);
                db.Categories.Remove(res);
                db.SaveChanges();
                MessageBox.Show("Xoá thành công");
                db.Categories.Load();
                dgvCategory.DataSource = db.Categories.Local.ToBindingList();
            }
        }

        private void btnFindCT_Click(object sender, EventArgs e)
        {
            var _Manga = db.Mangas.Where(s => s.name == cbMangaCT.Text).FirstOrDefault();
            dgvCateManga.DataSource = sv.svCategoryManga.CategoryOfManga(_Manga.idManga);
        }

        private void dgvCateManga_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dgvCateManga.NewRowIndex || e.RowIndex < 0)
                return;
            if (e.ColumnIndex == dgvCateManga.Columns["dgvDeleteCategoryManga"].Index)
            {
                var data = (Category)dgvCateManga.Rows[e.RowIndex].DataBoundItem;
                var _MyManga = db.Mangas.Where(x => x.name == cbMangaCT.Text).FirstOrDefault();
                var res = db.MangaCategories.Where(s => s.idCategory == data.idCategory && s.idManga == _MyManga.idManga)
                    .FirstOrDefault();
                db.MangaCategories.Remove(res);
                db.SaveChanges();
                MessageBox.Show("Xoá thành công");
                dgvCateManga.DataSource = sv.svCategoryManga.CategoryOfManga(res.idManga);
            }
        }

        private void btnAddCT_Click(object sender, EventArgs e)
        {
            addCategoryManga newCT = new addCategoryManga(cbMangaCT.Text);
            newCT.Show();
            newCT.FormClosed += new FormClosedEventHandler(newCT_Closed);
        }
    }
}
