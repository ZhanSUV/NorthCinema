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
        public ListOfCashiers(List<CashierUser> cashiers)
        {
            Cashiers = cashiers;
        }
        public List<CashierUser> Cashiers { get; set; }
        public void AddCashierInList(int userId, string lastName, string firstName,
            string secondName, string userStatus, string login, string password)
        {
            CashierUser cashier = new CashierUser(userId, lastName, firstName,
            secondName, userStatus, login, password);
            Cashiers.Add(cashier);
        }
    }
}
