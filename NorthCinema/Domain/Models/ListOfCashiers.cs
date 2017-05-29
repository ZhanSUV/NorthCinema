using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthCinema.Domain.Models
{
    class ListOfCashiers
    {
        public ListOfCashiers(List<Users.CashierUser> cashiers)
        {
            Cashiers = cashiers;
        }
        public List<Users.CashierUser> Cashiers { get; private set; }
        public static void AddCashier<T>(T obj)
           where T : Users.AdminUser
        {

        }
        public static void EditCashier<T>(T obj)
           where T : Users.AdminUser
        {

        }
        public static void DeleteCashier<T>(T obj)
           where T : Users.AdminUser
        {

        }
        public static void ShowList<T>(T obj)
           where T : Users.AdminUser
        {

        }
    }
}
