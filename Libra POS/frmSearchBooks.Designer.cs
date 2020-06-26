namespace Libra_POS
{
    partial class frmSearchBooks
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
            this.pnlBorder = new System.Windows.Forms.Panel();
            this.btnInfo = new System.Windows.Forms.Button();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlBooks = new System.Windows.Forms.Panel();
            this.pnlCategories = new System.Windows.Forms.Panel();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.lblSelectCategory = new System.Windows.Forms.Label();
            this.pnlSearchByAuthor = new System.Windows.Forms.Panel();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblSearchByAuthor = new System.Windows.Forms.Label();
            this.pnlSearchByTitle = new System.Windows.Forms.Panel();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.lblSearchByTitle = new System.Windows.Forms.Label();
            this.lstBooks = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlBorder.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlBooks.SuspendLayout();
            this.pnlCategories.SuspendLayout();
            this.pnlSearchByAuthor.SuspendLayout();
            this.pnlSearchByTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBorder
            // 
            this.pnlBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlBorder.Controls.Add(this.btnInfo);
            this.pnlBorder.Controls.Add(this.lblSubtitle);
            this.pnlBorder.Controls.Add(this.pnlLogo);
            this.pnlBorder.Controls.Add(this.btnClose);
            this.pnlBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBorder.Location = new System.Drawing.Point(0, 0);
            this.pnlBorder.Name = "pnlBorder";
            this.pnlBorder.Size = new System.Drawing.Size(493, 31);
            this.pnlBorder.TabIndex = 15;
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.ForeColor = System.Drawing.Color.White;
            this.btnInfo.Location = new System.Drawing.Point(366, 0);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(65, 31);
            this.btnInfo.TabIndex = 16;
            this.btnInfo.Text = "Pomoć";
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.DisplayHelp);
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.ForeColor = System.Drawing.Color.White;
            this.lblSubtitle.Location = new System.Drawing.Point(96, 6);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(117, 20);
            this.lblSubtitle.TabIndex = 9;
            this.lblSubtitle.Text = "Izaberite knjigu";
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.pnlLogo.Controls.Add(this.lblTitle);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(90, 31);
            this.pnlLogo.TabIndex = 15;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(6, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(76, 20);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Libra POS";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(431, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(62, 31);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.CloseWindow);
            // 
            // pnlBooks
            // 
            this.pnlBooks.Controls.Add(this.pnlCategories);
            this.pnlBooks.Controls.Add(this.pnlSearchByAuthor);
            this.pnlBooks.Controls.Add(this.pnlSearchByTitle);
            this.pnlBooks.Controls.Add(this.lstBooks);
            this.pnlBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBooks.Location = new System.Drawing.Point(0, 31);
            this.pnlBooks.Name = "pnlBooks";
            this.pnlBooks.Size = new System.Drawing.Size(493, 440);
            this.pnlBooks.TabIndex = 16;
            // 
            // pnlCategories
            // 
            this.pnlCategories.Controls.Add(this.cmbCategories);
            this.pnlCategories.Controls.Add(this.lblSelectCategory);
            this.pnlCategories.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCategories.Location = new System.Drawing.Point(0, 409);
            this.pnlCategories.Name = "pnlCategories";
            this.pnlCategories.Size = new System.Drawing.Size(493, 30);
            this.pnlCategories.TabIndex = 22;
            // 
            // cmbCategories
            // 
            this.cmbCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.cmbCategories.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmbCategories.Font = new System.Drawing.Font("Segoe UI", 11.75F);
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(160, 0);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(333, 29);
            this.cmbCategories.TabIndex = 4;
            this.cmbCategories.SelectedIndexChanged += new System.EventHandler(this.FilterBooks);
            // 
            // lblSelectCategory
            // 
            this.lblSelectCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblSelectCategory.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSelectCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCategory.ForeColor = System.Drawing.Color.White;
            this.lblSelectCategory.Location = new System.Drawing.Point(0, 0);
            this.lblSelectCategory.Name = "lblSelectCategory";
            this.lblSelectCategory.Size = new System.Drawing.Size(159, 30);
            this.lblSelectCategory.TabIndex = 18;
            this.lblSelectCategory.Text = "Izaberite žanr knjige:";
            this.lblSelectCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSearchByAuthor
            // 
            this.pnlSearchByAuthor.Controls.Add(this.txtAuthor);
            this.pnlSearchByAuthor.Controls.Add(this.lblSearchByAuthor);
            this.pnlSearchByAuthor.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearchByAuthor.Location = new System.Drawing.Point(0, 379);
            this.pnlSearchByAuthor.Name = "pnlSearchByAuthor";
            this.pnlSearchByAuthor.Size = new System.Drawing.Size(493, 30);
            this.pnlSearchByAuthor.TabIndex = 21;
            // 
            // txtAuthor
            // 
            this.txtAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAuthor.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtAuthor.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtAuthor.ForeColor = System.Drawing.Color.White;
            this.txtAuthor.Location = new System.Drawing.Point(160, 0);
            this.txtAuthor.Multiline = true;
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(333, 30);
            this.txtAuthor.TabIndex = 3;
            this.txtAuthor.TextChanged += new System.EventHandler(this.FilterBooks);
            // 
            // lblSearchByAuthor
            // 
            this.lblSearchByAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblSearchByAuthor.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSearchByAuthor.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchByAuthor.ForeColor = System.Drawing.Color.White;
            this.lblSearchByAuthor.Location = new System.Drawing.Point(0, 0);
            this.lblSearchByAuthor.Name = "lblSearchByAuthor";
            this.lblSearchByAuthor.Size = new System.Drawing.Size(159, 30);
            this.lblSearchByAuthor.TabIndex = 18;
            this.lblSearchByAuthor.Text = "Unesite autora knjige:";
            this.lblSearchByAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSearchByTitle
            // 
            this.pnlSearchByTitle.Controls.Add(this.txtBookTitle);
            this.pnlSearchByTitle.Controls.Add(this.lblSearchByTitle);
            this.pnlSearchByTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearchByTitle.Location = new System.Drawing.Point(0, 349);
            this.pnlSearchByTitle.Name = "pnlSearchByTitle";
            this.pnlSearchByTitle.Size = new System.Drawing.Size(493, 30);
            this.pnlSearchByTitle.TabIndex = 20;
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtBookTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBookTitle.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtBookTitle.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtBookTitle.ForeColor = System.Drawing.Color.White;
            this.txtBookTitle.Location = new System.Drawing.Point(160, 0);
            this.txtBookTitle.Multiline = true;
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.Size = new System.Drawing.Size(333, 30);
            this.txtBookTitle.TabIndex = 2;
            this.txtBookTitle.TextChanged += new System.EventHandler(this.FilterBooks);
            // 
            // lblSearchByTitle
            // 
            this.lblSearchByTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblSearchByTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSearchByTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchByTitle.ForeColor = System.Drawing.Color.White;
            this.lblSearchByTitle.Location = new System.Drawing.Point(0, 0);
            this.lblSearchByTitle.Name = "lblSearchByTitle";
            this.lblSearchByTitle.Size = new System.Drawing.Size(159, 30);
            this.lblSearchByTitle.TabIndex = 18;
            this.lblSearchByTitle.Text = "Unesite naslov knjige:";
            this.lblSearchByTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstBooks
            // 
            this.lstBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lstBooks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstBooks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.name,
            this.author,
            this.price,
            this.category});
            this.lstBooks.Dock = System.Windows.Forms.DockStyle.Top;
            this.lstBooks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBooks.ForeColor = System.Drawing.Color.White;
            this.lstBooks.FullRowSelect = true;
            this.lstBooks.HideSelection = false;
            this.lstBooks.Location = new System.Drawing.Point(0, 0);
            this.lstBooks.MultiSelect = false;
            this.lstBooks.Name = "lstBooks";
            this.lstBooks.Size = new System.Drawing.Size(493, 349);
            this.lstBooks.TabIndex = 1;
            this.lstBooks.UseCompatibleStateImageBehavior = false;
            this.lstBooks.View = System.Windows.Forms.View.Details;
            this.lstBooks.DoubleClick += new System.EventHandler(this.AddBookToBill);
            // 
            // id
            // 
            this.id.Text = "Šifra knjige";
            this.id.Width = 92;
            // 
            // name
            // 
            this.name.Text = "Naslov knjige";
            this.name.Width = 151;
            // 
            // author
            // 
            this.author.Text = "Pisac";
            this.author.Width = 122;
            // 
            // price
            // 
            this.price.Text = "Cena";
            this.price.Width = 65;
            // 
            // category
            // 
            this.category.Text = "Žanr";
            this.category.Width = 62;
            // 
            // frmSearchBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(493, 471);
            this.Controls.Add(this.pnlBooks);
            this.Controls.Add(this.pnlBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSearchBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSearchBooks";
            this.Load += new System.EventHandler(this.frmSearchBook_Load);
            this.pnlBorder.ResumeLayout(false);
            this.pnlBorder.PerformLayout();
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            this.pnlBooks.ResumeLayout(false);
            this.pnlCategories.ResumeLayout(false);
            this.pnlSearchByAuthor.ResumeLayout(false);
            this.pnlSearchByAuthor.PerformLayout();
            this.pnlSearchByTitle.ResumeLayout(false);
            this.pnlSearchByTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBorder;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlBooks;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.Label lblSearchByTitle;
        private System.Windows.Forms.Panel pnlSearchByTitle;
        private System.Windows.Forms.Panel pnlSearchByAuthor;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblSearchByAuthor;
        private System.Windows.Forms.Panel pnlCategories;
        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.Label lblSelectCategory;
        private System.Windows.Forms.ListView lstBooks;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader author;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader category;
        private System.Windows.Forms.Button btnInfo;
    }
}