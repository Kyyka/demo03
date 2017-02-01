using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht04
{
    class Vehicle
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public string Tyres { get; set; }

        public void Printdata()
        {
            Console.WriteLine("Vehicle name: " + Name);
            Console.WriteLine("Vehcile speed: " + Speed);
            Console.WriteLine("Which tyres: " + Tyres);
            Console.WriteLine("---------------------------");
        }

        public Vehicle(string name, int speed, string tyres)
        {
            Name = name;
            Speed = speed;
            Tyres = tyres;
        }
        public override string ToString()
        {
            return string.Format("Vehicle name: {0}, Vehicle speed: {1}, Which tyres: {2}", Name, Speed, Tyres);
            
        }
    }
}
