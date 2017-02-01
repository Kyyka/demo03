using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht04
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle("Ford", 200, "Slick");
            vehicle.Printdata();


            Vehicle vehicle2 = new Vehicle("Opel", 180, "Grip");
            Console.WriteLine(vehicle2);

        }
        
    }
}
