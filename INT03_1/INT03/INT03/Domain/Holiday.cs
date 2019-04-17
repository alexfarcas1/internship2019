using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INT03.Domain
{
    class Holiday
    {
        private int year;
        private int holidayDays;

        public Holiday(int year, int holidayDays)
        {
            this.Year = year;
            this.HolidayDays = holidayDays;
        }

        public int Year { get => year; set => year = value; }
        public int HolidayDays { get => holidayDays; set => holidayDays = value; }
    }
}
