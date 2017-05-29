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
            string middleName, string userStatus)
            : base(userId, lastName, firstName, middleName, userStatus)
        {

        }
    }
}
