using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthCinema.Domain.Models
{
    class ListOfPlacesInHalls
    {
        public ListOfPlacesInHalls(List<PlaceInHall> places)
        {
            Places = places;
        }
        public List<PlaceInHall> Places { get; set; }
        
        public void AddPlacesInHall(int placeId, int hall, int row, int placeNumber)
        {
            PlaceInHall place = new PlaceInHall(placeId, hall, row, placeNumber);
            Places.Add(place);
        }
    }
}
