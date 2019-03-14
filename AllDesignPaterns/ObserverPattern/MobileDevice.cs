using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
  public  class MobileDevice:IObserver
  {
      private WeatherStation _weatherStation;
        public MobileDevice(WeatherStation station)
        {
            _weatherStation = station;
        }
        public void Update()
        {
         string tembreathure= _weatherStation.GetTembreature();
            Console.WriteLine(tembreathure);
            Console.ReadLine();
        }
    }
}
