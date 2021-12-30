using System.IO;
using System;

public delegate void newDelegate(int A);
class Program
{
    static void Main()
    {
        newDelegate ndeleg = addprogram.addition;
        ndeleg(2030);
        
        newDelegate dleg = (int b)=> Console.WriteLine("Using Lambda expression addition of 500 : {0}", 500+b);
        dleg(5450);
    }
}
class addprogram
{
    public static void addition(int a){
        Console.WriteLine("Addition of 100 using delegates : {0}", 100+a);
    }
}
