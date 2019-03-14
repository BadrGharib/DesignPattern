using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.RightPattern
{
   public class Duck
   {
       private Idisplay _display;
       private ISwim _swim;
       private IFly _fly;
       private IKuak _kuak;

        public Duck(Idisplay display,ISwim swim,IFly fly)
        {
            if (display != null) _display = display;
            if (swim != null) _swim = swim;
            if (fly != null) _fly = fly;
        }
       public Duck(Idisplay display, ISwim swim, IFly fly,IKuak kuak):this(display,swim,fly)
       {
           if (kuak != null) _kuak = kuak;
       }
      
        public virtual void Display()
        {
            _display?.Display();
        }
       public virtual  void Swim()
       {
           _swim?.Swim();
          
       }
       public virtual void Fly()
       {
           _fly?.Fly();

       }
       public virtual void Kuak()
       {
           _kuak?.Kuak();

       }
    }
}
