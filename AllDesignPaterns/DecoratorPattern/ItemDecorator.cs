using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class ItemDecorator : Item
    {
        public Item Item { get; set; }
        public ItemDecorator(Item item)
        {
            Item = item;
        }
    }
}
