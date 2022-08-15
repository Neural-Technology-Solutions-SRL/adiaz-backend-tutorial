using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Car car1 = new Car();
            car1.Make = "Honda";
            car1.Model = "Civic";
            car1.VIN = "A1";

            Car car2 = new Car();
            car2.Make = "Toyota";
            car2.Model = "Trueno";
            car2.VIN = "A2";

            Book b1 = new Book();
            b1.Author = "Adhonys Diaz";
            b1.Title = "Cheap Code For Free";
            b1.ISBN = "0-000-00000-0";
            /*
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(car1);
            myArrayList.Add(car2);
            myArrayList.Add(b1);

            myArrayList.Remove(b1);

            foreach (Car car in myArrayList)
            {
                Console.WriteLine(car.Make);
            }
            

            //List<T>
            List<Car> myCarList = new List<Car>();
            myCarList.Add(car1);
            myCarList.Add(car2);
            //myCarList.Add(b1);
            foreach (Car car in myCarList)
            {
                Console.WriteLine(car.Make);
            }
            
            // Dictionary<TKey, TValue>
            Dictionary<string, Car> myDict = new Dictionary<string, Car>();
            myDict.Add(car1.VIN, car1);
            myDict.Add(car2.VIN, car2);

            Console.WriteLine(myDict["A2"].Make);
            */
            // Object initializer
            //Car car1 = new Car() { Make = "BMW", Model = "750li", VIN="A1"};
            //Car car2 = new Car() { Make = "HONDA", Model = "accord", VIN = "A2" };

            // Collection initializer
            List<Car> MyCarList = new List<Car>
            {
                new Car { Make = "BMW", Model = "750li", VIN="A1"},
                new Car { Make = "HONDA", Model = "accord", VIN = "A2" }
            };

            Console.ReadLine();

        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

    }

}
