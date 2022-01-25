using CommandPattern.Commands.Abstract;
using CommandPattern.Commands.Concrete;
using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            StockManager stockManager = new("Xiaomi", 10);

            IOrderCommand buyStock = new BuyStock(stockManager);
            IOrderCommand sellStock = new SellStock(stockManager);

            StockController stockController = new StockController();

            stockController.TakeOrder(buyStock);
            stockController.TakeOrder(sellStock);
            stockController.TakeOrder(sellStock);

            stockController.PlaceOrders();

            // Output
            // 10 adet Xiaomi alındı.
            // 10 adet Xiaomi satıldı.
            // 10 adet Xiaomi satıldı.
        }
    }
}
