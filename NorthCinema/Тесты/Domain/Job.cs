using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthCinema.Domain
{
    class Job
    {
        public Job(int jobId, string jobTitle)
        {
            JobId = jobId;
            JobTitle = jobTitle;
        }
        public int JobId { get; private set; }
        public string JobTitle { get; private set; }
    }
}
