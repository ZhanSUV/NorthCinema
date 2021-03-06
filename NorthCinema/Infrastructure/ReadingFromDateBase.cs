﻿using System;
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
        public readonly List<AdminUser> adminList = new List<AdminUser>();
        public readonly List<CashierUser> cashierList = new List<CashierUser>();
        public readonly List<VisitorUser> visitorList = new List<VisitorUser>();
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
                "NAME_FILM, LENGTH_FILM, AGE_LIMIT, TICKET_PRICE, NAME_HALL, SEATING_CAPACITY, PLACES_IN_ROW FROM [SESSIONS], [FILMS], [HALLS]" + 
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
                        hall = new Hall(hallId, readerSession.GetString(9), readerSession.GetInt32(10), readerSession.GetInt32(11));
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
                "SELECT HALL_ID, NAME_HALL, SEATING_CAPACITY, PLACES_IN_ROW FROM [HALLS];",
                connectToDateBase);
                connectToDateBase.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Hall hall = new Hall(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3));
                        hallsList.Add(hall);
                    }
                }
                reader.Close();
            }
            ListOfHalls halls = new ListOfHalls(hallsList);
            return halls;
        }
        public ListOfPlacesInHalls ReadAllPlacesOfAllHalls()
        {
            List<PlaceInHall> placesList = new List<PlaceInHall>();
            SqlConnection connectToDateBase = new SqlConnection(pathOfDataBase);
            using (connectToDateBase)
            {
                SqlCommand command = new SqlCommand(
                "SELECT PLACE_ID, HALL_ID, ROW_PLACES, PLACE FROM [PLACESINHALLS];",
                connectToDateBase);
                connectToDateBase.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        PlaceInHall place = new PlaceInHall(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3));
                        placesList.Add(place);
                    }
                }
                reader.Close();
            }
            ListOfPlacesInHalls places = new ListOfPlacesInHalls(placesList);
            return places;
        }
        public ListOfPercents ReadPercentages()
        {
            List<Percent> percentsList = new List<Percent>();
            SqlConnection connectToDateBase = new SqlConnection(pathOfDataBase);
            using (connectToDateBase)
            {
                SqlCommand command = new SqlCommand(
                "SELECT PERCENT_ID, DISCOUNT_MARKUP, DESCRIPTION, PERCENT1 FROM [PERCENTAGES];",
                connectToDateBase);
                connectToDateBase.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Percent percent = new Percent(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3));
                        percentsList.Add(percent);
                    }
                }
                reader.Close();
            }
            ListOfPercents percents = new ListOfPercents(percentsList);
            return percents;
        }
        public ListOfTickets ReadTickets()
        {
            Hall hall;
            Film film;
            Session session;
            PlaceInHall place;
            List<Ticket> ticketsList = new List<Ticket>();
            SqlConnection connectToDateBase = new SqlConnection(pathOfDataBase);
            using (connectToDateBase)
            {
                SqlCommand command = new SqlCommand(
                "SELECT TICKET_ID, [TICKETSALES].SESSION_ID, [TICKETSALES].PLACE_ID, AGE_VISITOR, TOTAL_COST, " + // 4
                "[SESSIONS].SESSION_ID, [SESSIONS].HALL_ID, [SESSIONS].[FILM_ID], DATE_SESSION, TIME_SESSION, " + // 9
                "NAME_HALL, SEATING_CAPACITY, PLACES_IN_ROW,  " +  //12
                "[PLACESINHALLS].PLACE_ID, ROW_PLACES, PLACE, " +  //15
                "NAME_FILM, LENGTH_FILM, AGE_LIMIT, TICKET_PRICE " + //19
                "FROM [TICKETSALES], [SESSIONS], [PLACESINHALLS], [HALLS], [FILMS]" + 
                "WHERE [TICKETSALES].SESSION_ID = [SESSIONS].SESSION_ID AND [TICKETSALES].PLACE_ID = [PLACESINHALLS].PLACE_ID " +
                "AND [SESSIONS].HALL_ID = [HALLS].HALL_ID AND [SESSIONS].[FILM_ID] = [FILMS].[FILM_ID] " +
                "AND [PLACESINHALLS].HALL_ID = [HALLS].HALL_ID;",
                connectToDateBase);
                connectToDateBase.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        hall = new Hall(reader.GetInt32(6), reader.GetString(10), reader.GetInt32(11), reader.GetInt32(12));
                        place = new PlaceInHall(reader.GetInt32(13), reader.GetInt32(6), reader.GetInt32(14), reader.GetInt32(15));
                        film = new Film(reader.GetInt32(7), reader.GetString(16), reader.GetInt32(17),
                                reader.GetInt32(18), reader.GetInt32(19));
                        session = new Session(reader.GetInt32(5), film, hall, reader.GetDateTime(8), reader.GetTimeSpan(9));
                        Ticket ticket = new Ticket(reader.GetInt32(0), session, place.PlaceNumber, place.Row, reader.GetDateTime(3), reader.GetInt32(4));
                        ticketsList.Add(ticket);
                    }
                }
                reader.Close();
            }
            ListOfTickets tickets = new ListOfTickets(ticketsList);
            return tickets;
        }
        public ListOfTotalPercents ReadTotalPercents()
        {
            List<TotalPercent> totalPercentList = new List<TotalPercent>();
            SqlConnection connectToDateBase = new SqlConnection(pathOfDataBase);
            using (connectToDateBase)
            {
                SqlCommand command = new SqlCommand(
                "SELECT PERCENT_ID, TICKET_ID FROM [TOTALPERCENTS];",
                connectToDateBase);
                connectToDateBase.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        TotalPercent totalPercent = new TotalPercent(reader.GetInt32(0), reader.GetInt32(1));
                        totalPercentList.Add(totalPercent);
                    }
                }
                reader.Close();
            }
            ListOfTotalPercents totalPercents = new ListOfTotalPercents(totalPercentList);
            return totalPercents;
        }
        public ListOfStatusTickets ReadStatusTickets()
        {
            List<StatusTicket> statusTicketList = new List<StatusTicket>();
            SqlConnection connectToDateBase = new SqlConnection(pathOfDataBase);
            using (connectToDateBase)
            {
                SqlCommand command = new SqlCommand(
                "SELECT STATUS_ID, USER_ID, TICKET_ID, STATUS_TICKET, DATE_CHANGE, TIME_CHANGE FROM [STATUSTICKETS];",
                connectToDateBase);
                connectToDateBase.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        StatusTicket statusTicket = new StatusTicket(reader.GetInt32(0), reader.GetInt32(1), 
                            reader.GetInt32(2), reader.GetString(3), reader.GetDateTime(4), reader.GetTimeSpan(5));
                        statusTicketList.Add(statusTicket);
                    }
                }
                reader.Close();
            }
            ListOfStatusTickets statusTickets = new ListOfStatusTickets(statusTicketList);
            return statusTickets;
        }
    }
}
