using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INT03.Domain
{
    public class Employee
    {
        private DateTime employmentStartDate;
        private DateTime employmentEndDate;
        private List<Suspension> suspensionPeriodList;

        public Employee(DateTime employmentStartDate, DateTime employmentEndDate, List<Suspension> suspensionPeriodList)
        {
            this.EmploymentStartDate = employmentStartDate;
            this.EmploymentEndDate = employmentEndDate;
            this.SuspensionPeriodList = suspensionPeriodList;
        }

        public DateTime EmploymentStartDate { get => employmentStartDate; set => employmentStartDate = value; }
        public DateTime EmploymentEndDate { get => employmentEndDate; set => employmentEndDate = value; }
        internal List<Suspension> SuspensionPeriodList { get => suspensionPeriodList; set => suspensionPeriodList = value; }
    }
}
