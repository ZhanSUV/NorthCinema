using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthCinema.Domain.Models
{
    public class ListOfPercents
    {
        public ListOfPercents(List<Percent> percents)
        {
            Percents = percents;
        }
        public List<Percent> Percents { get; set; }
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
        public void AddPercentInList(int percentId, string percentDescription, string percentType, int percentValue)
        {
            Percent percent = new Percent(percentId, percentDescription, percentType, percentValue);
            Percents.Add(percent);
        }
    }
}
