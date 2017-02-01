using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht03
{
    class Television
    {
        //properties
        public bool IsOn { get; set; }
        public bool TxtTVIsOn { get; set; }
        public bool WifiIsOn { get; set; }
        public int Channel { get; set; }
        public int Volume { get; set; }

        //methods
        public void Printdata()
        {
            Console.WriteLine("-Is TV on: " + IsOn);
            Console.WriteLine("-Is text TV on: " + TxtTVIsOn);
            Console.WriteLine("-Is wifi connected: " + WifiIsOn);
            Console.WriteLine("-Which channel is on: " + Channel);
            Console.WriteLine("-How loud volume is: " + Volume);
            Console.WriteLine("------------------------------------");
        }
        public void Power(bool value)
        {
            IsOn = value;
        }
        public void TxtTV(bool value)
        {
            TxtTVIsOn = value;
        }
        public void Wifi(bool value)
        {
            WifiIsOn = value;
        }
        public void HigherVolume()
        {
            Volume += 1;
        }
        public void LowerVolume()
        {
            Volume -= 1;
        }
    }
}
