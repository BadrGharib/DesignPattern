using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalFactory factory=new AnimalFactory();
            ;
            IAnimal animal= factory.CreatAnimal(AnimalsTypes.Cat);
            Console.WriteLine(animal.GetDiscreption());
            Console.ReadLine();
        }
    }
}
