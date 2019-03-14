using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.RightPattern;
using StrategyPattern.RightPattern.Behavoirs;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck cityDuck=new Duck(null,new SwimUnderWater(), new FlyVeryHigh());
            cityDuck.Fly();
            cityDuck.Swim();
           Console.ReadLine();
        }
    }
}
