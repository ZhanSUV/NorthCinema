using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthCinema.Domain.Models
{
    public class ListOfTickets
    {
        public ListOfTickets(List<Ticket> ticketList)
        {
            Tickets = ticketList;
        }
        public List<Ticket> Tickets { get; set; }
        public void AddTicketInList(int ticketId, Session ticketSession, int place, int row, DateTime ageVisitor, double price)
        {
            Ticket ticket = new Ticket(ticketId, ticketSession, place, row, ageVisitor, price);
            Tickets.Add(ticket);
        }
    }
}
