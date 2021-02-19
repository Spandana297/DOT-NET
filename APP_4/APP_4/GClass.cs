using System;
using System.Collections.Generic;
using System.Text;

namespace APP_4
{
    class GClass<T>
    {
        List<T> ServiceList= new List<T>();

       

    }

   class Service : GClass<string>
    {
        List<string> ServiceList = new List<string>() {"Mobile Accessories","Circuit Design",
            "Instrumentatin Repair","Home Equipment"};
        String Serviceselected;
        public void DisplayService() {
            Console.WriteLine("The services Provided in the ABC Electronics are:");
            for (int i = 0; i < ServiceList.Count; i++) {

                Console.WriteLine( ServiceList[i]);
            }
            Serviceselected = Console.ReadLine();
            Console.WriteLine(Serviceselected);







        }
    }

      

}











