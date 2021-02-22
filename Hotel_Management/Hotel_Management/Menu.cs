using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Essentials;

namespace Hotel_Management
{
    class Menu
    {      public  static void DisplayMenu()
        {
           

            
            List<Class2> items = new List<Class2>
            {
              new Class2{ID=1,Name="Masala Dosa",Cost=5 },
              new Class2{ID=2,Name="Set Dosa",Cost=3 },
              new Class2{ID=3,Name="Onion Dosa",Cost=4 },
              new Class2{ID=4,Name="Idly n Sambar",Cost=5 },
              new Class2{ID=5,Name="Palav",Cost=10 },
             };
           
            foreach (var ele in items)
            {
                Console.WriteLine("{0} - {1}  -${2}",ele.ID, ele.Name, ele.Cost);
            }

            Console.WriteLine("Please select the Dishes That you would like to order");
            int Cost = 0;
            for (int i = 0; i < items.Count; i++)
            {
                String SelectedItems = Console.ReadLine();
                if (SelectedItems.ToLower() != "no")
                {
                    int? ItemCost = items.FirstOrDefault(c => c.Name.ToLower() == SelectedItems.ToLower())?.Cost;
                    Cost += ItemCost ?? 0;
                    Console.WriteLine("Would you like to order Something Else?");
                    Console.WriteLine("Type No if you are not willing to order");

                }
                else
                {
                    Console.WriteLine("the Cost for your Order is ${0}",Cost);
                    Console.WriteLine("Thank You");
                }



            }
               
          





        }













        } 

    }

