using System;
using System.Collections.Generic;
using ModelsItem;
namespace Billing
{
    class Program
    {
        private static readonly IDictionary<string, int> items;

        static void Main(string[] args)
        {
            display dis = new display();
            Class1 itemmod = new Class1();

            Console.WriteLine("Hello!");

            dis.DisplayItems(itemmod.items);


        }
    }
}
