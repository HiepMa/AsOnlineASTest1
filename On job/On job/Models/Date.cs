using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Onjob.Models
{
    public class Date
    {
        public int Day { get; set; }
        public int month { get; set; }
        public int year { get; set; }
        public Date(string a)
        {
            string[] b = a.Split(new char[] { '/' });
            Day = Int32.Parse(b[0]);
            month = Int32.Parse(b[1]);
            year = Int32.Parse(b[2]);
        }
        public string toString()
        {
            string a = "";
            a = a + Day.ToString() + "/" + month.ToString() + "/" + year.ToString();
            return a;
        }
    }
}
