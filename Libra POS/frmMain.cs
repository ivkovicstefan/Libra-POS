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
using Libra_POS.Handlers;

namespace Libra_POS
{
    public partial class frmMain : Form
    {
        static bool isMouseDown;
        private Point lastLocation;
        private Bill CurrentBill;

        public void OnBookSelected(object sender, BookEventArgs e)
        {

            if(e.IsSelected)
            {
                int itemIndex;

                if (IsBookAlreadyOnBill(e.SelectedBook, out itemIndex))
                {
                    int amountOfBooks = Int32.Parse(lstBooks.Items[itemIndex].SubItems[2].Text);
                    double priceOfBooks = Double.Parse(lstBooks.Items[itemIndex].SubItems[4].Text);
                    amountOfBooks += e.AmountOfBooks;
                    priceOfBooks += e.SelectedBook.PriceWithDiscount()*e.AmountOfBooks;
                    lstBooks.Items[itemIndex].SubItems[2].Text = amountOfBooks.ToString();
                    lstBooks.Items[itemIndex].SubItems[4].Text = priceOfBooks.ToString();
                }
                else
                {
                    ListViewItem newItem = new ListViewItem(e.SelectedBook.Id.ToString());
                    newItem.SubItems.Add(e.SelectedBook.Name);
                    newItem.SubItems.Add(e.AmountOfBooks.ToString());
                    newItem.SubItems.Add(e.SelectedBook.PriceWithDiscount().ToString());
                    newItem.SubItems.Add((e.SelectedBook.PriceWithDiscount() * e.AmountOfBooks).ToString());
                    lstBooks.Items.Add(newItem);
                }

                CalculateTotalPrice();
            }
            
        }

        public frmMain()
        {
            InitializeComponent();
            Database.Instance.ReadAllData();
            this.KeyPreview = true;
            CurrentBill = new Bill();
        }

        private void Border_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            lastLocation = e.Location;
        }

        private void Border_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Border_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void SearchBook(object sender, EventArgs e)
        {
            frmSearchBooks frmSearchBook = new frmSearchBooks();
            frmSearchBook.BookSelected += this.OnBookSelected;
            frmSearchBook.ShowDialog();
        }

        /// <summary>
        /// Preklapanje tastera iz F serije (F1,F2..)
        /// </summary>
        /// <returns></returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                SearchBook(null, EventArgs.Empty);
                return true;
            }
            else if(keyData == Keys.F2)
            {
                AddNewBookDialog(null,EventArgs.Empty);
                return true;
            }
            else if(keyData == Keys.F3)
            {
                SearchBillsDialog(null, EventArgs.Empty);
                return true;
            }
            else if(keyData == Keys.F5)
            {
                PayBill(null, EventArgs.Empty);
                return true;
            }
            else if(keyData == Keys.Delete)
            {
                if(btnRemoveItemFromBill.Visible)
                {
                    RemoveItemFromBill(null, EventArgs.Empty);
                    
                }
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private bool IsBookAlreadyOnBill(Book book, out int itemIndex)
        {
            itemIndex = -1;
            bool IsAlreadyOnBill = false;
            foreach(ListViewItem item in lstBooks.Items)
            {
                if(book == DataHandler.GetBookById(Int32.Parse(item.SubItems[0].Text)))
                {
                    IsAlreadyOnBill = true;
                    itemIndex = item.Index;
                }
            }
            return IsAlreadyOnBill;
        }

        private void CloseApp(object sender, EventArgs e)
        {
            if(lstBooks.Items.Count>0)
            {
                MessageBox.Show("Prvo naplatite račun!");
            }
            else
            {
                Application.Exit();
            }
            
        }

        private void lstBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBooks.SelectedItems.Count==0)
            {
                btnRemoveItemFromBill.Visible = false;
            }
            else
            {
                btnRemoveItemFromBill.Visible = true;
            }
        }

        private void RemoveItemFromBill(object sender, EventArgs e)
        {
            
            lstBooks.Items.Remove(lstBooks.SelectedItems[0]);
            CalculateTotalPrice();
        }

        private void AddNewBookDialog(object sender, EventArgs e)
        {
            frmNewBook frmNewBook = new frmNewBook(this);
            frmNewBook.ShowDialog();
        }

        private void PayBill(object sender, EventArgs e)
        {
            if(lstBooks.Items.Count>0)
            {
                CurrentBill.Date = DateTime.Now;

                if(Database.Instance.InsertBill(CurrentBill)>0)
                {
                    lstBooks.Items.Clear();
                    lblTotalPrice.Text = "0.00";
                    MessageBox.Show("Uspešno ste naplatili račun!");
                }

            }
            else
            {
                MessageBox.Show("Nemate artikle na računu!");
            }
        }

        private void CalculateTotalPrice()
        {
            CurrentBill.TotalPrice = 0;

            foreach (ListViewItem item in lstBooks.Items)
            {
                CurrentBill.TotalPrice += Double.Parse(item.SubItems[4].Text);
            }

            lblTotalPrice.Text = CurrentBill.TotalPrice.ToString("0.00");
        }

        private void SearchBillsDialog(object sender, EventArgs e)
        {
            frmSearchBills frmSearchBills = new frmSearchBills();
            frmSearchBills.ShowDialog();
        }

        private void btnSearchBooks_MouseHover(object sender, EventArgs e)
        {
            tooltipBtn.Show("F1", btnSearchBooks);
        }

        private void btnNewBook_MouseHover(object sender, EventArgs e)
        {
            tooltipBtn.Show("F2", btnNewBook);
        }

        private void btnSearchBills_MouseHover(object sender, EventArgs e)
        {
            tooltipBtn.Show("F3", btnSearchBills);
        }

        private void btnPay_MouseHover(object sender, EventArgs e)
        {
            tooltipBtn.Show("F5", btnPay);
        }

        private void btnRemoveItemFromBill_MouseHover(object sender, EventArgs e)
        {
            tooltipBtn.Show("Del", btnRemoveItemFromBill);
        }
    }
}
