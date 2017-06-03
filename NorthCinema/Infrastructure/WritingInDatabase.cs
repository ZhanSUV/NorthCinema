using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using NorthCinema.Domain.Models;
using NorthCinema.Domain.Users;

namespace NorthCinema.Infrastructure
{
    class WritingInDatabase
    {
        private string pathOfDataBase = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Жанат\documents\visual studio 2015\Projects\NorthCinema\NorthCinema\Cinema.mdf;Integrated Security = True";
        public void WriteInDatabase(Film film)
        {
            SqlConnection connectToDateBase = new SqlConnection(pathOfDataBase);
            using (connectToDateBase)
            {
                SqlCommand command = new SqlCommand(
                ("INSERT INTO [FILMS] (NAME_FILM, LENGTH_FILM, AGE_LIMIT, TICKET_PRICE)" +
                "VALUES (@NAME_FILM, @LENGTH_FILM, @AGE_LIMIT, @TICKET_PRICE);"),
                connectToDateBase);
                command.Connection.Open();
                command.Parameters.AddWithValue("@NAME_FILM", film.FilmName);
                command.Parameters.AddWithValue("@LENGTH_FILM", film.LengthOfFilm);
                command.Parameters.AddWithValue("@AGE_LIMIT", film.AgeLimit);
                command.Parameters.AddWithValue("@TICKET_PRICE", film.Price);
                command.ExecuteNonQuery();
            }
        }
        public void WriteInDatabase(Hall hall)
        {
            SqlConnection connectToDateBase = new SqlConnection(pathOfDataBase);
            using (connectToDateBase)
            {
                SqlCommand command = new SqlCommand(
                ("INSERT INTO [HALLS] (NAME_HALL)" +
                "VALUES (@NAME_HALL);"),
                connectToDateBase);
                command.Connection.Open();
                command.Parameters.AddWithValue("@NAME_HALL", hall.HallName);
                command.ExecuteNonQuery();
            }
        }
        public void WriteInDatabase(CashierUser cashier)
        {
            SqlConnection connectToDateBase = new SqlConnection(pathOfDataBase);
            using (connectToDateBase)
            {
                SqlCommand command = new SqlCommand(
                ("INSERT INTO [USERS] (USER_LOGIN, USER_PASSWORD, FIRST_NAME, LAST_NAME, SECOND_NAME, STATUS_USER)" +
                "VALUES (@USER_LOGIN, @USER_PASSWORD, @FIRST_NAME, @LAST_NAME, @SECOND_NAME, @STATUS_USER);"),
                connectToDateBase);
                command.Connection.Open();
                command.Parameters.AddWithValue("@USER_LOGIN", cashier.Login);
                command.Parameters.AddWithValue("@USER_PASSWORD", cashier.Password);
                command.Parameters.AddWithValue("@FIRST_NAME", cashier.FirstName);
                command.Parameters.AddWithValue("@LAST_NAME", cashier.LastName);
                command.Parameters.AddWithValue("@SECOND_NAME", cashier.SecondName);
                command.Parameters.AddWithValue("@STATUS_USER", cashier.UserStatus);
                command.ExecuteNonQuery();
            }
        }
        public void WriteInDatabase(Session session)
        {
            SqlConnection connectToDateBase = new SqlConnection(pathOfDataBase);
            using (connectToDateBase)
            {
                SqlCommand command = new SqlCommand(
                ("INSERT INTO [SESSIONS] (HALL_ID, FILM_ID, DATE_SESSION, TIME_SESSION)" +
                "VALUES (@HALL_ID, @FILM_ID, @DATE_SESSION, @TIME_SESSION);"),
                connectToDateBase);
                command.Connection.Open();
                command.Parameters.AddWithValue("@HALL_ID", session.HallSession.HallId);
                command.Parameters.AddWithValue("@FILM_ID", session.FilmSession.FilmId);
                command.Parameters.AddWithValue("@DATE_SESSION", session.DateSession);
                command.Parameters.AddWithValue("@TIME_SESSION", session.TimeSession);
                command.ExecuteNonQuery();
            }
        }
        public void WriteInDatabase(Percent percent)
        {
            SqlConnection connectToDateBase = new SqlConnection(pathOfDataBase);
            using (connectToDateBase)
            {
                SqlCommand command = new SqlCommand(
                ("INSERT INTO [PERCENTAGES] (DISCOUNT_MARKUP, DESCRIPTION, PERCENT1)" +
                "VALUES (@DISCOUNT_MARKUP, @DESCRIPTION, @PERCENT1);"),
                connectToDateBase);
                command.Connection.Open();
                command.Parameters.AddWithValue("@DISCOUNT_MARKUP", percent.PercentType);
                command.Parameters.AddWithValue("@DESCRIPTION", percent.PercentDescription);
                command.Parameters.AddWithValue("@PERCENT1", percent.PercentValue);
                command.ExecuteNonQuery();
            }
        }
    }
}
