using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthCinema.Domain
{
    class StatusTicket
    {
        public StatusTicket(int statusId, int employeeId, int ticketId, bool statusTicketBool, DateTime dateChange, DateTime timeChange)
        {
            StatusId = statusId;
            EmployeeId = employeeId;
            TicketId = ticketId;
            StatusTicketBool = statusTicketBool;
            DateChange = dateChange;
            TimeChange = timeChange;
        }
        public int StatusId { get; private set; }
        public int EmployeeId { get; private set; }
        public int TicketId { get; private set; }
        public bool StatusTicketBool { get; private set; }
        public DateTime DateChange { get; private set; }
        public DateTime TimeChange { get; private set; }

    }
}
