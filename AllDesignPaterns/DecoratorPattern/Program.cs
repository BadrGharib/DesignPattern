using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Coffe coffe=new Coffe();
            MocaD mocaD=new MocaD(coffe);
            Vanelia vanelia=new Vanelia(mocaD);
            float _price = GetPrice(vanelia);
            Console.WriteLine("The total Price : "+_price);
            Console.ReadLine();

        }

        static float GetPrice( Item item)
        {
            Console.WriteLine(item.GetDiscription()+" : "+item.GetCost());
            ItemDecorator mItem = item as ItemDecorator;
            if (mItem==null)
            {
                return item.GetCost();
            }
            //Item mItem = ((ItemDecorator)item).Item;
            return item.GetCost()+GetPrice(mItem.Item);
        }
    }
}
