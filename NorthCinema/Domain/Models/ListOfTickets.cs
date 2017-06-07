using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthCinema.Domain.Models
{
    class ListOfTickets
    {
        public ListOfTickets(List<Ticket> ticketList)
        {
            Tickets = ticketList;
        }
        public List<Ticket> Tickets { get; set; }
    }
}
