using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthCinema.Domain.Models
{
    class ListOfHalls
    {
        public ListOfHalls(List<Hall> halls)
        {
            Halls = halls;
        }
        public List<Hall> Halls { get; private set; }
        public static void AddFilm<T>(T obj)
           where T : Users.AdminUser
        {

        }
        public static void EditFilm<T>(T obj)
           where T : Users.AdminUser
        {

        }
        public static void DeleteFilm<T>(T obj)
           where T : Users.AdminUser
        {

        }
        public static void ShowList()
        {

        }
    }
}
