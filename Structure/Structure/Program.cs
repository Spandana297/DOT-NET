using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Partial_class;

namespace Structure
{
    public partial class Partial_class
    {
        public void FinalGreeting()
        {
            Console.WriteLine("Thank You ,Visit Again");
        }

    }
    class Program
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
                new Items{ID = "id2",Name = "mouse",Cost = 200}
            };
            


            ModelItems model = new ModelItems();
            Class1 Greet = new Class1();
            
            Payment pay = new Payment();
            
            Greet.Greeting1();
            model.DisplayItems(items);
            pay.paymentMode();
           
            

        }
    }
    }