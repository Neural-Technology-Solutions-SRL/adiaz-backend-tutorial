using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using System.Linq;
using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int x = 7;
            int y = x + 3;
            Console.WriteLine(y);
            Console.ReadLine();
            */
            Console.WriteLine("What's your name?");

            // Getting first name
            Console.Write("Type your first name: ");
            string fname = Console.ReadLine();

            // Getting last name
            Console.Write("Type your  last name: ");
            string lname = Console.ReadLine();

            Console.WriteLine("Hello, " + fname + " " + lname);
            Console.ReadLine();
        }
    }
}