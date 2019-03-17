using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
  public  class MocaD:ItemDecorator
    {
        public MocaD(Item item) : base(item)
        {
        }

        public override string GetDiscription()
        {
           
            return "Moca";
        }

        public override float GetCost()
        {
            return 0.5f;
        }
    }
}
