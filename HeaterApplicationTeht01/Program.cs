using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeaterApplicationTeht01
{
    class Program
    {
        static void Main(string[] args)
        {
            //create one instance of heater class
            Heater heater = new Heater();
            heater.Printdata();
            heater.Power();
            heater.Temperature = 80;
            heater.Humidity = 98.3;
            heater.Printdata();
        }
    }
}
