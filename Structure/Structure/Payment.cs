using System;
using System.Collections.Generic;
namespace Structure
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


        public void Costdetailes(ref int ItemCost, int Quantity, string Selected)
        {
            int total = ItemCost * Quantity;
            double totalcost = total+ total * 0.18;
            Console.WriteLine("The selected item is :" + Selected);
            Console.WriteLine("The cost of the item is :" + ItemCost);
            Console.WriteLine("The cost of the item with GST is :" + totalcost);
        }

        public void paymentMode()
        {
            Console.WriteLine("Please select the Payment Mode");
            Console.WriteLine("Available options are:Cash\nUPI\nDebitCard\nBank_Transfer");
            String St = Console.ReadLine();
            string selected = St;
            Console.WriteLine("selected  payment method is:"+selected);

        }
        
    }
}