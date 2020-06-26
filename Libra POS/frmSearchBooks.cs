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
    public partial class frmSearchBooks : Form
    {

        public delegate void BookSelectedEventHandler(object sender, BookEventArgs e);

        public event BookSelectedEventHandler BookSelected;

        protected virtual void OnBookSelected(Book selectedBook)
        {
            if(BookSelected!=null)
            {
                BookSelected(this, new BookEventArgs(){ SelectedBook = selectedBook, AmountOfBooks = AmmountOfSelectedBooks, IsSelected = IsBookSelected});
            }
        }

        public int AmmountOfSelectedBooks { get; set; }
        public bool IsBookSelected { get; set; }

        public frmSearchBooks()
        {
            InitializeComponent();
            IsBookSelected = false;
        }

        private void RefreshListView(IList<Book> listOfBooks)
        {
            lstBooks.Items.Clear();

            List<Book> sortedBooks = listOfBooks.OrderBy(x => x.Author).ToList();

            foreach (var book in sortedBooks)
            {
                ListViewItem loadedBook = new ListViewItem(book.Id.ToString());
                loadedBook.SubItems.Add(book.Name);
                loadedBook.SubItems.Add(book.Author);
                loadedBook.SubItems.Add(book.PriceWithDiscount().ToString());
                loadedBook.SubItems.Add(book.CategoryId.ToString());
                lstBooks.Items.Add(loadedBook);
            }

            if (lstBooks.Items.Count > 0)
            {
                lstBooks.Select();
                lstBooks.Items[0].Selected = true;
            }
            lstBooks.Focus();
        }

        private void frmSearchBook_Load(object sender, EventArgs e)
        {
            RefreshListView(Database.Instance.AllBooks);

            foreach (var category in Database.Instance.AllCategories)
            {
                cmbCategories.Items.Add(category.Name);
            }

        }

        private void AddBookToBill(object sender, EventArgs e)
        {
            if(lstBooks.SelectedItems!=null)
            {
                frmBookAmount frmBookAmount = new frmBookAmount(this);
                Book selectedBook = DataHandler.GetBookById(Int32.Parse(lstBooks.SelectedItems[0].SubItems[0].Text));
                IsBookSelected = true;
                frmBookAmount.ShowDialog();
                OnBookSelected(selectedBook);
                this.Close();
                
            }
        }

        private void CloseWindow(object sender, EventArgs e)
        {
            IsBookSelected = false;
            this.Close();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                AddBookToBill(null, null);
                return true;
            }
            else if (keyData == Keys.Escape)
            {
                CloseWindow(null, EventArgs.Empty);
                return true;
            }
            else if (keyData == Keys.F9)
            {
                DisplayHelp(null, EventArgs.Empty);
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void FilterBooks(object sender, EventArgs e)
        {
            RefreshListView(DataHandler.GetBooksByTitleAndAuthor(txtBookTitle.Text, txtAuthor.Text, cmbCategories.SelectedIndex+1));
            
            if (sender is TextBox)
            {
                TextBox txt = (TextBox)sender;
                txt.Focus();
            }

        }

        private void DisplayHelp(object sender, EventArgs e)
        {
            MessageBox.Show("Pomoć:\nIzbor knjige: Dupli klik na knjigu ili Enter na tastaturi.");
        }
    }

    public class BookEventArgs : EventArgs
    {
        public Book SelectedBook { get; set; }
        public int AmountOfBooks { get; set; }
        public bool IsSelected { get; set; }
    }
}
