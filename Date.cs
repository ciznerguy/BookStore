using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class Date
    {
        private int day;
        private int month;
        private int year;

        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public Date(Date other) 
        {
            this.day = other.day;
            this.month = other.month;
            this.year = other.year;
        }
        public int GetDay() { return day;}
        public int GetMonth() { return month; }
        public int GetYear() { return year; }
        public void SetDay(int day) { this.day = day;}
        public void SetMonth(int month) {  this.month = month;}
        public void SetYear(int year) {  this.year = year;}

        public bool IsLater(Date other) 
        {
            if (this.year < other.year)
            {
                return true;
            }
            else if (this.year == other.year && this.month < other.month))
            {
                return true;
            }

            else if (this.month == other.month&& this.day < other.day))
            { 
                return true; 
            }
            
            return false;
        }
        

        public override string ToString()
        {
            return $"Day:{day}, Month: {month}, Year: {year}";
        }

    }
}
