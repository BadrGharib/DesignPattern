using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {

        static void Main(string[] args)
        {
            WeatherStation station=new WeatherStation();
            MobileDevice mobileDevice=new MobileDevice(station);
            station.Add(mobileDevice);
            station.Notify();
        }
    }
}
