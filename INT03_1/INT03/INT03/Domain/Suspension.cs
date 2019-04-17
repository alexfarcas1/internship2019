using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INT03.Domain
{
    public class Suspension
    {
        private DateTime startDate;
        private DateTime endDate;

        public Suspension(DateTime startDate, DateTime endDate)
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }

        public override string ToString()
        {
            return "Start Date : " + this.StartDate.ToString();
        }
    }

}
