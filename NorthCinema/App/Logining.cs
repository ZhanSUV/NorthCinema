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
            checking.CheckAuthorization();
            // и т.д.
        }
    }
}
