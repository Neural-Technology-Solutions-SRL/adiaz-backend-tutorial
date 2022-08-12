using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using System.Linq;
using System;

namespace ObjectLifetime
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Car myCar1 = new Car();

            Car.MyMethod();

            /*
            myCar1.Make = "Ford";
            myCar1.Model = "Explorer";
            myCar1.Year = 2013;
            myCar1.Color = "Silver";
            
            Car myCar2 = myCar1;
            myCar2.Model = "Focus";

            PrintCar(myCar1);

            //myCar2 = null;

            PrintCar(myCar2);
            
            Car myCar3 = new Car("Honda", "Accord", 2012, "Black");
            //PrintCar(myCar3);
            */
            PrintCar(myCar1);
        }
        private static void PrintCar(Car car)
        {
            Console.WriteLine("{0} {1} {2} {3}",
                car.Make,
                car.Model,
                car.Year,
                car.Color
            );
        }
    }
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        /*
        public Car()
        {
            //Make = "Nissan";
        }
        public Car(string make, string model, int year, string color)
        {
            Make = make; 
            Model = model; 
            Year = year; 
            Color = color;
            Console.WriteLine("You've make this car: (\n     Brand: {0}\n     Model: {1}\n      Year: {2}\n     Color: {3}\n)",
                Make, Model, Year, Color
            );
        }
        */
        public static void MyMethod()
        {
            Console.WriteLine("Called the static method");
            Console.WriteLine(Make);
        }
    }
}