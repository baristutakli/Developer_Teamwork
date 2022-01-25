using CommandPattern.Commands.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands.Concrete
{
    // ConcreteCommand2
    // Command(IOrderCommand) interface'i implemente eder.
    // Receiver(StockManager) deki bir isteği nesneye dönüştürür.
    class SellStock : IOrderCommand
    {
        private readonly StockManager _stockManager;
        public SellStock(StockManager stockManager)
        {
            _stockManager = stockManager;
        }
        public void Execute()
        {
            _stockManager.Sell();
        }
    }
}
