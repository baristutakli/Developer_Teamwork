using DesignPatterns.FactoryMethodDesignPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethodDesignPattern.Concrete
{
    public class Phone : Electronic, IElectronic
    {
        public override string UsageAreaWithAbstractClass(string strUsageArea)
        {
            return strUsageArea = "Communication";
        }

        public string UsageAreaWithInterface(string strUsageArea)
        {
            return strUsageArea = "Communication";
        }
    }
}
