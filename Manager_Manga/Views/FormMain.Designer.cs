
namespace Manager_Manga
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.tabManga = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvManga = new System.Windows.Forms.DataGridView();
            this.tabChap = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.cbListManga = new System.Windows.Forms.ComboBox();
            this.dgvChap = new System.Windows.Forms.DataGridView();
            this.btnFind = new System.Windows.Forms.Button();
            this.addChap = new System.Windows.Forms.Button();
            this.rtChap = new System.Windows.Forms.RichTextBox();
            this.btnSaveChap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.abc = new System.Windows.Forms.Label();
            this.lbChap = new System.Windows.Forms.TextBox();
            this.lbThisChap = new System.Windows.Forms.Label();
            this.tabCategoryManga = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.dgvCateManga = new System.Windows.Forms.DataGridView();
            this.btnSaveCT = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbMangaCT = new System.Windows.Forms.ComboBox();
            this.btnFindCT = new System.Windows.Forms.Button();
            this.btnAddCT = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.tabManga.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManga)).BeginInit();
            this.tabChap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChap)).BeginInit();
            this.tabCategoryManga.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCateManga)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.tabMenu);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(800, 450);
            this.pnlMain.TabIndex = 0;
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.tabManga);
            this.tabMenu.Controls.Add(this.tabChap);
            this.tabMenu.Controls.Add(this.tabCategoryManga);
            this.tabMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMenu.Location = new System.Drawing.Point(0, 0);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(800, 450);
            this.tabMenu.TabIndex = 0;
            // 
            // tabManga
            // 
            this.tabManga.Controls.Add(this.btnSave);
            this.tabManga.Controls.Add(this.panel1);
            this.tabManga.Location = new System.Drawing.Point(4, 22);
            this.tabManga.Name = "tabManga";
            this.tabManga.Padding = new System.Windows.Forms.Padding(3);
            this.tabManga.Size = new System.Drawing.Size(792, 424);
            this.tabManga.TabIndex = 0;
            this.tabManga.Text = "Danh sách truyện";
            this.tabManga.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(698, 396);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 25);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Lưu dữ liệu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvManga);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 391);
            this.panel1.TabIndex = 0;
            // 
            // dgvManga
            // 
            this.dgvManga.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvManga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManga.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvManga.Location = new System.Drawing.Point(0, 0);
            this.dgvManga.Name = "dgvManga";
            this.dgvManga.Size = new System.Drawing.Size(794, 391);
            this.dgvManga.TabIndex = 0;
            this.dgvManga.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvManga_CellClick);
            // 
            // tabChap
            // 
            this.tabChap.Controls.Add(this.lbChap);
            this.tabChap.Controls.Add(this.rtChap);
            this.tabChap.Controls.Add(this.btnSaveChap);
            this.tabChap.Controls.Add(this.addChap);
            this.tabChap.Controls.Add(this.btnFind);
            this.tabChap.Controls.Add(this.abc);
            this.tabChap.Controls.Add(this.label2);
            this.tabChap.Controls.Add(this.lbThisChap);
            this.tabChap.Controls.Add(this.label1);
            this.tabChap.Controls.Add(this.cbListManga);
            this.tabChap.Controls.Add(this.dgvChap);
            this.tabChap.Location = new System.Drawing.Point(4, 22);
            this.tabChap.Name = "tabChap";
            this.tabChap.Padding = new System.Windows.Forms.Padding(3);
            this.tabChap.Size = new System.Drawing.Size(792, 424);
            this.tabChap.TabIndex = 1;
            this.tabChap.Text = "Danh sách chương";
            this.tabChap.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên truyện";
            // 
            // cbListManga
            // 
            this.cbListManga.FormattingEnabled = true;
            this.cbListManga.Location = new System.Drawing.Point(390, 13);
            this.cbListManga.Name = "cbListManga";
            this.cbListManga.Size = new System.Drawing.Size(211, 21);
            this.cbListManga.TabIndex = 1;
            // 
            // dgvChap
            // 
            this.dgvChap.AllowUserToAddRows = false;
            this.dgvChap.AllowUserToDeleteRows = false;
            this.dgvChap.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvChap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChap.Location = new System.Drawing.Point(8, 39);
            this.dgvChap.Name = "dgvChap";
            this.dgvChap.ReadOnly = true;
            this.dgvChap.Size = new System.Drawing.Size(270, 379);
            this.dgvChap.TabIndex = 0;
            this.dgvChap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChap_CellClick);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(617, 10);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(81, 26);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "Lọc";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // addChap
            // 
            this.addChap.Location = new System.Drawing.Point(702, 10);
            this.addChap.Name = "addChap";
            this.addChap.Size = new System.Drawing.Size(81, 26);
            this.addChap.TabIndex = 3;
            this.addChap.Text = "Thêm chương";
            this.addChap.UseVisualStyleBackColor = true;
            this.addChap.Click += new System.EventHandler(this.addChap_Click);
            // 
            // rtChap
            // 
            this.rtChap.BackColor = System.Drawing.SystemColors.MenuBar;
            this.rtChap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtChap.Location = new System.Drawing.Point(315, 77);
            this.rtChap.Name = "rtChap";
            this.rtChap.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rtChap.Size = new System.Drawing.Size(468, 311);
            this.rtChap.TabIndex = 4;
            this.rtChap.Text = "";
            // 
            // btnSaveChap
            // 
            this.btnSaveChap.Location = new System.Drawing.Point(689, 392);
            this.btnSaveChap.Name = "btnSaveChap";
            this.btnSaveChap.Size = new System.Drawing.Size(81, 26);
            this.btnSaveChap.TabIndex = 3;
            this.btnSaveChap.Text = "Lưu";
            this.btnSaveChap.UseVisualStyleBackColor = true;
            this.btnSaveChap.Click += new System.EventHandler(this.btnSaveChap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Danh sách chương";
            // 
            // abc
            // 
            this.abc.AutoSize = true;
            this.abc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abc.Location = new System.Drawing.Point(321, 397);
            this.abc.Name = "abc";
            this.abc.Size = new System.Drawing.Size(65, 16);
            this.abc.TabIndex = 2;
            this.abc.Text = "Tên chap";
            // 
            // lbChap
            // 
            this.lbChap.Location = new System.Drawing.Point(396, 395);
            this.lbChap.Name = "lbChap";
            this.lbChap.Size = new System.Drawing.Size(157, 20);
            this.lbChap.TabIndex = 5;
            // 
            // lbThisChap
            // 
            this.lbThisChap.AutoSize = true;
            this.lbThisChap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThisChap.Location = new System.Drawing.Point(472, 45);
            this.lbThisChap.Name = "lbThisChap";
            this.lbThisChap.Size = new System.Drawing.Size(75, 20);
            this.lbThisChap.TabIndex = 2;
            this.lbThisChap.Text = "Tên chap";
            // 
            // tabCategoryManga
            // 
            this.tabCategoryManga.Controls.Add(this.panel2);
            this.tabCategoryManga.Location = new System.Drawing.Point(4, 22);
            this.tabCategoryManga.Name = "tabCategoryManga";
            this.tabCategoryManga.Padding = new System.Windows.Forms.Padding(3);
            this.tabCategoryManga.Size = new System.Drawing.Size(792, 424);
            this.tabCategoryManga.TabIndex = 2;
            this.tabCategoryManga.Text = "Thể loại truyện";
            this.tabCategoryManga.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAddCT);
            this.panel2.Controls.Add(this.btnFindCT);
            this.panel2.Controls.Add(this.cbMangaCT);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnSaveCT);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(786, 418);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvCategory);
            this.panel3.Location = new System.Drawing.Point(39, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(282, 300);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvCateManga);
            this.panel4.Location = new System.Drawing.Point(368, 105);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(386, 267);
            this.panel4.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Danh sách thê loại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(461, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Danh sách thể loại truyện";
            // 
            // dgvCategory
            // 
            this.dgvCategory.AllowUserToAddRows = false;
            this.dgvCategory.AllowUserToDeleteRows = false;
            this.dgvCategory.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCategory.Location = new System.Drawing.Point(0, 0);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.ReadOnly = true;
            this.dgvCategory.Size = new System.Drawing.Size(282, 300);
            this.dgvCategory.TabIndex = 0;
            this.dgvCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategory_CellClick);
            // 
            // dgvCateManga
            // 
            this.dgvCateManga.AllowUserToAddRows = false;
            this.dgvCateManga.AllowUserToDeleteRows = false;
            this.dgvCateManga.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvCateManga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCateManga.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCateManga.Location = new System.Drawing.Point(0, 0);
            this.dgvCateManga.Name = "dgvCateManga";
            this.dgvCateManga.ReadOnly = true;
            this.dgvCateManga.Size = new System.Drawing.Size(386, 267);
            this.dgvCateManga.TabIndex = 0;
            this.dgvCateManga.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCateManga_CellClick);
            // 
            // btnSaveCT
            // 
            this.btnSaveCT.Location = new System.Drawing.Point(205, 382);
            this.btnSaveCT.Name = "btnSaveCT";
            this.btnSaveCT.Size = new System.Drawing.Size(116, 31);
            this.btnSaveCT.TabIndex = 4;
            this.btnSaveCT.Text = "Thêm thể loại";
            this.btnSaveCT.UseVisualStyleBackColor = true;
            this.btnSaveCT.Click += new System.EventHandler(this.btnSaveCT_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(365, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Lọc theo truyện";
            // 
            // cbMangaCT
            // 
            this.cbMangaCT.FormattingEnabled = true;
            this.cbMangaCT.Location = new System.Drawing.Point(494, 32);
            this.cbMangaCT.Name = "cbMangaCT";
            this.cbMangaCT.Size = new System.Drawing.Size(193, 21);
            this.cbMangaCT.TabIndex = 6;
            // 
            // btnFindCT
            // 
            this.btnFindCT.Location = new System.Drawing.Point(694, 30);
            this.btnFindCT.Name = "btnFindCT";
            this.btnFindCT.Size = new System.Drawing.Size(71, 25);
            this.btnFindCT.TabIndex = 7;
            this.btnFindCT.Text = "Lọc";
            this.btnFindCT.UseVisualStyleBackColor = true;
            this.btnFindCT.Click += new System.EventHandler(this.btnFindCT_Click);
            // 
            // btnAddCT
            // 
            this.btnAddCT.Location = new System.Drawing.Point(639, 380);
            this.btnAddCT.Name = "btnAddCT";
            this.btnAddCT.Size = new System.Drawing.Size(114, 33);
            this.btnAddCT.TabIndex = 8;
            this.btnAddCT.Text = "Thêm mới";
            this.btnAddCT.UseVisualStyleBackColor = true;
            this.btnAddCT.Click += new System.EventHandler(this.btnAddCT_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlMain);
            this.Name = "FormMain";
            this.Text = "Quản lý truyện";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.pnlMain.ResumeLayout(false);
            this.tabMenu.ResumeLayout(false);
            this.tabManga.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManga)).EndInit();
            this.tabChap.ResumeLayout(false);
            this.tabChap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChap)).EndInit();
            this.tabCategoryManga.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCateManga)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.TabPage tabManga;
        private System.Windows.Forms.TabPage tabChap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbListManga;
        private System.Windows.Forms.DataGridView dgvChap;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvManga;
        private System.Windows.Forms.Button addChap;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.RichTextBox rtChap;
        private System.Windows.Forms.Button btnSaveChap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label abc;
        private System.Windows.Forms.TextBox lbChap;
        private System.Windows.Forms.Label lbThisChap;
        private System.Windows.Forms.TabPage tabCategoryManga;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSaveCT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvCateManga;
        private System.Windows.Forms.DataGridView dgvCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddCT;
        private System.Windows.Forms.Button btnFindCT;
        private System.Windows.Forms.ComboBox cbMangaCT;
    }
}

