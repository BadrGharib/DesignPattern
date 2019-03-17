using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
   public class Capitsheno:Item
    {
        public override string GetDiscription()
        {
            return "Capotsheno";
        }

        public override float GetCost()
        {
            return 2f;
        }
    }
}
