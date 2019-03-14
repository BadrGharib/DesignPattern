using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.RightPattern.Behavoirs
{
  public class FlyVeryHigh:IFly
    {
        public void Fly()
        {
            Console.WriteLine("Flay around 100 Meter");
        }
    }
}
