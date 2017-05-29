using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthCinema.Domain.Models
{
    class PlaceInHall
    {
        public PlaceInHall(int row, int placeNumber)
        {
            Row = row;
            PlaceNumber = placeNumber;
        }
        public int Row { get; private set; }
        public int PlaceNumber { get; private set; }
    }
}
