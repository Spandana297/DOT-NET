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
           List<Class1> itemmod = new List<Class1>();
            itemmod.Add(new Class1 { ID = "id1", Name = "chair", Cost = 100 });
            itemmod.Add(new Class1 { ID = "id2", Name = "headset", Cost = 200 });


            Console.WriteLine("Hello!");

            dis.DisplayItems(itemmod);


        }
    }
}
