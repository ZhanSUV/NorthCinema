using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthCinema.Domain
{
    class Format
    {
        public Format(int formatId, int hallId, string formatType, int priceMarkup)
        {

        }
        public int FormatId { get; private set; }
        public int hallId { get; private set; }
        public string FormatType { get; private set; }
        public int Price_markup { get; private set; }
    }
}
