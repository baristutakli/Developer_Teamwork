using LearnObserverPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnObserverPattern.Concrete
{
    /// <summary>
    /// Herkesin Rusya'nın yapacağı hamleyi gözlüyor
    /// </summary>
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

    
}
