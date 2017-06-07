using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthCinema.Domain.Models
{
    public class Percent
    {
        public Percent(int percentId, string percentType, string percentDescription, int percentValue)
        {
            PercentId = percentId;
            PercentType = percentType;
            PercentDescription = percentDescription;
            PercentValue = percentValue;
        }
        public int PercentId { get; set; }
        public string PercentType { get; set; }
        public string PercentDescription { get; set; }
        public int PercentValue { get; set; }
    }
}
