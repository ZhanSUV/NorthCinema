using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthCinema.Domain.Models
{
    class ListOfTotalPercents
    {
        public ListOfTotalPercents(List<TotalPercent> totalPercents)
        {
            TotalPercents = totalPercents;
        }
        public List<TotalPercent> TotalPercents { get; set; }
    }
}
