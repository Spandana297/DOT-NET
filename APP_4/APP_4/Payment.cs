using System;
using System.Collections.Generic;
namespace APP_4
{
    enum PaymentMode
    {       // changeing the type of enum member
        Cash,
        UPI,
        DebitCard,
        Bank_Transfer,
    }
    class Payment
    {


        public virtual  void  Costdetailes(ref int ItemCost, int Quantity,string Selected)
        {
             int TotalCost=ItemCost * Quantity;
            Console.WriteLine("The item you have selected is " +Selected);
            Console.WriteLine("the total cost is " + TotalCost);
          
            
        }

        public void PaymentMode()
        {
            Console.WriteLine("Please select the Payment Mode");
            Console.WriteLine("Available options are:Cash\nUPI\nDebitCard\nBank_Transfer");
            String St = Console.ReadLine();
            string selected = St;
            Console.WriteLine("selected  payment method is:"+selected);
            Console.WriteLine("Thank You ,Happy Shopping");

        }
        
    }
}