using CommandPattern.Commands.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    // Invoker
    // Metodun ne zaman çağrılacağını belirler.
    class StockController
    {
        private List<IOrderCommand> _orderCommands;

        public StockController()
        {
            _orderCommands = new List<IOrderCommand>();
        }

        public void TakeOrder(IOrderCommand command)
        {
            _orderCommands.Add(command);
        }

        public void PlaceOrders()
        {
            foreach (IOrderCommand command in _orderCommands)
            {
                command.Execute();
            }

            _orderCommands.Clear();
        }
    }
}
