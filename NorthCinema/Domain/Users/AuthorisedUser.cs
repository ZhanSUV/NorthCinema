using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthCinema.Domain
{
    public class AuthorisedUser
    {
        public AuthorisedUser(int userId, string lastName, string firstName, 
            string secondName, string userStatus, string login, string password)
        {
            UserId = userId;
            LastName = lastName;
            FirstName = firstName;
            SecondName = secondName;
            UserStatus = userStatus;
            Login = login;
            Password = password;
        }
        public int UserId { get; private set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string UserStatus { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
