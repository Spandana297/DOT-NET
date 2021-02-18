

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ClassLibrary1;

namespace APP_4
{
    public partial class Class1
    {
        public void FinalGreeting()
        {
            Console.WriteLine("Thank You ,Visit Again");
        }

       
    }
    class Program:ModelItems
    {
        static void Main(string[] args)
        {
            //List<Items> items = new List<Items>();
            //items.Add(new Items
            //{
            //    ID = "id1",
            //    Name = "Keyboard",
            //    Cost = 100,

            //});
            //items.Add(new Items
            //{
            //    ID = "id2",
            //    Name = "Chair",
            //    Cost = 200,

            //});
            List<Items> items = new List<Items>()
            {
                new Items{ID = "id1",Name = "Keyboard",Cost = 100},
                new Items{ID = "id2",Name = "Mouse",Cost = 200},
                new Items{ID = "id3",Name = "Chair",Cost = 300},
            };

       

            ModelItems model = new ModelItems();
            Class1 Greet = new Class1();
          
            Greet.Greeting1();
            model.DisplayItems(items);
           

           



        }
    }
}