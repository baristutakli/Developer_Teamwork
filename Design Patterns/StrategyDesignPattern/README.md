## Strateji (Strategy) Tasarım Deseni

##### Nedir?
**Strateji**(Strategy) tasarım deseni, **behavioral** (davranışsal) tasarım desenlerinden
biridir. Bir dizi algoritma tanımlar, bu algoritmaların erişimi için arayüz sağlar ve
algoritmaları tanımlarken birbirlerinin yerine kullanılabilir özellikte tasarlar. Ayrıca
client runtime zamanında dilediği algoritmayı seçebilir.

##### Ne zaman Kullanılır?

Belirli bir iş için birden çok algoritmaya(yönteme) sahip olduğumuzda kullanılır.

##### Nasıl Kullanılır?

Öncelikle bir algoritma interface'i oluşturulur .Daha sonra oluşturulan interface'i implement edecek
algoritma sınıfları yaratılır. Context sınıfı yaratılır. Bu sınıf içerisinde algoritma interface türünden
algoritmaların set edilmesi için bir metod bulunur. Bu metod sayesinde Context sınıfı algoritma nesnesini
tutmuş olur. Son olarak bir Client sınıfı oluşturulur. Bu sınıf Context sınıfından ve algoritma sınıflardan
nesneler üreterek işlemlerin yapılmasını sağlar.


##### Faydaları Nedir?
Runtime (Çalışma) zamanında özel bir işlem için tanımlanmış algoritmalardan dilediğimizi seçebiliriz.

##### Gerekenler
* Türü interface olan Strategy sınıfı: **ISerializable**
* En az iki tane somut Strategy sınıfı: **JsonSerializer**, **XmlSerializer**, **BinarySerializer**
* Context sınıfı
* Client sınıfı

###### ISerializable

```c#
public interface ISerializable
    {
        void Serialize(string str);
        void DeSerialize(string str);
    }
```
###### JsonSerializer
```c#
public class JsonSerializer:ISerializable
{
    public void Serialize(string str)
    {
        Console.WriteLine("Json Serileştirme");
    }

    public void DeSerialize(string str)
    {
        Console.WriteLine("Json Ters Serileştirme");
    }
}
```