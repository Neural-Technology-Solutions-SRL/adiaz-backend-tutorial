using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            DateTime myValue = DateTime.Now;
            Console.WriteLine(myValue.ToString());

            // Short format to print datetime objects
            Console.WriteLine(myValue.ToShortDateString());
            Console.WriteLine(myValue.ToShortTimeString());

            // Long format to print datetime objects
            Console.WriteLine(myValue.ToLongDateString());
            Console.WriteLine(myValue.ToLongTimeString());

            Console.WriteLine(myValue.AddDays(3).ToLongDateString());
            Console.WriteLine(myValue.AddHours(3).ToLongTimeString());

            Console.WriteLine(myValue.AddDays(-3).ToLongDateString());
            Console.WriteLine(myValue.AddHours(-3).ToLongTimeString());

            Console.WriteLine(myValue.Month);
            
            DateTime myBirthday = new DateTime(1997, 2, 17);
            Console.WriteLine(myBirthday.ToShortDateString());
            */

            Console.Write("Please type your birthday using this format (mm/dd/yyyy): ");
            string userDOB = Console.ReadLine();
            DateTime myBirthday = DateTime.Parse(userDOB);
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            int yob = (DateTime.Now.Year - myBirthday.Year);
            
            Console.WriteLine("{0} day{3} have passed since you were born {1} year{2} ago.", myAge.Days, yob, (yob == 1) ? "" : "s", (myAge.Days == 1) ? "":"s");
            Console.ReadLine();
        }
    }
}

