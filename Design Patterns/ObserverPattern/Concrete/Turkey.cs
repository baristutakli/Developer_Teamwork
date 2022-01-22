using LearnObserverPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnObserverPattern.Concrete
{
    public class Turkey : Observer
    {
        public override void Update(double distance)
        {
            Console.WriteLine($"Turkey will deliver AKINCI to Ukraine\tDistance: {distance}");
        }
    }
}
