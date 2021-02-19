using System;
using System.Collections.Generic;
using System.Text;

namespace APP_4
{
    class VClass:Payment

    {  // calculation of IGST 
        public override void Costdetailes(ref int ItemCost, int Quantity, String Selected)    // virtual function 
        {
            Double FinalCost = (ItemCost * Quantity * 1.18);
            Console.WriteLine("The totalcost with GST :" + FinalCost);



        }

    }
}
