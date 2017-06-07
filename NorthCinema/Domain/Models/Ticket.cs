using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthCinema.Domain.Models
{
    public class Ticket
    {
        public Ticket(int ticketId, Session ticketSession, int row, int place, DateTime ageVisitor, double price)
        {
            TicketId = ticketId;
            TicketSession = ticketSession;
            Row = row;
            Place = place;
            AgeVisitor = ageVisitor;
            Price = price;
        }
        public int TicketId { get; set; }
        public Session TicketSession { get; set; }
        public int Place { get; set; }
        public int Row { get; set; }
        public DateTime AgeVisitor { get; set; }
        public double Price { get; set; }

    }
}
