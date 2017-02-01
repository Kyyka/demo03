using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WasherApplicationTeht02
{
    class Program
    {
        static void Main(string[] args)
        {
            //create one instance of washer class
            Washer washer = new Washer();
            washer.Printdata();
            washer.Power(true);
            washer.Hatch(true);
            washer.Sling(true);
            washer.Temperature = 60;
            washer.Program = 5;
            washer.Printdata();
        }
    }
}
