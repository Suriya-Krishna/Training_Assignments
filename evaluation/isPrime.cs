using System.IO;
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number");
        string n = Console.ReadLine();
        int n1= Convert.ToInt32(n);
        int temp = 1;
        if(n1==1){Console.WriteLine("It is neither prime nor composite");}
        if(n1==2){Console.WriteLine("It is a prime number");}
        for(int i=2;i<=n1;i++){
            if(n1%i == 0){
                temp=0;
                break;
            }
        }
        if(temp==1){Console.WriteLine("It is a prime number");}
        else{Console.WriteLine("It is not a prime number");}
        
    }
}
