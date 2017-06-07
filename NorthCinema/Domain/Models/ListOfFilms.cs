using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthCinema.Domain.Models
{
    public class ListOfFilms
    {
        public ListOfFilms(List<Film> films)
        {
            Films = films;
        }
        public List<Film> Films { get; private set; }

        public void AddFilmInList(int filmId, string filmName, int lengthOfFilm, int ageLimit, double price)
        {
            Film film = new Film(filmId, filmName, lengthOfFilm, ageLimit, price);
            Films.Add(film);
        }
    }
}
