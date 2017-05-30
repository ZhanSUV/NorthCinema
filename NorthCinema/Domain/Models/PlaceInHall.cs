using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthCinema.Domain.Models
{
    class PlaceInHall
    {
        public PlaceInHall(int placeId, Hall hall, int row, int placeNumber)
        {
            PlaceId = placeId;
            Hall = hall;
            Row = row;
            PlaceNumber = placeNumber;
        }
        public int PlaceId { get; private set; }
        public Hall Hall { get; private set; }
        public int Row { get; private set; }
        public int PlaceNumber { get; private set; }
    }
}
