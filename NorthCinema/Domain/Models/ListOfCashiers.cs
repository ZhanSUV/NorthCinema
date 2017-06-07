using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthCinema.Domain.Users;

namespace NorthCinema.Domain.Models
{
    public class ListOfCashiers
    {
        public ListOfCashiers(List<Users.CashierUser> cashiers)
        {
            Cashiers = cashiers;
        }
        public List<Users.CashierUser> Cashiers { get; set; }
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
        public void AddCashierInList(int userId, string lastName, string firstName,
            string secondName, string userStatus, string login, string password)
        {
            CashierUser cashier = new CashierUser(userId, lastName, firstName,
            secondName, userStatus, login, password);
            Cashiers.Add(cashier);
        }
    }
}
