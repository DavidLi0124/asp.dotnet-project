// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;

namespace HelloWorld
{
    interface FirstInterface
    {
        void firstFunc();
    }

    interface SecondInterface
    {
        void secondFunc();
    }

    class Firstsecond : FirstInterface, SecondInterface
    {
        public void firstFunc() {
            Console.WriteLine("It is the firstinterface override function");
        }
        public void secondFunc() {
            Console.WriteLine("It is the secondinterface override function");
        }
    }

    class Car
    {
        public string color = "red";
        private string name;
        public Car()
        {
            name = string.Empty;
        }

        public string Name  { get { return name; } set { name = value; } }
    }

    class Benz : Car
    {
        public string brand = "BENZ";
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Name = "Benz";
            Console.WriteLine(car.Name);

            Benz b = new Benz();
            Console.WriteLine(b.color);

            Fruit fruit = new Fruit();
            Console.WriteLine(fruit.name);

            Firstsecond first = new Firstsecond();
            first.firstFunc();
            first.secondFunc();
        }
    }
}