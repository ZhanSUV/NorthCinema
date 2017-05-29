using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthCinema.Domain.Users
{
    public class AdminUser : AuthorisedUser
    {
        public AdminUser(int userId, string lastName, string firstName,
            string secondName, string userStatus, string login, string password)
            : base(userId, lastName, firstName, secondName, userStatus, login, password)
        {

        }
    }
}
