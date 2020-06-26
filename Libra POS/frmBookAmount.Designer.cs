namespace Libra_POS
{
    partial class frmBookAmount
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
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnConfirmAmount = new System.Windows.Forms.Button();
            this.pnlBorder.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBorder
            // 
            this.pnlBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlBorder.Controls.Add(this.lblSubtitle);
            this.pnlBorder.Controls.Add(this.pnlLogo);
            this.pnlBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBorder.Location = new System.Drawing.Point(0, 0);
            this.pnlBorder.Name = "pnlBorder";
            this.pnlBorder.Size = new System.Drawing.Size(288, 31);
            this.pnlBorder.TabIndex = 16;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.ForeColor = System.Drawing.Color.White;
            this.lblSubtitle.Location = new System.Drawing.Point(96, 6);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(120, 20);
            this.lblSubtitle.TabIndex = 9;
            this.lblSubtitle.Text = "Unesite količinu";
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
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmount.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.ForeColor = System.Drawing.Color.White;
            this.txtAmount.Location = new System.Drawing.Point(0, 31);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(288, 33);
            this.txtAmount.TabIndex = 17;
            this.txtAmount.Text = "1";
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // btnConfirmAmount
            // 
            this.btnConfirmAmount.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnConfirmAmount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirmAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConfirmAmount.FlatAppearance.BorderSize = 0;
            this.btnConfirmAmount.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnConfirmAmount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnConfirmAmount.ForeColor = System.Drawing.Color.White;
            this.btnConfirmAmount.Location = new System.Drawing.Point(0, 64);
            this.btnConfirmAmount.Name = "btnConfirmAmount";
            this.btnConfirmAmount.Size = new System.Drawing.Size(288, 31);
            this.btnConfirmAmount.TabIndex = 21;
            this.btnConfirmAmount.Text = "Potvrdi";
            this.btnConfirmAmount.UseVisualStyleBackColor = false;
            this.btnConfirmAmount.Click += new System.EventHandler(this.ConfirmAmount);
            // 
            // frmBookAmount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(288, 95);
            this.Controls.Add(this.btnConfirmAmount);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.pnlBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBookAmount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBookAmount";
            this.pnlBorder.ResumeLayout(false);
            this.pnlBorder.PerformLayout();
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBorder;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnConfirmAmount;
    }
}