namespace Libra_POS
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.pnlBorder = new System.Windows.Forms.Panel();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlTools = new System.Windows.Forms.Panel();
            this.btnSearchBills = new System.Windows.Forms.Button();
            this.btnNewBook = new System.Windows.Forms.Button();
            this.btnSearchBooks = new System.Windows.Forms.Button();
            this.lblBill = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnRemoveItemFromBill = new System.Windows.Forms.Button();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.tooltipBtn = new System.Windows.Forms.ToolTip(this.components);
            this.lstBooks = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pricePerUnit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlBorder.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBorder
            // 
            this.pnlBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlBorder.Controls.Add(this.pnlLogo);
            this.pnlBorder.Controls.Add(this.btnClose);
            this.pnlBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBorder.Location = new System.Drawing.Point(0, 0);
            this.pnlBorder.Name = "pnlBorder";
            this.pnlBorder.Size = new System.Drawing.Size(467, 31);
            this.pnlBorder.TabIndex = 14;
            this.pnlBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Border_MouseDown);
            this.pnlBorder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Border_MouseMove);
            this.pnlBorder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Border_MouseUp);
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
            this.pnlLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Border_MouseDown);
            this.pnlLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Border_MouseMove);
            this.pnlLogo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Border_MouseUp);
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
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Border_MouseDown);
            this.lblTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Border_MouseMove);
            this.lblTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Border_MouseUp);
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
            this.btnClose.Location = new System.Drawing.Point(405, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(62, 31);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.CloseApp);
            // 
            // pnlTools
            // 
            this.pnlTools.BackColor = System.Drawing.Color.Transparent;
            this.pnlTools.Controls.Add(this.btnSearchBills);
            this.pnlTools.Controls.Add(this.btnNewBook);
            this.pnlTools.Controls.Add(this.btnSearchBooks);
            this.pnlTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTools.ForeColor = System.Drawing.Color.White;
            this.pnlTools.Location = new System.Drawing.Point(0, 31);
            this.pnlTools.Name = "pnlTools";
            this.pnlTools.Size = new System.Drawing.Size(467, 51);
            this.pnlTools.TabIndex = 15;
            // 
            // btnSearchBills
            // 
            this.btnSearchBills.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSearchBills.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchBills.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSearchBills.FlatAppearance.BorderSize = 0;
            this.btnSearchBills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchBills.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBills.ForeColor = System.Drawing.Color.White;
            this.btnSearchBills.Location = new System.Drawing.Point(313, 0);
            this.btnSearchBills.Name = "btnSearchBills";
            this.btnSearchBills.Size = new System.Drawing.Size(154, 51);
            this.btnSearchBills.TabIndex = 21;
            this.btnSearchBills.Text = "Pretraga računa";
            this.btnSearchBills.UseVisualStyleBackColor = false;
            this.btnSearchBills.Click += new System.EventHandler(this.SearchBillsDialog);
            this.btnSearchBills.MouseHover += new System.EventHandler(this.btnSearchBills_MouseHover);
            // 
            // btnNewBook
            // 
            this.btnNewBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnNewBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewBook.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNewBook.FlatAppearance.BorderSize = 0;
            this.btnNewBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewBook.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewBook.ForeColor = System.Drawing.Color.White;
            this.btnNewBook.Location = new System.Drawing.Point(149, 0);
            this.btnNewBook.Name = "btnNewBook";
            this.btnNewBook.Size = new System.Drawing.Size(164, 51);
            this.btnNewBook.TabIndex = 20;
            this.btnNewBook.Text = "Dodaj novu knjigu";
            this.btnNewBook.UseVisualStyleBackColor = false;
            this.btnNewBook.Click += new System.EventHandler(this.AddNewBookDialog);
            this.btnNewBook.MouseHover += new System.EventHandler(this.btnNewBook_MouseHover);
            // 
            // btnSearchBooks
            // 
            this.btnSearchBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSearchBooks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchBooks.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSearchBooks.FlatAppearance.BorderSize = 0;
            this.btnSearchBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchBooks.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBooks.ForeColor = System.Drawing.Color.White;
            this.btnSearchBooks.Location = new System.Drawing.Point(0, 0);
            this.btnSearchBooks.Name = "btnSearchBooks";
            this.btnSearchBooks.Size = new System.Drawing.Size(149, 51);
            this.btnSearchBooks.TabIndex = 19;
            this.btnSearchBooks.Text = "Pretraži knjigu";
            this.btnSearchBooks.UseVisualStyleBackColor = false;
            this.btnSearchBooks.Click += new System.EventHandler(this.SearchBook);
            this.btnSearchBooks.MouseHover += new System.EventHandler(this.btnSearchBooks_MouseHover);
            // 
            // lblBill
            // 
            this.lblBill.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblBill.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblBill.ForeColor = System.Drawing.Color.White;
            this.lblBill.Location = new System.Drawing.Point(0, 411);
            this.lblBill.Name = "lblBill";
            this.lblBill.Size = new System.Drawing.Size(136, 47);
            this.lblBill.TabIndex = 17;
            this.lblBill.Text = "Ukupan račun:";
            this.lblBill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(189)))), ((int)(((byte)(25)))));
            this.btnPay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPay.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(405, 411);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(62, 47);
            this.btnPay.TabIndex = 20;
            this.btnPay.Text = "$";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.PayBill);
            this.btnPay.MouseHover += new System.EventHandler(this.btnPay_MouseHover);
            // 
            // btnRemoveItemFromBill
            // 
            this.btnRemoveItemFromBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnRemoveItemFromBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoveItemFromBill.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRemoveItemFromBill.FlatAppearance.BorderSize = 0;
            this.btnRemoveItemFromBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveItemFromBill.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnRemoveItemFromBill.ForeColor = System.Drawing.Color.White;
            this.btnRemoveItemFromBill.Location = new System.Drawing.Point(269, 411);
            this.btnRemoveItemFromBill.Name = "btnRemoveItemFromBill";
            this.btnRemoveItemFromBill.Size = new System.Drawing.Size(136, 47);
            this.btnRemoveItemFromBill.TabIndex = 21;
            this.btnRemoveItemFromBill.Text = "Ukloni sa računa";
            this.btnRemoveItemFromBill.UseVisualStyleBackColor = false;
            this.btnRemoveItemFromBill.Visible = false;
            this.btnRemoveItemFromBill.Click += new System.EventHandler(this.RemoveItemFromBill);
            this.btnRemoveItemFromBill.MouseHover += new System.EventHandler(this.btnRemoveItemFromBill_MouseHover);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblTotalPrice.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotalPrice.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.White;
            this.lblTotalPrice.Location = new System.Drawing.Point(136, 411);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(135, 47);
            this.lblTotalPrice.TabIndex = 18;
            this.lblTotalPrice.Text = "0.00";
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstBooks
            // 
            this.lstBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lstBooks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstBooks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.name,
            this.amount,
            this.pricePerUnit,
            this.price});
            this.lstBooks.Dock = System.Windows.Forms.DockStyle.Top;
            this.lstBooks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBooks.ForeColor = System.Drawing.Color.White;
            this.lstBooks.FullRowSelect = true;
            this.lstBooks.HideSelection = false;
            this.lstBooks.Location = new System.Drawing.Point(0, 82);
            this.lstBooks.Name = "lstBooks";
            this.lstBooks.Size = new System.Drawing.Size(467, 329);
            this.lstBooks.TabIndex = 24;
            this.lstBooks.UseCompatibleStateImageBehavior = false;
            this.lstBooks.View = System.Windows.Forms.View.Details;
            this.lstBooks.SelectedIndexChanged += new System.EventHandler(this.lstBooks_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.Text = "Šifra knjige";
            // 
            // name
            // 
            this.name.Text = "Naslov knjige";
            this.name.Width = 120;
            // 
            // amount
            // 
            this.amount.Text = "Količina";
            this.amount.Width = 67;
            // 
            // pricePerUnit
            // 
            this.pricePerUnit.Text = "Cena po komadu";
            this.pricePerUnit.Width = 145;
            // 
            // price
            // 
            this.price.Text = "Cena";
            this.price.Width = 73;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(467, 458);
            this.Controls.Add(this.btnRemoveItemFromBill);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblBill);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.lstBooks);
            this.Controls.Add(this.pnlTools);
            this.Controls.Add(this.pnlBorder);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlBorder.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            this.pnlTools.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBorder;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlTools;
        private System.Windows.Forms.Button btnSearchBills;
        private System.Windows.Forms.Button btnNewBook;
        private System.Windows.Forms.Button btnSearchBooks;
        private System.Windows.Forms.Label lblBill;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnRemoveItemFromBill;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.ToolTip tooltipBtn;
        private System.Windows.Forms.ListView lstBooks;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader amount;
        private System.Windows.Forms.ColumnHeader pricePerUnit;
        private System.Windows.Forms.ColumnHeader price;
    }
}

