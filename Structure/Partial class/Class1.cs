using System;

namespace Partial_class
{
    public partial class Class1
    {
        public void Greeting1()   //error** //virtual and then ovrride
        {
            Console.WriteLine("Hello!!!!!.....");// partial methods (return type-> void,cannot use out parameters
            Console.WriteLine("Welcome to ABC Electronics ");
            Console.WriteLine("Items in the shop are:");

        }
        

        }
}
