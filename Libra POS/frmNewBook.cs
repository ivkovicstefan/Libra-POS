using Libra_POS.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libra_POS
{
    public partial class frmNewBook : Form
    {
        Form parentForm;
        public frmNewBook(frmMain sender)
        {
            parentForm = sender;
            InitializeComponent();
        }

        private void CloseWindow(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAuthor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void NumberKeysOnly(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void frmNewBook_Load(object sender, EventArgs e)
        {
            foreach(var category in Database.Instance.AllCategories)
            {
                cmbCategories.Items.Add(category.Name);
            }
        }

        private void ConfirmSaving(object sender, EventArgs e)
        {
            if(txtBookTitle.Text!="" && txtAuthor.Text!="" && txtPrice.Text!="" && cmbCategories.SelectedIndex!=-1)
            {
                Book book = new Book
                    (-1, 
                    txtBookTitle.Text, 
                    txtAuthor.Text, 
                    Double.Parse(txtPrice.Text), 
                    (txtDiscount.Text == "") ? 0 : Int32.Parse(txtDiscount.Text), 
                    cmbCategories.SelectedIndex + 1);

                if(Database.Instance.InsertBook(book)>0)
                {
                    MessageBox.Show("Uspešno ste dodali knjigu!");
                    txtBookTitle.Clear();
                    txtAuthor.Clear();
                    txtPrice.Clear();
                    txtDiscount.Clear();
                }
            }
            else
            {
                MessageBox.Show("Morate uneti sva polja!");
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                ConfirmSaving(null, EventArgs.Empty);
                return true;
            }
            else if (keyData == Keys.Escape)
            {
                CloseWindow(null, EventArgs.Empty);
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
