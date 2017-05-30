using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using NorthCinema.Domain.Models;

namespace NorthCinema.Infrastructure
{
    class UpdateDataBase
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
    }
}
