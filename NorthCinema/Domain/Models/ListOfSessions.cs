using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthCinema.Domain.Models
{
    class ListOfSessions
    {
        public ListOfSessions(List<Session> sessions)
        {
            Sessions = sessions;
        }
        public List<Session> Sessions { get; private set; }
        public static void AddSession<T>(T obj)
           where T : Users.AdminUser
        {

        }
        public static void EditSession<T>(T obj)
           where T : Users.AdminUser
        {

        }
        public static void DeleteSession<T>(T obj)
           where T : Users.AdminUser
        {

        }
        public static void ShowList()
        {

        }
    }
}
