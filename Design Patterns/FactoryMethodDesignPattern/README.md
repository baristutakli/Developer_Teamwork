## Factory Method Tasarım Deseni

##### Nedir?
Bu tasarım kalıbı bir **creational** tasarım kalıbıdır. Tek bir nesne örneği üzerinden ihtiyacımız olan nesnelerin üretilmesini sağlamaktadır. Soyut nesnelerden faydalanarak bu işlemi gerçekleştirmektedir.
#### IElectronic
```c#
    public interface IElectronic
    {
        string UsageAreaWithInterface(string strUsageArea);
    }
```

#### Electronic

```c#
    public abstract class Electronic
    {
        public abstract string UsageAreaWithAbstractClass(string strUsageArea);       //Kullanım alanı
    }
```

#### Somut sınıflar
IElectronic ve Electronic soyut sınıflarından türeyen üç sınıf bulunmaktadır. Bunlar: Computer, HeadSet ve Phone sınıflarıdır. Aşağıda Computer sınıfının yapısını görebilirsiniz.

#### Computer
```c#
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
```
#### Enums
Program.cs dosyasında oluşturduğumuz switch ifadesinin içerisinde kullanılmıştır.
```c#
enum Electronics
{
    Computer,
    HeadSet,
    Phone
}
```

