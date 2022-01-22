using DesignPatterns.FactoryMethodDesignPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethodDesignPattern.Concrete
{
    public class Computer : Electronic, IElectronic
    {
        public override string UsageAreaWithAbstractClass(string strUsageArea)
        {
            return strUsageArea = "Analyze";
        }

        public string UsageAreaWithInterface(string strUsageArea)
        {
            return strUsageArea = "Analyze";
        }
    }
}
