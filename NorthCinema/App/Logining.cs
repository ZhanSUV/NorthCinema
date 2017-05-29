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
        public readonly int userId;
        public readonly string lastName;
        public readonly string firstName;
        public readonly string secondName;
        public readonly string status;
        public readonly string login;
        public readonly string password;
        public Logining(string login, string password)
        {
            ReadingFromDateBase readBase = new ReadingFromDateBase();
            readBase.ReadFromDateBase();
            CheckingAuthorization checking = new CheckingAuthorization(readBase, login, password);
            status = checking.CheckAuthorization();
            lastName = checking.lastName;
            secondName = checking.secondName;
            firstName = checking.firstName;
            login = checking.login;
            password = checking.password;
            userId = checking.userId;
        }
    }
}
