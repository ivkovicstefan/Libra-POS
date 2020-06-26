using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libra_POS.Data
{
    public class Bill
    {
        public int Id { get; set; }
        public double TotalPrice { get; set; }
        public DateTime Date { get; set; }

        public Bill() { }
        public Bill(int id, double totalPrice, DateTime date, string time)
        {
            DateTime tmpTime = DateTime.Parse(time);
            Id = id;
            TotalPrice = totalPrice;
            Date = date.Date+tmpTime.TimeOfDay;
        }
    }
}
