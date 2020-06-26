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
    public partial class frmBookAmount : Form
    {
        frmSearchBooks senderForm;

        public frmBookAmount(frmSearchBooks sender)
        {
            senderForm = sender;
            InitializeComponent();
            txtAmount.Focus();
        }

        private void ConfirmAmount(object sender, EventArgs e)
        {
            if(txtAmount.Text.Length>0 && Int32.Parse(txtAmount.Text)!=0)
            {
                senderForm.AmmountOfSelectedBooks = Int32.Parse(txtAmount.Text);
                this.Close();
            }
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && e.KeyChar!=8)
            {
                e.Handled = true;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                ConfirmAmount(null, null);
                return true;
            }
            else if(keyData == Keys.Up)
            {
                txtAmount.Text = (Int32.Parse(txtAmount.Text) + 1).ToString();
                return true;
            }
            else if(keyData == Keys.Down)
            {
                int amount = Int32.Parse(txtAmount.Text);
                if(amount>1)
                {
                    txtAmount.Text = (amount-1).ToString();
                }

            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
