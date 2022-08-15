using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>()
            {
                new Car() { VIN="A1",   Make="BMW",     Model="550i",       StickerPrice=55000, Year=2013},
                new Car() { VIN="B2",   Make="TOYOTA",  Model="4Runner",    StickerPrice=35000, Year=1996},
                new Car() { VIN="C3",   Make="BMW",     Model="745li",      StickerPrice=75000, Year=2018},
                new Car() { VIN="D4",   Make="FORD",    Model="Escape",     StickerPrice=25000, Year=2020},
                new Car() { VIN="E5",   Make="BMW",     Model="55i",        StickerPrice=57000, Year=1997}
            };
            /*
            // LINQ Query
            var bmws = from car in myCars
                       where car.Make == "BMW"
                       && car.Year == 2013
                       select car;
          
            var orderedCars = from car in myCars
                              orderby car.Year descending
                              select car;
            

            // LINQ method
            var bmws = myCars.Where(car => car.Make == "BMW" && car.Year == 2013);
            var orderedCars = myCars.OrderByDescending( car => car.Year);
            
            var firstCar = myCars.OrderByDescending(car => car.Year).First(car => car.Make == "BMW");
            Console.WriteLine(firstCar.VIN);
            
            Console.WriteLine(myCars.TrueForAll(car => car.Year > 1995));
            
            myCars.ForEach(car => Console.WriteLine("{0} {1}",car.VIN, car.StickerPrice));
            
            myCars.ForEach(car => car.StickerPrice -= 3000);
            
            Console.WriteLine(myCars.Exists(car => car.Model == "745li"));

            Console.WriteLine("{0:C}", myCars.Sum(car => car.StickerPrice));

            foreach (var car in orderedCars)
            {
                Console.WriteLine("{0} {1} {2}", car.Model, car.VIN, car.Year);
            }
            */

            Console.WriteLine(myCars.GetType());
            var orderedCars = myCars.OrderByDescending(car => car.Year);
            Console.WriteLine(orderedCars.GetType());

            var bmws = myCars.Where(car => car.Make == "BMW" && car.Year == 2013);
            Console.WriteLine(bmws.GetType());

            var newCars = from car in myCars
                          where car.Make == "BMW"
                          && car.Year == 2013
                          select new { car.Make, car.Model };
            Console.WriteLine(newCars.GetType());

            Console.ReadLine();
        }
    }
    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int StickerPrice { get; set; }
        public int Year { get; set; }
    }
}
