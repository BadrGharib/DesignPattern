using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
  public class Cat:IAnimal
    {
        public string GetDiscreption()
        {
            return "Cat !";
        }
    }
}
