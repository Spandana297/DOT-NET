using System;

namespace ClassLibrary1
{
    public partial class Class1
    {
        public void Greeting1()   //error** //virtual and then ovrride
        {
            Console.WriteLine("Hello!!!!!.....");// partial methods (return type-> void,cannot use out parameters
            Console.WriteLine("Welcome to ABC Electronics ");
            Console.WriteLine("Items in the shop are:");

        }
        //public partial void Greeting2()   //error** //virtual and then ovrride
        //{
        //    Console.WriteLine("Hello!!!!!.....");// partial methods (return type-> void,cannot use out parameters
        //    Console.WriteLine("Welcome to ABC Electronics ");
        //    Console.WriteLine("Items in the shop are:");

        //}


    }
}
