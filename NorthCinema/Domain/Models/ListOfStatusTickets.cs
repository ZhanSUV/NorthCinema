using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthCinema.Domain.Models
{
    class ListOfStatusTickets
    {
        public ListOfStatusTickets(List<StatusTicket> statusTicketList)
        {
            StatusTicketList = statusTicketList;
        }
        public List<StatusTicket> StatusTicketList;
        public void AddStatusTicketInList(int statusId, int userId, int ticketId, string statusOfTicket, DateTime dateChange, TimeSpan timeChange)
        {
            StatusTicket statusTicket = new StatusTicket(statusId, userId, ticketId, statusOfTicket, dateChange, timeChange);
            StatusTicketList.Add(statusTicket);
        }
    }
}
