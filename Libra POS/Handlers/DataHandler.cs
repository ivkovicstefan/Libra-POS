using Libra_POS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libra_POS.Handlers
{
    class DataHandler
    {
        public static Book GetBookById(int id)
        {
            return Database.Instance.AllBooks.FirstOrDefault(b => b.Id == id);
        }

        public static IList<Book> GetBooksByTitleAndAuthor(string title, string author, int categoryId)
        {
            if(categoryId>0)
            {
                return Database.Instance.AllBooks.
                Where(b => b.Name.Contains(title) && b.Author.Contains(author) && b.CategoryId == categoryId).ToList();
            }
            else
            {
                return Database.Instance.AllBooks.
                Where(b => b.Name.Contains(title) && b.Author.Contains(author)).ToList();
            }
            
        }

        public static IList<Bill> GetBillsByDate(DateTime date)
        {
            return Database.Instance.AllBills.
                Where(b => b.Date.Date == date).ToList();
        }
    }
}
