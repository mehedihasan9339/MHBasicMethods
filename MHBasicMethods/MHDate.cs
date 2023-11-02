using System;
using System.Collections.Generic;
using System.Text;

namespace MHBasicMethods
{
    public class MHDate
    {
        public int CalculateAge(DateTime birthdate)
        {
            DateTime currentDate = DateTime.Now;
            int age = currentDate.Year - birthdate.Year;
            if (birthdate > currentDate.AddYears(-age)) age--;
            return age;
        }




        //public Tuple<DateTime, DateTime> GetFirstAndLastDayOfMonth(DateTime date)
        //{
        //    DateTime firstDayOfMonth = new DateTime(date.Year, date.Month, 1);
        //    DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
        //    return Tuple.Create(firstDayOfMonth, lastDayOfMonth);
        //}


        public List<DateTime> GetFirstAndLastDayOfMonth(DateTime date)
        {
            DateTime firstDayOfMonth = new DateTime(date.Year, date.Month, 1);
            DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
            return new List<DateTime> { firstDayOfMonth, lastDayOfMonth };
        }




        public bool IsLeapYear(int year)
        {
            return year % 4 == 0 && year % 100 != 0 || year % 400 == 0;
        }



        public string FormatElapsedTime(DateTime startDate)
        {
            TimeSpan elapsed = DateTime.Now - startDate;
            if (elapsed.TotalMinutes < 1)
                return "Just now";
            if (elapsed.TotalHours < 1)
                return $"{elapsed.Minutes} minute{(elapsed.Minutes > 1 ? "s" : "")} ago";
            if (elapsed.TotalDays < 1)
                return $"{elapsed.Hours} hour{(elapsed.Hours > 1 ? "s" : "")} ago";
            if (elapsed.TotalDays < 7)
                return $"{elapsed.Days} day{(elapsed.Days > 1 ? "s" : "")} ago";
            return $"{elapsed.Days / 7} week{(elapsed.Days / 7 > 1 ? "s" : "")} ago";
        }







        public DateTime FindNextWeekday(DateTime startDate, DayOfWeek weekday)
        {
            int daysUntilNextWeekday = ((int)weekday - (int)startDate.DayOfWeek + 7) % 7;
            return startDate.AddDays(daysUntilNextWeekday);
        }








    }
}
