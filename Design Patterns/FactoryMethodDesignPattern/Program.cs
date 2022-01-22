using DesignPatterns.FactoryMethodDesignPattern.Abstract;
using DesignPatterns.FactoryMethodDesignPattern.Concrete;
using DesignPatterns.FactoryMethodDesignPattern.Helpers.EnumHelpers;
using System;

namespace DesignPatterns
{
    class Program
    {
        static string strUsageArea = string.Empty;

        static void Main(string[] args)
        {
            GetUI();
        }
        public static void GetUI()
        {
            Console.Write($"Öge seçiniz : {Electronics.Computer}(1) \t {Electronics.HeadSet}(2) \t {Electronics.Phone}(3) \t");
            var selection = Console.ReadLine();
            switch (selection)
            {
                case "1":
                    Console.WriteLine(FactoryMethodWithInterface(Electronics.Computer));
                    break;
                case "2":
                    Console.WriteLine(FactoryMethodWithInterface(Electronics.HeadSet));
                    break;
                case "3":
                    Console.WriteLine(FactoryMethodWithInterface(Electronics.Phone));
                    break;
                default:
                    break;
            }
        }

        public static string FactoryMethodWithAbstract(Electronics electronic)
        {
            Electronic electronicElement=null;
            switch (electronic)
            {
                case Electronics.Computer:
                    electronicElement = new Computer();
                    break;
                case Electronics.HeadSet:
                    electronicElement = new HeadSet();
                    break;
                case Electronics.Phone:
                    electronicElement = new Phone();
                    break;
            }
            return electronicElement.UsageAreaWithAbstractClass(strUsageArea);
        }

        public static string FactoryMethodWithInterface(Electronics electronic)
        {
            IElectronic electronicElement = null;
            switch (electronic)
            {
                case Electronics.Computer:
                    electronicElement = new Computer();
                    break;
                case Electronics.HeadSet:
                    electronicElement = new HeadSet();
                    break;
                case Electronics.Phone:
                    electronicElement = new Phone();
                    break;
            }
            return electronicElement.UsageAreaWithInterface(strUsageArea);
        }
    }
}
