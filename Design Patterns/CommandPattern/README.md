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

![Stock Manager](https://github.com/baristutakli/Developer_Teamwork/blob/main/Design%20Patterns/CommandPattern/Screenshots/StockManager.png?raw=true)

![IOrderCommand](https://github.com/baristutakli/Developer_Teamwork/blob/main/Design%20Patterns/CommandPattern/Screenshots/Command.png?raw=true)

![Sell Stock](https://github.com/baristutakli/Developer_Teamwork/blob/main/Design%20Patterns/CommandPattern/Screenshots/SellStock.png?raw=true)

![Buy Stock](https://github.com/baristutakli/Developer_Teamwork/blob/main/Design%20Patterns/CommandPattern/Screenshots/BuyStock.png?raw=true)

![Stock Controller](https://github.com/baristutakli/Developer_Teamwork/blob/main/Design%20Patterns/CommandPattern/Screenshots/StockController.png?raw=true)

![Program](https://github.com/baristutakli/Developer_Teamwork/blob/main/Design%20Patterns/CommandPattern/Screenshots/Program.png?raw=true)
