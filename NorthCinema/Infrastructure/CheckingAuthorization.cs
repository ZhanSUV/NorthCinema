using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthCinema.Infrastructure
{
    class CheckingAuthorization
    {
        private ReadingFromDateBase reading;
        public int userId;
        public string lastName;
        public string firstName;
        public string secondName;
        public string login;
        public string password;
        public string status;
        public CheckingAuthorization(ReadingFromDateBase reading, string login, string password)
        {
            this.reading = reading;
            this.login = login;
            this.password = password;
        }
        public string CheckAuthorization()
        {
            foreach (var i in reading.adminList)
            {
                if ((login == i.Login) && (password == i.Password))
                {
                    userId = i.UserId;
                    lastName = i.LastName;
                    firstName = i.FirstName;
                    secondName = i.SecondName;
                    status = i.UserStatus;
                }
            }
            foreach (var i in reading.cashierList)
            {
                if ((login == i.Login) && (password == i.Password))
                {
                    userId = i.UserId;
                    lastName = i.LastName;
                    firstName = i.FirstName;
                    secondName = i.SecondName;
                    status = i.UserStatus;
                }
            }
            foreach (var i in reading.visitorList)
            {
                if ((login == i.Login) && (password == i.Password))
                {
                    userId = i.UserId;
                    lastName = i.LastName;
                    firstName = i.FirstName;
                    secondName = i.SecondName;
                    status = i.UserStatus;
                }
            }
            return status;
        }
    }
}
