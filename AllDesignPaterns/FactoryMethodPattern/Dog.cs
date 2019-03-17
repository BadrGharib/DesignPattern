using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
  public class Dog :IAnimal
    {
        public string GetDiscreption()
        {
            return "Dog!";
        }
    }
}
