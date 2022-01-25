using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    // Reciever(Alıcı)
    // Komutları nesneler haline getirecek olan class
    class StockManager
    {
        private string _name;
        private int _quantity;

        public StockManager(string name, int quantity)
        {
            _name = name;
            _quantity = quantity;
        }

        public void Buy()
        {
            Console.WriteLine($"{_quantity} adet {_name} alındı");
        }

        public void Sell()
        {
            Console.WriteLine($"{_quantity} adet {_name} satıldı.");
        }
    }
}
