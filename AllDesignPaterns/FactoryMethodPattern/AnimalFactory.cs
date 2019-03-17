using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class AnimalFactory:IAnimalFactory
    {
        public IAnimal CreatAnimal(AnimalsTypes types)
        {
            switch (types)
            {
                
                case AnimalsTypes.Dog:
                    return new Dog();
                    break;
                case AnimalsTypes.Cat:
                    return new Cat();
                    break;
                default:
                   return new Dog();
            }
        }
    }
}
