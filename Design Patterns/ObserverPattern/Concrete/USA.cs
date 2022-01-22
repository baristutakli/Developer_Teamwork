using LearnObserverPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnObserverPattern.Concrete
{
    public class USA : Observer
    {
        public override void Update(double distance)
        {
            Console.WriteLine($"USA will  sanction against to Russia\tDistance: {distance}");
        }
    }
}
