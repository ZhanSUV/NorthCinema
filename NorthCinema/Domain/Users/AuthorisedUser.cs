using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthCinema.Domain
{
    public class AuthorisedUser
    {
        public AuthorisedUser(int userId, string lastName, string firstName, string middleName, string userStatus)
        {
            UserId = userId;
            LastName = lastName;
            FirstName = firstName;
            MiddleName = middleName;
            UserStatus = userStatus;
        }
        private int UserId { get; set; }
        public string LastName { get; private set; }
        public string FirstName { get; private set; }
        public string MiddleName { get; private set; }
        private string UserStatus { get; set; }
    }
}
