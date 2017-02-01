using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WasherApplicationTeht02
{
    class Washer
    {
        //properties
        public bool IsOn { get; set; }
        public bool OpenClosed { get; set; }
        public bool SlingYesNo { get; set; }
        public int Temperature { get; set; }
        public string Program { get; set; }
        //methods
        public void Printdata()
        {
            Console.WriteLine("Is washer on: " + IsOn);
            Console.WriteLine("Is hatch open: " + OpenClosed);
            Console.WriteLine("Will sling be used: " + SlingYesNo);
            Console.WriteLine("What tempature: " + Temperature);
            Console.WriteLine("Which program: " + Program);
            Console.WriteLine("------------------------------------");
        }

        public Washer(bool ison)
        {
            IsOn = ison;
        }

        public Washer(string program)
        {
            Program = program;
        }
        
        public Washer(int temperature)
        {
            Temperature = temperature;
        }
        
        public Washer(bool ison, string program, int temperature)
        {
            IsOn = ison;
            Program = program;
            Temperature = temperature;
        }

        public void Sling(bool value)
        {
            SlingYesNo = value;
        }
    }
}
