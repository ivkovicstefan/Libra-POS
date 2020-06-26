using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using Libra_POS.Handlers;

namespace Libra_POS.Data
{
    /// <summary>
    /// Singleton klasa koja predstavlja bazu podataka (metode za pristup i komunikaciju)
    /// </summary>
    public sealed class Database
    {
        readonly string _categoryTable = "Kategorija";
        readonly string _bookTable = "Knjiga";
        readonly string _billTable = "Racun";
        OleDbConnection connection;
        private static Database instance = null;

        public IList<Book> AllBooks { get; }
        public IList<Category> AllCategories { get; }
        public IList<Bill> AllBills { get; }

        public static Database Instance
        {
            get
            {
                if (instance==null)
                {
                    instance = new Database();
                }
                return instance;
            }
        }

        private Database()
        {
            connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\VISER\TVP\Projekat 2\Libra POS\Libra POS\Data\Knjizara.accdb'");
            AllBooks = new List<Book>();
            AllCategories = new List<Category>();
            AllBills = new List<Bill>();
            ReadAllData();
        }

        public void ReadAllData()
        {
            AllBooks.Clear();
            AllCategories.Clear();
            AllBills.Clear();
            connection.Open();
            OleDbCommand command = new OleDbCommand(SQLHandler.SelectFrom(_bookTable), connection);
            OleDbDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                Book newBook = new Book
                    (Int32.Parse(reader[0].ToString()), 
                    reader[1].ToString(), 
                    reader[2].ToString(), 
                    Double.Parse(reader[3].ToString()), 
                    Int32.Parse(reader[4].ToString()), 
                    Int32.Parse(reader[5].ToString()));
                AllBooks.Add(newBook);
            }

            reader.Close();

            command.CommandText = SQLHandler.SelectFrom(_categoryTable);
            reader = command.ExecuteReader();

            while(reader.Read())
            {
                Category newCategory = new Category
                    (Int32.Parse(reader[0].ToString()), 
                    reader[1].ToString());
                AllCategories.Add(newCategory);
            }

            reader.Close();

            command.CommandText = SQLHandler.SelectFrom(_billTable);
            reader = command.ExecuteReader();

            while(reader.Read())
            {
                Bill newBill = new Bill
                    (Int32.Parse(reader[0].ToString()),
                    Double.Parse(reader[1].ToString()),
                    DateTime.Parse(reader[2].ToString()),
                    reader[3].ToString());

                AllBills.Add(newBill);
            }

            reader.Close();
            connection.Close();
        }

        public int InsertBook(Book newBook)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand(SQLHandler.InsertIntoBook(), connection);
            command.CommandType = System.Data.CommandType.Text;
            command.Parameters.AddWithValue("@title", newBook.Name);
            command.Parameters.AddWithValue("@author", newBook.Author);
            command.Parameters.AddWithValue("@price", newBook.Price);
            command.Parameters.AddWithValue("@discount", newBook.Discount);
            command.Parameters.AddWithValue("@category", newBook.CategoryId);
            int result = command.ExecuteNonQuery();
            connection.Close();
            ReadAllData();

            return result;
        }

        public int InsertBill(Bill newBill)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand(SQLHandler.InsertIntoBills(), connection);
            command.CommandType = System.Data.CommandType.Text;
            command.Parameters.AddWithValue("@price", newBill.TotalPrice);
            command.Parameters.AddWithValue("@date", newBill.Date.Date);
            command.Parameters.AddWithValue("@time", newBill.Date.TimeOfDay);
            int result = command.ExecuteNonQuery();
            connection.Close();
            ReadAllData();

            return result;
        }
    }
}
