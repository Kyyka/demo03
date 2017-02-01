using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht03
{
    class Program
    {
        static void Main(string[] args)
        {
            //create one instance of washer class
            Television television = new Television();
            television.Printdata();
            television.Power(true);
            television.TxtTV(false);
            television.Wifi(true);
            television.Channel = 2;
            television.HigherVolume();
            television.Printdata();
            television.LowerVolume();
            television.Printdata();
        }
    }
}
