using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthCinema.Domain
{
    class Employee
    {
        public Employee(int employeeId, int hallId, 
            int jobId, string firstName, string lastName, string middleName)
        {
            EmployeeId = employeeId;
            HallId = hallId;
            JobId = jobId;
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
        }
        public int EmployeeId { get; private set; }
        public int HallId { get; private set; }
        public int JobId { get; private set; }
        public string FirstName  { get; private set; }
        public string LastName { get; private set; }
        public string MiddleName { get; private set; }
    }
}
