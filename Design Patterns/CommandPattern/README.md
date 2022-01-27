# Command Design Pattern

Command tasarım deseni, kullanıcı isteklerini gerçekleştiren metotları nesneler haline getirerek daha sonra bu metotları gerçekleştirilmesini veya geri alınmasını sağlayan tasarım desenidir.

Nesne üzerinde bir işleminin nasıl yapıldığını bilmediğimiz ya da kullanılmak istenen nesneyi tanımadığımız durumlarda kullanılır.

Command tasarım deseninin UML diagramı:

![UML](https://github.com/baristutakli/Developer_Teamwork/blob/main/Design%20Patterns/CommandPattern/UML/command-uml.png?raw=true)

- ***Command:*** Temel şablon arayüzdür. Komutların çalıştırılması için temel metotu içermektedir.
- ***ConcreteCommand:*** ``Command`` interface'si implemente eder. Nesnelere dönüştürdüğümüz her bir isteğe denk gelmektedir. (Her istek için oluşturulmalıdır.)
- ***Invoker:*** ``Command`` referansını tutmaktadır. Metodun ne zaman çağrılacağını belirler.
- ***Receiver:*** ``Client`` tarafından iletişime geçeceği sınıftır.

## ``Örnek C# uygulaması``

Senaryo olarak bir ürüne ait stok takibi verilen basit bir sistem olduğunu var sayalım. Burada stok ile ilgili işlemler bu tasarım desenine göre yapılsın.

[StockManager.cs](https://github.com/baristutakli/Developer_Teamwork/blob/main/Design%20Patterns/CommandPattern/CommandPattern/StockManager.cs)
``` C#
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
```

[IOrderCommand.cs](https://github.com/baristutakli/Developer_Teamwork/blob/main/Design%20Patterns/CommandPattern/CommandPattern/Commands/Abstract/IOrderCommand.cs)
``` C#
    // Command
    // Temel şablondur.
    // Komutların çalıştırması için temel metotu içermektedir.
    interface IOrderCommand
    {
        void Execute();
    }
```

[SellStock.cs](https://github.com/baristutakli/Developer_Teamwork/blob/main/Design%20Patterns/CommandPattern/CommandPattern/Commands/Concrete/SellStock.cs)
``` C#
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
```
[BuyStock.cs](https://github.com/baristutakli/Developer_Teamwork/blob/main/Design%20Patterns/CommandPattern/CommandPattern/Commands/Concrete/BuyStock.cs)
``` C#
    // ConcreteCommand1
    // Command(IOrderCommand) interface'i implemente eder.
    // Receiver(StockManager) deki bir isteği nesneye dönüştürür.
    class BuyStock : IOrderCommand
    {
        private readonly StockManager _stockManager;
        public BuyStock(StockManager stockManager)
        {
            _stockManager = stockManager;
        }
        public void Execute()
        {
            _stockManager.Buy();
        }
    }
```

[StockController.cs](https://github.com/baristutakli/Developer_Teamwork/blob/main/Design%20Patterns/CommandPattern/CommandPattern/StockController.cs)
``` C#
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
```

[Program.cs](https://github.com/baristutakli/Developer_Teamwork/blob/main/Design%20Patterns/CommandPattern/CommandPattern/Program.cs)
``` C#
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
```
