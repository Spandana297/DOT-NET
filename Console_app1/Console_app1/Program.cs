using System;
using System.Text;
using System.Collections;

namespace Console_app1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 10, 45, 85, 07, 35, 78, 29, 19 };
            StringBuilder s1 = new StringBuilder("Using linear search  ");
            int key = 7;
            for(int i =0;i<8;i++)
            {
                if(a[i]==key)
                {
                    string str = s1.ToString();
                    Console.Write(str);
                    Console.WriteLine("key  is found at position "+ (i+1));
                    
                }
               
            }
        
        }
    }
}
