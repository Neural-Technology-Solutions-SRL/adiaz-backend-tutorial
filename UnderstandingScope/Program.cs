using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using System.Linq;


namespace UnderstandingScope
{
    class Program
    {
        private static string k = "";
        static void Main(string[] args)
        {

            string j = "";
            for (int i = 0; i < 10; i++)
            {
                j = i.ToString();
                k = i.ToString();
                Console.WriteLine(i);
            }
            //Console.WriteLine(i);
            Console.WriteLine("'J' Outside of the for: " + j);
            Console.WriteLine("'K' Outside of the for: " + k);
            HelperMEthod();

            Car myCar = new Car();
            myCar.DoSomething();

            Console.ReadLine();
        }

        static void HelperMEthod()
        {
            Console.WriteLine("Value of 'K' from the Helper method: " + k);
        }
    }

    class Car
    {
        public void  DoSomething()
        {
            Console.WriteLine(HelperMethod());
        }
        private string HelperMethod()
        {
            return "Hello World!";
        }
    }
}

            
