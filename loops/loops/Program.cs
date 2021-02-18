using System;
using System.IO;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = new System.Diagnostics.Stopwatch();
            StreamReader text = new StreamReader("C:/Users/Documents\text.txt");

            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Documents\text.txt");
            watch.Start();
            foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
                Console.WriteLine("\t" + line);
            }
            watch.Stop();
            long t1 = watch.ElapsedMilliseconds;
            

            //=============================================
          
            watch.Start();
            string Count = text.ReadToEnd();
            for(int i = 0; i < Count.Length; i++)
            {
                Console.WriteLine(Count[i]);
            }
            watch.Stop();

            long t2 = watch.ElapsedMilliseconds;
            Console.WriteLine("readind file using for each loop: ms" +t1);

            Console.WriteLine("readind file using for each loop: ms" +t2);
        }
    }
}
