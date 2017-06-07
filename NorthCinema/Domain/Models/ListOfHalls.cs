using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthCinema.Domain.Models
{
    public class ListOfHalls
    {
        public ListOfHalls(List<Hall> halls)
        {
            Halls = halls;
        }
        public List<Hall> Halls { get; set; }
        public void AddHallInList(int hallId, string hallName, int seatingCapacity, int placesInRow)
        {
            Hall hall = new Hall(hallId, hallName, seatingCapacity, placesInRow);
            Halls.Add(hall);
        }
    }
}
