using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeaterApplicationTeht01
{
    class Heater
    {
        //properties
        public bool IsOn { get; set; }
        public double Temperature { get; set; }
        public double Humidity { get; set; }
        
        //constructors
        //methods
        public void Printdata()
        {
            Console.WriteLine("Is heater on: " + IsOn);
            Console.WriteLine("Temparature: " + Temperature);
            Console.WriteLine("Humidity: " + Humidity);
        }

        public void Power()
        {
            IsOn = false;
        }
        //destructor
        ~Heater()
        {
            Console.WriteLine("Heater object destroyed");
        }
    }
}
