using System;

//encapsulation
namespace oops
{
    class Plot
    {
        //member variables
        private double length;
        private double width;
        internal Double Cost;
      

        public void Acceptdetails()
        {
            Console.WriteLine("Enter Length: ");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Width: ");
            width = Convert.ToDouble(Console.ReadLine());

        }
        public Double GetArea()
        {
            return length * width;

        }
        public Double GetCost()
        {
            return length * width*100;

        }
        public void Display()
        {
            Console.WriteLine("Length(Sq Ft): {0}", length);
            Console.WriteLine("Width(Sq Ft): {0}", width);
            Console.WriteLine("Area(Sq Ft): {0}", GetArea());
            Console.WriteLine("Cost($): {0}", GetCost());

        }
    }

 class ExecuteRectangle
    {
        static void Main(string[] args)
        {
           Plot p = new Plot();
           p.Acceptdetails();
            p.Display();
            Console.ReadLine();
        }
    }


}