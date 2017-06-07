using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthCinema.Domain.Models
{
    public class PlaceInHall
    {
        public PlaceInHall(int placeId, int hallId, int row, int placeNumber)
        {
            PlaceId = placeId;
            HallId = hallId;
            Row = row;
            PlaceNumber = placeNumber;
        }
        public int PlaceId { get; set; }
        public int HallId { get; set; }
        public int Row { get; set; }
        public int PlaceNumber { get; set; }
    }
}
