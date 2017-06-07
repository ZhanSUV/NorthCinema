using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthCinema.Infrastructure;

namespace NorthCinema.Domain.Models
{
    public class Hall
    {
        public Hall(int hallId, string hallName, int seatingCapacity, int placesInRow)
        {
            HallId = hallId;
            HallName = hallName;
            SeatingCapacity = seatingCapacity;
            PlacesInRow = placesInRow;
            CreatePlaces();
        }
        public int HallId { get; set; }
        public string HallName { get; set; }
        public int SeatingCapacity { get; set; }
        public int PlacesInRow { get; set; }
        public List<PlaceInHall> Places = new List<PlaceInHall>();
        
        public void CreatePlaces()
        {
            ListOfPlacesInHalls placesList;
            ReadingFromDateBase reading = new ReadingFromDateBase();
            placesList = reading.ReadAllPlacesOfAllHalls();
            int placeId = 1;
            if (placesList.Places.Count != 0)
            {
                placeId = placesList.Places.Count + 1;
            }
            bool notEven = false;
            int leftPlaces = SeatingCapacity % PlacesInRow;
            int tempPlacesInRow = PlacesInRow;
            int rows = 0;
            if (leftPlaces != 0)
            {
                notEven = true;
                rows = (SeatingCapacity / PlacesInRow) + 1;
            }
            else
            {
                rows = SeatingCapacity / PlacesInRow;
            }
            for (int i = 1; i <= rows; i++)
            {
                if (i == rows && notEven)
                {
                    tempPlacesInRow = leftPlaces;
                }
                for (int j = 1; j <= tempPlacesInRow; j++)
                {
                    PlaceInHall place = new PlaceInHall(placeId, HallId, i, j);
                    Places.Add(place);
                }
            }
            
        }
        
    }
}
