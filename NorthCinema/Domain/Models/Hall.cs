using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthCinema.Domain.Models
{
    class Hall
    {
        public Hall(int hallId, string hallName, int seatingCapacity, int placesInRow)
        {
            HallId = hallId;
            HallName = hallName;
            SeatingCapacity = seatingCapacity;
            PlacesInRow = placesInRow;
        }
        public int HallId { get; set; }
        public string HallName { get; set; }
        public int SeatingCapacity { get; set; }
        public int PlacesInRow { get; set; }
        public List<PlaceInHall> Places = new List<PlaceInHall>();
    }
}
