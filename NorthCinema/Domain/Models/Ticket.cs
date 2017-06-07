using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthCinema.Domain.Models
{
    class Ticket
    {
        public Ticket(int ticketId, Session ticketSession, PlaceInHall place, DateTime ageVisitor, int price)
        {
            TicketId = ticketId;
            TicketSession = ticketSession;
            Place = place;
            AgeVisitor = ageVisitor;
            Price = price;
        }
        public int TicketId { get; set; }
        public Session TicketSession { get; set; }
        public PlaceInHall Place { get; set; }
        public DateTime AgeVisitor { get; set; }
        public int Price { get; set; }

    }
}
