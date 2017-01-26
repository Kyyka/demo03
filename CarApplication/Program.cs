using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //creeate one instance of Car claas
            Car car = new Car();
            car.Printdata();
            car.Model = "Datsun 100A";
            car.Color = "Yellow";
            car.Engine = 1.0;
            car.Speed = 10;
            car.FuzzyDices = true;
            car.DoorCount = 2;
            Car.SomeProperty = 100;
            car.Printdata();
            car.Accelerate();
            Console.WriteLine("Speed =" + car.Speed);
            car.Brake(2);
            Console.WriteLine("Speed =" + car.Speed);

            //create a new instance from Car class
            Car nascar = new Car("Speedtreap");
            nascar.Printdata();
            nascar.Color = "Black";
            nascar.Engine = 5.0;
            nascar.FuzzyDices = true;
            nascar.Printdata();

        }
    }
}
