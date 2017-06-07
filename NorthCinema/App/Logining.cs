using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthCinema.Infrastructure;

namespace NorthCinema.App
{
    class Logining
    {
        public Logining(string login, string password)
        {
            ReadingFromDateBase readBase = new ReadingFromDateBase();
            readBase.ReadFromDateBase();
            CheckingAuthorization checking = new CheckingAuthorization(readBase, login, password);
            status = checking.CheckAuthorization();
            LastName = checking.lastName;
            SecondName = checking.secondName;
            FirstName = checking.firstName;
            Login = checking.login;
            Password = checking.password;
            UserId = checking.userId;
        }
        public int UserId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string status { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
