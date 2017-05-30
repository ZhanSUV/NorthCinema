using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using NorthCinema.Domain.Models;

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
    }
}
