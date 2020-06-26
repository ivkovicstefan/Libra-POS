using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libra_POS.Data
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public int Discount { get; set; }
        public int CategoryId { get; set; }

        public Book() { }

        public Book(int id, string name, string author, double price, int discount, int categoryId)
        {
            Id = id;
            Name = name;
            Author = author;
            Price = price;
            Discount = discount;
            CategoryId = categoryId;
        }

        public double PriceWithDiscount()
        {
            return Price - Price * Discount / 100;
        } 
    }
}
