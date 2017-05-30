using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthCinema.Domain.Models
{
    class ListOfFilms
    {
        public ListOfFilms(List<Film> films)
        {
            Films = films;
        }
        public List<Film> Films { get; private set; }
        /*public static void AddFilm<T>(T obj)
            where T : Users.AdminUser
        {
            
            //класс для записи в бд
        }
        public static void EditFilm<T>(T obj)
           where T : Users.AdminUser
        {
            //класс для записи в бд
        }
        public static void DeleteFilm<T>(T obj)
           where T : Users.AdminUser
        {
            //класс для записи в бд
        }
        // этот метод может не пригодится
        public static void ShowList()
        {
            //вывод на форме
        }
        */
        public void AddFilmInList(int filmId, string filmName, int lengthOfFilm, int ageLimit, double price)
        {
            Film film = new Film(filmId, filmName, lengthOfFilm, ageLimit, price);
            Films.Add(film);
        }
    }
}
