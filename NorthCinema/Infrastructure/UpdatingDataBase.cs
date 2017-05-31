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
    class UpdatingDataBase
    {
        private string pathOfDataBase = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Жанат\documents\visual studio 2015\Projects\NorthCinema\NorthCinema\Cinema.mdf;Integrated Security = True";
        public void UpdateInDatabase(Film film)
        {
            SqlConnection connectToDateBase = new SqlConnection(pathOfDataBase);
            using (connectToDateBase)
            {
                SqlCommand command = new SqlCommand(
                ("UPDATE [FILMS]" +
                "SET NAME_FILM = @NAME_FILM, LENGTH_FILM = @LENGTH_FILM, AGE_LIMIT = @AGE_LIMIT, TICKET_PRICE = @TICKET_PRICE"
                + " WHERE @FILM_ID = FILM_ID;"),
                connectToDateBase);
                command.Connection.Open();
                command.Parameters.AddWithValue("@FILM_ID", film.FilmId);
                command.Parameters.AddWithValue("@NAME_FILM", film.FilmName);
                command.Parameters.AddWithValue("@LENGTH_FILM", film.LengthOfFilm);
                command.Parameters.AddWithValue("@AGE_LIMIT", film.AgeLimit);
                command.Parameters.AddWithValue("@TICKET_PRICE", film.Price);
                command.ExecuteNonQuery();
            }
        }
        public void UpdateInDatabase(Hall hall)
        {
            SqlConnection connectToDateBase = new SqlConnection(pathOfDataBase);
            using (connectToDateBase)
            {
                SqlCommand command = new SqlCommand(
                ("UPDATE [HALLS]" +
                "SET NAME_HALL = @NAME_HALL" +
                " WHERE @HALL_ID = HALL_ID;"),
                connectToDateBase);
                command.Connection.Open();
                command.Parameters.AddWithValue("@HALL_ID", hall.HallId);
                command.Parameters.AddWithValue("@NAME_HALL", hall.HallName);
                command.ExecuteNonQuery();
            }
        }
        public void UpdateInDatabase(CashierUser cashier)
        {
            SqlConnection connectToDateBase = new SqlConnection(pathOfDataBase);
            using (connectToDateBase)
            {
                SqlCommand command = new SqlCommand(
                ("UPDATE [USERS]" +
                "SET USER_LOGIN = @USER_LOGIN, USER_PASSWORD = @USER_PASSWORD, FIRST_NAME = @FIRST_NAME," +
                "LAST_NAME = @LAST_NAME, SECOND_NAME = @SECOND_NAME, STATUS_USER = @STATUS_USER "
                +"WHERE @USER_ID = USER_ID;"),
                connectToDateBase);
                command.Connection.Open();
                command.Parameters.AddWithValue("@USER_ID", cashier.UserId);
                command.Parameters.AddWithValue("@USER_LOGIN", cashier.Login);
                command.Parameters.AddWithValue("@USER_PASSWORD", cashier.Password);
                command.Parameters.AddWithValue("@FIRST_NAME", cashier.FirstName);
                command.Parameters.AddWithValue("@LAST_NAME", cashier.LastName);
                command.Parameters.AddWithValue("@SECOND_NAME", cashier.SecondName);
                command.Parameters.AddWithValue("@STATUS_USER", cashier.UserStatus);
                command.ExecuteNonQuery();
            }
        }
    }
}
