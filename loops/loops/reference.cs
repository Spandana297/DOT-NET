using System;
//ref parameter doesnot pass property
class reference
{

   
    public static void Main()
    {
        string str = "Spandana";
        // before passing to the method
        Console.WriteLine(str);
    
    // as a reference parameter 
    Display(ref str);

        // after passing to the method
        Console.WriteLine(str);
    }

    static void Display(ref string str1)
    {

       //change parameter
        str1 = " Hai Spandana Mahendra";
    }
}