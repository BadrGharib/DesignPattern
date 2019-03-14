using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.WrongPattern
{
   public class MountainDuck:Iduck
    {
        public void Fly()
        {
            Console.WriteLine("Fly highe from the ground");
        }

        public void Swim()
        {
            Console.WriteLine("swim up of water");
        }

        public void Display()
        {
            Console.WriteLine("Red medim duck");
        }
    }
}
