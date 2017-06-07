using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthCinema.Domain.Models
{
    public class StatusTicket
    {
        public StatusTicket(int statusId, int userId, int ticketId, string statusOfTicket, DateTime dateChange, TimeSpan timeChange)
        {
            StatusId = statusId;
            UserId = userId;
            TicketId = ticketId;
            StatusOfTicket = statusOfTicket;
            DateChange = dateChange;
            TimeChange = timeChange;
        }
        public int StatusId { get; set; }
        public int UserId { get; set; }
        public int TicketId { get; set; }
        public string StatusOfTicket { get; set; }
        public DateTime DateChange { get; set; }
        public TimeSpan TimeChange { get; set; }
    }
}
