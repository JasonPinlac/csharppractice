using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(2017, 1, 1);
            Console.WriteLine(dateTime);
            Console.WriteLine(DateTime.Today);
            Console.WriteLine(DateTime.Now);
            DateTime now = DateTime.Now;
            Console.WriteLine(now.Hour);
        }
    }
}
