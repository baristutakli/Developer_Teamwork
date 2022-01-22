using LearnObserverPattern.Abstract;
using LearnObserverPattern.Concrete;
using System;
using System.Collections.Generic;

namespace LearnObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*Subjcet: Russia
             *Observers: Turkey, USA, NATO
             *Oberver is an abstract class which has one abstract methoh.
             *
             */


            Russia RussiaFromTheNorth = new Russia();
            RussiaFromTheNorth.AddObserver(new USA());
            RussiaFromTheNorth.Move(100);
            RussiaFromTheNorth.AddObserver(new NATO());
            RussiaFromTheNorth.Move(100);
            RussiaFromTheNorth.AddObserver(new Turkey());
            RussiaFromTheNorth.Move(200);
        }
    }
}
