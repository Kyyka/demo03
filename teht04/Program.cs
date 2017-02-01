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
            Vehicle vehicle = new Vehicle();
            vehicle.Printdata();
            vehicle.ToString();
            vehicle.Name = "Ford";
            vehicle.Speed = 200;
            vehicle.Tyres = "Slick";
            vehicle.ToString();

        }
    }
}
