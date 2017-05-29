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
        private string login;
        private string password;
        public string status;
        public CheckingAuthorization(ReadingFromDateBase reading, string login, string password)
        {
            this.reading = reading;
            this.login = login;
            this.password = password;
        }
        public void CheckAuthorization()
        {
            //с базы данных столбцы считать
            /*
            foreach (var i in reading.adminList)
            {
                if ((login == i.login) && (password == i.password))
                {
                    status = i.statusUser;
                }
            }
            foreach (var i in reading.cashierList)
            {
                if ((login == i.login) && (password == i.password))
                {
                    status = i.statusUser;
                }
            }
            foreach (var i in reading.visitorList)
            {
                if ((login == i.login) && (password == i.password))
                {
                    status = i.statusUser;
                }
            }
            */
        }
    }
}
