using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Partial_class;

namespace Structure

{
   
    struct Items
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
       
    }
    class ModelItems
    {
        
       
        public int ItemCost;
        public String Selected;//type ref
        public void DisplayItems(List<Items> items)
        {
            Console.WriteLine("The Items available are:\n");
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine("{0} - ${1}",items[i].Name,items[i].Cost);
            }
            Console.WriteLine("Please select one item!");
            Selected = Console.ReadLine(); 
            Console.WriteLine("Enter quantity:");
            int EnteredQuantity = int.Parse(Console.ReadLine()); 
            int Quantity = EnteredQuantity; //unboxing
            ItemCost = items.FirstOrDefault(c => c.Name.ToLower() == Selected.ToLower()).Cost;
            //ItemCost = items.First(c => c.Name.ToLower() == Selected.ToLower()).Cost;
            Console.WriteLine(ItemCost);
            Payment pay = new Payment();
           pay.Costdetailes(ref ItemCost, Quantity, Selected); //pass as ref
          
        }

    }
}
