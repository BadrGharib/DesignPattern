using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.RightPattern.Behavoirs
{
  public class FlayNearGround:IFly
    {
        public void Fly()
        {
            Console.WriteLine("Flaw arround 5 meter from ground");
        }
    }
}
