using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.RightPattern.Behavoirs
{
   public class SwimUpWater :ISwim
    {
        public void Swim()
        {
            Console.WriteLine("Swim Up Water");
        }
    }
}
