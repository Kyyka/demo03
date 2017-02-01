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
            Washer washer1 = new Washer("Hienopesu");
            washer1.IsOn = true;
            washer1.Sling(true);
            washer1.OpenClosed = true;
            washer1.Temperature = 60;
            washer1.Printdata();

            Washer washer2 = new Washer(60);
            washer2.IsOn = true;
            washer2.Sling(true);
            washer2.OpenClosed = true;
            washer2.Program = "Valkopesu";
            washer2.Printdata();

            Washer washer3 = new Washer(true, "valkopesu", 40);
            washer3.Printdata();
        }
    }
}
