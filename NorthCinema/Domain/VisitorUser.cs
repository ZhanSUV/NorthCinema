using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthCinema.Domain
{
    class VisitorUser : AuthorisedUser
    {
        public VisitorUser(int userId, string lastName, string firstName, 
            string middleName, string userStatus, string login, string password)
            :base(userId, lastName, firstName, middleName, userStatus, login, password)
        {

        }
    }
}
