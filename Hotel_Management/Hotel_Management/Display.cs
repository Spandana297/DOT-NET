using System;
using System.Collections.Generic;
using System.Text;
using Essentials;

namespace Hotel_Management
{
    abstract  class Display
    {     
        public virtual void Costdetailes(ref int? ItemCost, int Quantity, string Selected)
        {        
            int total = ItemCost.Value * Quantity ;
            double totalcost = total + total * 0.18;
            Console.WriteLine("The selected service is :" + Selected);
            Console.WriteLine("The cost of the service is :" + total);
            Console.WriteLine("The cost of the service with GST is :" + totalcost);
        //    Class1 message1 = new Class1();
        //    message1.Msg2();
        }
    }
    //public partial class Class1
    //{
    //    public void Msg2()
    //    {
    //        Console.WriteLine("Thank You ,Visit Again");

    //    }
    //}
}
