using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthCinema.Domain
{
    class Percentage
    {
        public Percentage(int percentId, int discountMarkup, string description, int percent)
        {
            PercentId = percentId;
            DiscountMarkup = discountMarkup;
            Description = description;
            Percent = percent;
        }
        public int PercentId { get; private set; }
        public int DiscountMarkup { get; private set; }
        public string Description { get; private set; }
        public int Percent { get; private set; }
    }
}
