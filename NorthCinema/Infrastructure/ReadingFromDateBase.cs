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
                            AdminUser admin = new AdminUser(reader.GetInt32(0), reader.GetString(4), reader.GetString(3),
                                reader.GetString(5), reader.GetString(6), reader.GetString(1), reader.GetString(2));
                            adminList.Add(admin);
                        }
                        if (reader.GetString(6).ToUpper() == "CASHIER")
                        {
                            CashierUser cashier = new CashierUser(reader.GetInt32(0), reader.GetString(4), reader.GetString(3),
                               reader.GetString(5), reader.GetString(6), reader.GetString(1), reader.GetString(2));
                            cashierList.Add(cashier);
                        }
                        if (reader.GetString(6).ToUpper() == "VISITOR")
                        {
                            VisitorUser visitor = new VisitorUser(reader.GetInt32(0), reader.GetString(4), reader.GetString(3),
                                reader.GetString(5), reader.GetString(6), reader.GetString(1), reader.GetString(2));
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
            int sessionId;
            int filmId;
            int hallId;
            DateTime dateSession;
            TimeSpan timeSession;
            List<PlaceInHall> places = new List<PlaceInHall>();
            List<Session> sessionList = new List<Session>();
            ListOfSessions sessions = new ListOfSessions(sessionList);
            SqlConnection connectToDateBase = new SqlConnection(pathOfDataBase);
            using (connectToDateBase)
            {
                SqlCommand command = new SqlCommand(
                "SELECT SESSION_ID, [SESSIONS].[HALL_ID], [SESSIONS].[FILM_ID], DATE_SESSION, TIME_SESSION," + 
                "NAME_FILM, LENGTH_FILM, AGE_LIMIT, TICKET_PRICE, NAME_HALL FROM [SESSIONS], [FILMS], [HALLS]" + 
                "WHERE [SESSIONS].[HALL_ID] = [HALLS].[HALL_ID] AND [SESSIONS].[FILM_ID] = [FILMS].[FILM_ID];",
                connectToDateBase);
                connectToDateBase.Open();
                SqlDataReader readerSession = command.ExecuteReader();
                if (readerSession.HasRows)
                {
                    while (readerSession.Read())
                    {
                        sessionId = readerSession.GetInt32(0);
                        hallId = readerSession.GetInt32(1);
                        filmId = readerSession.GetInt32(2);
                        dateSession = readerSession.GetDateTime(3);
                        timeSession = readerSession.GetTimeSpan(4);
                        film = new Film(filmId, readerSession.GetString(5), readerSession.GetInt32(6),
                                readerSession.GetInt32(7), readerSession.GetInt32(8));
                        hall = new Hall(hallId, readerSession.GetString(9));
                        Session session = new Session(sessionId, film, hall, dateSession, timeSession);
                        sessionList.Add(session);
                    }
                }
                readerSession.Close();
            }
            return sessions;
        }
        public ListOfHalls ReadHalls()
        {
            List<Hall> hallsList = new List<Hall>();
            SqlConnection connectToDateBase = new SqlConnection(pathOfDataBase);
            using (connectToDateBase)
            {
                SqlCommand command = new SqlCommand(
                "SELECT HALL_ID, NAME_HALL FROM [HALLS];",
                connectToDateBase);
                connectToDateBase.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Hall hall = new Hall(reader.GetInt32(0), reader.GetString(1));
                        hallsList.Add(hall);
                    }
                }
                reader.Close();
            }
            ListOfHalls halls = new ListOfHalls(hallsList);
            return halls;
        }
    }
}
