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
    class DeletingFromDateBase
    {
        private string pathOfDataBase = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Жанат\documents\visual studio 2015\Projects\NorthCinema\NorthCinema\Cinema.mdf;Integrated Security = True";
        public void DeleteFromDatabase(Film film)
        {
            SqlConnection connectToDateBase = new SqlConnection(pathOfDataBase);
            using (connectToDateBase)
            {
                SqlCommand command = new SqlCommand(
                ("DELETE FROM [FILMS] WHERE FILM_ID = @FILM_ID"),
                connectToDateBase);
                command.Connection.Open();
                command.Parameters.AddWithValue("@FILM_ID", film.FilmId);
                command.ExecuteNonQuery();
            }
        }
        public void DeleteFromDatabase(Hall hall)
        {
            SqlConnection connectToDateBase = new SqlConnection(pathOfDataBase);
            using (connectToDateBase)
            {
                SqlCommand command = new SqlCommand(
                ("DELETE FROM [HALLS] WHERE HALL_ID = @HALL_ID"),
                connectToDateBase);
                command.Connection.Open();
                command.Parameters.AddWithValue("@HALL_ID", hall.HallId);
                command.ExecuteNonQuery();
            }
        }
        public void DeleteFromDatabase(PlaceInHall place)
        {
            SqlConnection connectToDateBase = new SqlConnection(pathOfDataBase);
            using (connectToDateBase)
            {
                SqlCommand command = new SqlCommand(
                ("DELETE FROM [PLACESINHALLS] WHERE PLACE_ID = @PLACE_ID"),
                connectToDateBase);
                command.Connection.Open();
                command.Parameters.AddWithValue("@PLACE_ID", place.PlaceId);
                command.ExecuteNonQuery();
            }
        }
        public void DeleteFromDatabase(List<PlaceInHall> places)
        {
            SqlConnection connectToDateBase = new SqlConnection(pathOfDataBase);
            using (connectToDateBase)
            {
                SqlCommand command = new SqlCommand(
                ("DELETE FROM [PLACESINHALLS] WHERE HALL_ID = @HALL_ID"),
                connectToDateBase);
                command.Connection.Open();
                command.Parameters.AddWithValue("@HALL_ID", places[0].HallId);
                command.ExecuteNonQuery();
            }
        }
        public void DeleteFromDatabase(CashierUser cashier)
        {
            SqlConnection connectToDateBase = new SqlConnection(pathOfDataBase);
            using (connectToDateBase)
            {
                SqlCommand command = new SqlCommand(
                ("DELETE FROM [USERS] WHERE @USER_ID = USER_ID;"),
                connectToDateBase);
                command.Connection.Open();
                command.Parameters.AddWithValue("@USER_ID", cashier.UserId);
                command.ExecuteNonQuery();
            }
        }
        public void DeleteFromDatabase(Session session)
        {
            SqlConnection connectToDateBase = new SqlConnection(pathOfDataBase);
            using (connectToDateBase)
            {
                SqlCommand command = new SqlCommand(
                ("DELETE FROM [SESSIONS] WHERE @SESSION_ID = SESSION_ID;"),
                connectToDateBase);
                command.Connection.Open();
                command.Parameters.AddWithValue("@SESSION_ID", session.SessionId);
                command.ExecuteNonQuery();
            }
        }
        public void DeleteFromDatabase(Percent percent)
        {
            SqlConnection connectToDateBase = new SqlConnection(pathOfDataBase);
            using (connectToDateBase)
            {
                SqlCommand command = new SqlCommand(
                ("DELETE FROM [PERCENTAGES] WHERE @PERCENT_ID = PERCENT_ID;"),
                connectToDateBase);
                command.Connection.Open();
                command.Parameters.AddWithValue("@PERCENT_ID", percent.PercentId);
                command.ExecuteNonQuery();
            }
        }
    }
}
