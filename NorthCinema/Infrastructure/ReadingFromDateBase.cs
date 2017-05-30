using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using NorthCinema.Domain.Users;
using NorthCinema.Domain.Models;

namespace NorthCinema.Infrastructure
{
    class ReadingFromDateBase
    {
        public readonly List<Domain.Users.AdminUser> adminList = new List<Domain.Users.AdminUser>();
        public readonly List<Domain.Users.CashierUser> cashierList = new List<Domain.Users.CashierUser>();
        public readonly List<Domain.Users.VisitorUser> visitorList = new List<Domain.Users.VisitorUser>();
        private string pathOfDataBase = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Жанат\documents\visual studio 2015\Projects\NorthCinema\NorthCinema\Cinema.mdf;Integrated Security = True";
        public void ReadFromDateBase()
        {
            SqlConnection connectToDateBase = new SqlConnection(pathOfDataBase);
            using (connectToDateBase)
            {
                SqlCommand command = new SqlCommand(
                "SELECT USER_ID, USER_LOGIN, USER_PASSWORD, FIRST_NAME, LAST_NAME, SECOND_NAME, STATUS_USER FROM [USERS];",
                connectToDateBase);
                connectToDateBase.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (reader.GetString(6).ToUpper() == "ADMIN")
                        {
                            AdminUser admin = new AdminUser(reader.GetInt32(0), reader.GetString(4), reader.GetString(5),
                                reader.GetString(3), reader.GetString(6), reader.GetString(1), reader.GetString(2));
                            adminList.Add(admin);
                        }
                        if (reader.GetString(6).ToUpper() == "CASHIER")
                        {
                            CashierUser cashier = new CashierUser(reader.GetInt32(0), reader.GetString(4), reader.GetString(5),
                               reader.GetString(3), reader.GetString(6), reader.GetString(1), reader.GetString(2));
                            cashierList.Add(cashier);
                        }
                        if (reader.GetString(6).ToUpper() == "VISITOR")
                        {
                            VisitorUser visitor = new VisitorUser(reader.GetInt32(0), reader.GetString(4), reader.GetString(5),
                                reader.GetString(3), reader.GetString(6), reader.GetString(1), reader.GetString(2));
                            visitorList.Add(visitor);
                        }
                    }
                }
                reader.Close();
            }
        }
        public ListOfFilms ReadFilms()
        {
            List<Film> filmList = new List<Film>();
            SqlConnection connectToDateBase = new SqlConnection(pathOfDataBase);
            using (connectToDateBase)
            {
                SqlCommand command = new SqlCommand(
                "SELECT FILM_ID, NAME_FILM, LENGTH_FILM, AGE_LIMIT, TICKET_PRICE FROM [FILMS];",
                connectToDateBase);
                connectToDateBase.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Film film = new Film(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2),
                            reader.GetInt32(3), reader.GetInt32(4));
                        filmList.Add(film);
                    }
                }
                reader.Close();
            }
            ListOfFilms films = new ListOfFilms(filmList);
            return films;
        }
        public ListOfSessions ReadSessions()
        {
            Hall hall;
            Film film;
            int filmId;
            int hallId;
            List<PlaceInHall> places = new List<PlaceInHall>();
            List<Session> sessionList = new List<Session>();
            ListOfSessions sessions = new ListOfSessions(sessionList);
            SqlConnection connectToDateBase = new SqlConnection(pathOfDataBase);
            using (connectToDateBase)
            {
                SqlCommand command = new SqlCommand(
                "SELECT SESSION_ID, HALL_ID, FILM_ID, DATE_SESSION, TIME_SESSION FROM [SESSIONS];",
                connectToDateBase);
                connectToDateBase.Open();
                SqlDataReader readerSession = command.ExecuteReader();
                if (readerSession.HasRows)
                {
                    while (readerSession.Read())
                    {
                        hallId = readerSession.GetInt32(1);
                        filmId = readerSession.GetInt32(2);
                        SqlCommand readFilm = new SqlCommand(
                        "SELECT FILM_ID, NAME_FILM, LENGTH_FILM, AGE_LIMIT, TICKET_PRICE FROM [FILMS] WHERE FILM_ID = " + filmId + ";",
                        connectToDateBase);
                        connectToDateBase.Open();
                        SqlDataReader readerFilm = readFilm.ExecuteReader();
                        film = new Film(readerFilm.GetInt32(0), readerFilm.GetString(1), readerFilm.GetInt32(2),
                                readerFilm.GetInt32(3), readerFilm.GetInt32(4));
                        readerFilm.Close();

                        SqlCommand readHall = new SqlCommand(
                       "SELECT HALL_ID, NAME_HALL FROM [HALLS] WHERE HALL_ID = " + hallId + ";",
                       connectToDateBase);
                        connectToDateBase.Open();
                        SqlDataReader readerHall = readFilm.ExecuteReader();
                        hall = new Hall(readerHall.GetInt32(0), readerHall.GetString(1));
                        SqlCommand readPlaces = new SqlCommand(
                        "SELECT PLACE_ID, HALL_ID, ROW_PLACES, PLACE FROM [PLACESINHALLS] WHERE HALL_ID = " + hallId + ";",
                        connectToDateBase);
                        connectToDateBase.Open();
                        SqlDataReader readerPlaces = readFilm.ExecuteReader();
                        if (readerPlaces.HasRows)
                        {
                            while (readerPlaces.Read())
                            {
                                PlaceInHall place = new PlaceInHall(readerPlaces.GetInt32(0), hall, readerPlaces.GetInt32(2), readerPlaces.GetInt32(3));
                                places.Add(place);
                            }
                        }
                        readerPlaces.Close();
                        // здесь еще нужен запрос из PLACESINHALLS
                        //hall = new Hall()
                        readerHall.Close();
                        // вот тут я сломался, придется несколько запросов делать, чтобы объект Session создать
                        Session session = new Session(readerSession.GetInt32(0), film, hall, readerSession.GetDateTime(3), readerSession.GetDateTime(4));
                        //filmList.Add(film);
                        sessionList.Add(session);
                    }
                }
                readerSession.Close();
                return sessions;
            }
            //ListOfFilms films = new ListOfFilms(filmList);
            //return films;
        }
    }
}
