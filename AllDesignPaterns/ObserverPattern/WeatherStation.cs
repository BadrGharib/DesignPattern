using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
   public class WeatherStation:ISubject
   {
       private List<IObserver> allObservers;

       public WeatherStation()
       {
           allObservers=new List<IObserver>();
       }
        public void Add(IObserver observer)
        {
            allObservers.Add(observer);
        }

        public void Remove(IObserver observer)
        {
            allObservers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var VARIABLE in allObservers)
            {
                VARIABLE.Update();
            }
        }

       public string GetTembreature()
       {
           return "the Tembreathure is:21";
       }
    }
}
