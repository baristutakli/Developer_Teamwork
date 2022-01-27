## Observer Patern

Oberser pattern is a behavioral pattern. You can use this pattern, when an object want to notify several objects about changes and need to inform them regardless of what the object is. This patter also let us to add and remove easly an observer.

 Three keywords to understand this pattern such as **"subject(target)"**, **"observer"** and **"Concrete"**.
* **Subject** is the target object
* **Observer** is the abstract class which might be an interface or an Abstract class that holds the reference of concrete observers.
*  **Concrete** is a class that is derived from an abstract class or is an implementation of an interface.

In my example, i simulated a real-world situation:  
* The subject is **Russia.cs**
* **Observer.cs** is the abstract class
* **USA.cs**, **NATO.cs** and **Turkey.cs** are the concrete observers.



#### Observer.cs

```c#
public abstract class Observer
{
    public abstract void Update(double distance);
}
```

#### Russia.cs
```c#
public class Russia
{
    private double distance=1000;
    public double Distance { get { return distance; } set {  distance = value;  } }
    private List<Observer> observers;
    public Russia()
    {
        
        this.observers = new List<Observer>();
    }

    public void Move(double move) { Distance -= move; Notify(); }
        
    public void AddObserver(Observer observer) => this.observers.Add(observer);
    public void RemoveObserver(Observer observer) => this.observers.Remove(observer);

    public void Notify()
    {
        Console.WriteLine("Warning!!!");
        foreach (var observer in this.observers)
        {
            observer.Update(Distance);
        }
    }
}


```

#### USA.cs

```c#
    public class USA : Observer
    {
        public override void Update(double distance)
        {
            Console.WriteLine($"USA will  sanction against to Russia\tDistance: {distance}");
        }
    }
```


