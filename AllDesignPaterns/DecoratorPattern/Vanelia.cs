using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
   public class Vanelia:ItemDecorator
    {
        public Vanelia(Item item) : base(item)
        {
        }

        public override string GetDiscription()
        {
            
            return "Vanelia";
        }

        public override float GetCost()
        {
            return 0.5f;
        }
    }
}
