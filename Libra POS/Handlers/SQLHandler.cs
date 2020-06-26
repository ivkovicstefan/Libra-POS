using Libra_POS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libra_POS.Handlers
{
    class SQLHandler
    {
        public static string SelectFrom(string tableName)
        {
            return "select * from " + tableName;
        }

        public static string InsertIntoBook()
        {
            return "insert into Knjiga(naziv, autor, cena, popust, id_kategorija) values(@title, @author, @price, @discount, @category)";
        }

        public static string InsertIntoBills()
        {
            return "insert into Racun(cena, datum, vreme) values(@price, @date, @time)";
        }

    }
}
