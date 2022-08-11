using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using System.Linq;
using System;

namespace HelperMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Name Game");

            Console.Write("What's your first name? ");
            string fname = Console.ReadLine();

            Console.Write("What's your last name? ");
            string lname = Console.ReadLine();

            Console.Write("In what city were you born? ");
            string city = Console.ReadLine();

            DisplayResult(
                RString(fname),
                RString(lname),
                RString(city)
            );

            Console.ReadLine();
        }

        private static string RString(string text)
        {
            char[] text_array = text.ToCharArray();
            Array.Reverse(text_array);
            return String.Concat(text_array);
        }

        private static void DisplayResult(string rFname, string rLname, string rCity)
        {
            Console.Write(String.Format("Result: {0} {1} {2}.",
                    rFname,
                    rLname,
                    rCity
                )
            );
        }
    }
}