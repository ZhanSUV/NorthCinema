using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthCinema.Domain.Models
{
    class Hall
    {
        public Hall(int hallId, string hallName, List<PlaceInHall> places)
        {
            HallId = hallId;
            HallName = hallName;
            Places = places;
        }
        public int HallId { get; private set; }
        public string HallName { get; private set; }
        public List<PlaceInHall> Places { get; private set; }
    }
}
