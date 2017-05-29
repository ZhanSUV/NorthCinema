using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthCinema.Domain.Models
{
    class ListOfPercents
    {
        public ListOfPercents(List<Percent> percents)
        {
            Percents = percents;
        }
        public List<Percent> Percents { get; private set; }
        public static void AddPercent<T>(T obj)
           where T : Users.AdminUser
        {

        }
        public static void EditPercent<T>(T obj)
           where T : Users.AdminUser
        {

        }
        public static void DeletePercent<T>(T obj)
           where T : Users.AdminUser
        {

        }
        public static void ShowList()
        {

        }
    }
}
