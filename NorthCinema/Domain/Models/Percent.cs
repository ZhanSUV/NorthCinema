using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthCinema.Domain.Models
{
    class Percent
    {
        public Percent(int percentId, string percentName, string percentDescription, string percentType, int percentValue)
        {
            PercentId = percentId;
            PercentName = percentName;
            PercentDescription = percentDescription;
            PercentType = percentType;
            PercentValue = percentValue;
        }
        public int PercentId { get; private set; }
        public string PercentName { get; private set; }
        public string PercentDescription { get; private set; }
        public string PercentType { get; private set; }
        public int PercentValue { get; private set; }
    }
}
