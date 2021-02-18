using ModelsItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Billing
{
    class display
    {
        public void DisplayItems(List<Class1> items)
        {
           
            Console.WriteLine("The items in the shop are:");
            foreach (var ele in items)
            {
                Console.WriteLine("{0} - $ {1}",
                          ele.Name, ele.Cost);
            }
            Console.WriteLine("Please select one item.");
            string Selected = Console.ReadLine().ToLower();
            StringBuilder str = new StringBuilder();
            str.Append("You have purchased item ");
            str.Append(Selected);
            Console.WriteLine(str);
            Console.WriteLine("Enter quantity:");
            int Quantity = int.Parse(Console.ReadLine());
            int? ItemCost = items.FirstOrDefault(c => c.Name == Selected)?.Cost;
            //var Item = items.FirstOrDefault(c => c.Name == Selected);
            //string st = Item.Name;
            //int cost = Item?.Cost??0;
            int Total = 0;
            TotalDisplay(ItemCost, Quantity, Selected, out Total);
            Totalcost(Total);
        }
         
       
        public void TotalDisplay(int? ItemCost, int Quantity, string Selected, out int Total)
        { 
              Total= ItemCost ?? 0 * Quantity;
            Console.WriteLine("Total Cost: " + Total);
          

        }

        public void Totalcost( int Total)
        {
           double Totalcost =(Total + 0.18*Total);
            Console.WriteLine("The total cost with GST is:" + Totalcost);

        }
    }
}