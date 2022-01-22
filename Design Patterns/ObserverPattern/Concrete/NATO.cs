using LearnObserverPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnObserverPattern.Concrete
{
    public class NATO : Observer
    {
        public override void Update(double distance)
        {
            Console.WriteLine($"NATO will desliver equipment to Ukraine\tDistance: {distance}");
        }
    }
}
