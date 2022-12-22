using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agam
{
    internal class Worker
    {
        private int day, month, year;
        private string date;
        public Worker(int day, int month, int year) 
        {
            this.day = day;
            this.month = month; 
            this.year = year;
        }
        public string GetDate(string date)
        {
            date = "The date the worker opened the register: " + day + "." + month + "." + year;
            return date;
        }
    }
}
