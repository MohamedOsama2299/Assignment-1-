using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__1__
{
    internal class HiringDate
    {
        private int Day;
        private int Month;
        private int Year;

        public HiringDate(int day, int month, int year)
        {
            if (day < 1 || day > 31)
            {
                throw new ArgumentOutOfRangeException(nameof(day), "Day must be between 1 and 31.");
            }
            if (month < 1 || month > 12)
            {
                throw new ArgumentOutOfRangeException(nameof(month), "Month must be between 1 and 12.");
            }
            if (year < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(year), "Year must be a positive integer.");
            }
            this.Day = day;
            this.Month = month;
            this.Year = year;
        }
    }
}
