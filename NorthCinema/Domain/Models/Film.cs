using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthCinema.Domain.Models
{
    class Film
    {
        public Film(int filmId ,string filmName, int lengthOfFilm, int ageLimit, double price)
        {
            FilmId = filmId;
            FilmName = filmName;
            LengthOfFilm = lengthOfFilm;
            AgeLimit = ageLimit;
            Price = price;
        }
        public int FilmId { get; set; }
        public string FilmName { get; set; }
        public int LengthOfFilm { get; set; }
        public int AgeLimit { get; set; }
        public double Price { get; set; }
    }
}
