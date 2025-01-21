using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace delegate_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICoffee coffee = new EmptyCoffee();
            ICoffee coffeeMilk = new MilkDecorator(coffee);
            ICoffee coffeeSugar = new SugarDecorator(coffee);
            ICoffee coffeeEvery = new SugarDecorator(coffeeMilk);

            Console.WriteLine("Default:");
            Console.WriteLine(coffee.Make());

            Console.WriteLine("With Milk:");
            Console.WriteLine(coffeeMilk.Make());

            Console.WriteLine("With Sugar:");
            Console.WriteLine(coffeeSugar.Make());

            Console.WriteLine("With Milk and Sugar:");
            Console.WriteLine(coffeeEvery.Make());





        }
    }
}
