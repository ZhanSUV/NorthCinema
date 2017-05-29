using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthCinema.Domain
{
    class Genre
    {
        public Genre(int genreId, int filmId, string genreName)
        {
            GenreId = genreId;
            FilmId = filmId;
            GenreName = genreName;
        }
        public int GenreId { get; private set; }
        public int FilmId { get; private set; }
        public string GenreName { get; private set; }
    }
}
