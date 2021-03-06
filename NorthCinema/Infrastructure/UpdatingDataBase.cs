﻿using System;
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
                "SET NAME_HALL = @NAME_HALL, SEATING_CAPACITY = @SEATING_CAPACITY, PLACES_IN_ROW = @PLACES_IN_ROW" +
                " WHERE @HALL_ID = HALL_ID;"),
                connectToDateBase);
                command.Connection.Open();
                command.Parameters.AddWithValue("@HALL_ID", hall.HallId);
                command.Parameters.AddWithValue("@NAME_HALL", hall.HallName);
                command.Parameters.AddWithValue("@SEATING_CAPACITY", hall.SeatingCapacity);
                command.Parameters.AddWithValue("@PLACES_IN_ROW", hall.PlacesInRow);
                command.ExecuteNonQuery();
            }
        }
        public void UpdateInDatabase(PlaceInHall place)
        {
            SqlConnection connectToDateBase = new SqlConnection(pathOfDataBase);
            using (connectToDateBase)
            {
                SqlCommand command = new SqlCommand(
                ("UPDATE [PLACESINHALLS]" +
                 "SET HALL_ID = @HALL_ID, ROW_PLACES = @ROW_PLACES, PLACE = @PLACE" +
                 " WHERE @PLACE_ID = PLACE_ID;"),
                connectToDateBase);
                command.Connection.Open();
                command.Parameters.AddWithValue("@PLACE_ID", place.PlaceId);
                command.Parameters.AddWithValue("@HALL_ID", place.HallId);
                command.Parameters.AddWithValue("@ROW_PLACES", place.Row);
                command.Parameters.AddWithValue("@PLACE", place.PlaceNumber);
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
        public void UpdateInDatabase(Session session)
        {
            SqlConnection connectToDateBase = new SqlConnection(pathOfDataBase);
            using (connectToDateBase)
            {
                SqlCommand command = new SqlCommand(
                ("UPDATE [SESSIONS]" +
                "SET HALL_ID = @HALL_ID, FILM_ID = @FILM_ID, DATE_SESSION = @DATE_SESSION," +
                "TIME_SESSION = @TIME_SESSION "
                + "WHERE @SESSION_ID = SESSION_ID;"),
                connectToDateBase);
                command.Connection.Open();
                command.Parameters.AddWithValue("@SESSION_ID", session.SessionId);
                command.Parameters.AddWithValue("@HALL_ID", session.HallSession.HallId);
                command.Parameters.AddWithValue("@FILM_ID", session.FilmSession.FilmId);
                command.Parameters.AddWithValue("@DATE_SESSION", session.DateSession);
                command.Parameters.AddWithValue("@TIME_SESSION", session.TimeSession);
                command.ExecuteNonQuery();
            }
        }
        public void UpdateInDatabase(Percent percent)
        {
            SqlConnection connectToDateBase = new SqlConnection(pathOfDataBase);
            using (connectToDateBase)
            {
                SqlCommand command = new SqlCommand(
                ("UPDATE [PERCENTAGES]" +
                "SET DISCOUNT_MARKUP = @DISCOUNT_MARKUP, DESCRIPTION = @DESCRIPTION," +
                "PERCENT1 = @PERCENT1 "
                + "WHERE @PERCENT_ID = PERCENT_ID;"),
                connectToDateBase);
                command.Connection.Open();
                command.Parameters.AddWithValue("@PERCENT_ID", percent.PercentId);
                command.Parameters.AddWithValue("@DISCOUNT_MARKUP", percent.PercentType);
                command.Parameters.AddWithValue("@DESCRIPTION", percent.PercentDescription);
                command.Parameters.AddWithValue("@PERCENT1", percent.PercentValue);
                command.ExecuteNonQuery();
            }
        }
        public void UpdateInDatabase(TotalPercent totalPercent)
        {
            SqlConnection connectToDateBase = new SqlConnection(pathOfDataBase);
            using (connectToDateBase)
            {
                SqlCommand command = new SqlCommand(
                "UPDATE [TOTALPERCENTS]" +
                "SET PERCENT_ID = @PERCENT_ID, FROM [TOTALPERCENTS];",
                connectToDateBase);
                connectToDateBase.Open();
                command.Parameters.AddWithValue("@PERCENT_ID", totalPercent.PercentId);
                command.ExecuteNonQuery();
            }
        }
        public void UpdateInDatabase(StatusTicket statusTicket)
        {
            SqlConnection connectToDateBase = new SqlConnection(pathOfDataBase);
            using (connectToDateBase)
            {
                SqlCommand command = new SqlCommand(
                ("UPDATE [STATUSTICKET]" +
                "SET STATUS_ID = @STATUS_ID, USER_ID = @USER_ID, TICKET_ID = @TICKET_ID, " +
                "STATUS_TICKET = @STATUS_TICKET, DATE_CHANGE = @DATE_CHANGE, TIME_CHANGE = @TIME_CHANGE"
                + "WHERE @STATUS_ID = STATUS_ID;"),
                connectToDateBase);
                command.Connection.Open();
                command.Parameters.AddWithValue("@STATUS_ID", statusTicket.StatusId);
                command.Parameters.AddWithValue("@USER_ID", statusTicket.UserId);
                command.Parameters.AddWithValue("@TICKET_ID", statusTicket.TicketId);
                command.Parameters.AddWithValue("@STATUS_TICKET", statusTicket.StatusOfTicket);
                command.Parameters.AddWithValue("@DATE_CHANGE", statusTicket.DateChange);
                command.Parameters.AddWithValue("@TIME_CHANGE", statusTicket.TimeChange);
                command.ExecuteNonQuery();
            }
        }
        public void UpdateInDatabase(Ticket ticket)
        {
            SqlConnection connectToDateBase = new SqlConnection(pathOfDataBase);
            using (connectToDateBase)
            {
                SqlCommand command = new SqlCommand(
                ("UPDATE [TICKETSALES] " +
                 "SET SESSION_ID = @SESSION_ID, PLACE_ID = @PLACE_ID, " +
                 "AGE_VISITOR = @AGE_VISITOR, TOTAL_COST = @TOTAL_COST " +
                 "WHERE TICKET_ID = @TICKET_ID;"),
                connectToDateBase);
                command.Connection.Open();
                command.Parameters.AddWithValue("@TICKET_ID", ticket.TicketId);
                command.Parameters.AddWithValue("@SESSION_ID", ticket.TicketSession.SessionId);
                command.Parameters.AddWithValue("@PLACE_ID", ticket.Place);
                command.Parameters.AddWithValue("@AGE_VISITOR", ticket.AgeVisitor);
                command.Parameters.AddWithValue("@TOTAL_COST", ticket.Price);
                command.ExecuteNonQuery();
            }
        }
    }
}
