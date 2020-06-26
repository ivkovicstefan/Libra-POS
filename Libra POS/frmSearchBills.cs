using Libra_POS.Data;
using Libra_POS.Handlers;
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
    public partial class frmSearchBills : Form
    {
        public frmSearchBills()
        {
            InitializeComponent();
            RefreshListView(Database.Instance.AllBills);
            dateTimePicker.MaxDate = DateTime.Now.Date;
        }

        private void RefreshListView(IList<Bill> listOfBills)
        {
            lstBills.Items.Clear();

            List<Bill> sortedBills = listOfBills.OrderBy(x => x.TotalPrice).ToList();

            foreach (var bill in sortedBills)
            {
                ListViewItem loadedBill = new ListViewItem(bill.Id.ToString());
                loadedBill.SubItems.Add(bill.TotalPrice.ToString());
                loadedBill.SubItems.Add(bill.Date.ToShortDateString());
                lstBills.Items.Add(loadedBill);
            }

            if (lstBills.Items.Count > 0)
            {
                lstBills.Select();
                lstBills.Items[0].Selected = true;
            }
            lstBills.Focus();
        }

        private void CloseWindow(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FilterBillsByDate(object sender, EventArgs e)
        {
            IList<Bill> filteredBills = DataHandler.GetBillsByDate(dateTimePicker.Value);
            RefreshListView(filteredBills);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                CloseWindow(null, EventArgs.Empty);
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
