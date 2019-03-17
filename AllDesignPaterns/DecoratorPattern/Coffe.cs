using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Coffe : Item
    {
        public override float GetCost()
        {
            return 1.5f;
        }

        public override string GetDiscription()
        {
            return "Coffe";
        }
    }
}
