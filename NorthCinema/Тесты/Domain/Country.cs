using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthCinema.Domain
{
    class Country
    {
        public Country(int countryId, int filmId, string countryName)
        {
            CountryId = countryId;
            FilmId = filmId;
            CountryName = countryName;
        }
        public int CountryId { get; private set; }
        public int FilmId { get; private set; }
        public string CountryName { get; private set; }
    }
}
