using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class DateModifer
    {
        public static double GetDaysBetween(string dateOne, string dayTwo)
        {
            DateTime dateTimeOne = DateTime.Parse(dateOne);
            DateTime dateTimeTwo = DateTime.Parse(dayTwo);

            
            double res = (dateTimeOne - dateTimeTwo).TotalDays;

            return Math.Abs(res);
        }
    }
}
