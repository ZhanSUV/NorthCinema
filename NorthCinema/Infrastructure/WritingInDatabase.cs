using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using NorthCinema.Domain.Models;

namespace NorthCinema.Infrastructure
{

    class WritingInDatabase
    {
        private string pathOfDataBase = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=
                                        C:\Users\Жанат\documents\visual studio 2015\Projects\NorthCinema\NorthCinema\
                                        Cinema.mdf;Integrated Security = True";
        public void WriteInDatabase(Film film)
        {
            SqlConnection connectToDateBase = new SqlConnection(pathOfDataBase);
            using (connectToDateBase)
            {
                SqlCommand command = new SqlCommand(
                ("INSERT INTO [FILMS] (NAME_FILM, LENGTH_FILM, AGE_LIMIT, TICKET_PRICE)" +  
                "VALUES (@NAME_FILM, @LENGTH_FILM, @AGE_LIMIT, @TICKET_PRICE) FROM [FILMS];"),
                connectToDateBase);
                command.Parameters.AddWithValue("@NAME_FILM", film.FilmName);
                command.Parameters.AddWithValue("@LENGTH_FILM", film.LengthOfFilm);
                command.Parameters.AddWithValue("@AGE_LIMIT", film.AgeLimit);
                command.Parameters.AddWithValue("@TICKET_PRICE", film.Price);
            }
        }
    }
}
