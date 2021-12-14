using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp_trial
{
    class Program
    {
        static void Main(string[] args)
        {
            int ch =1;
            while(ch==1){
                Console.WriteLine("Enter your choice: 1 2 3 4");
                string readValue = Console.ReadLine();
                int readInt = Convert.ToInt32(readValue);
                if (readInt == 1)
                {
                    Console.WriteLine("Using for loop");
                    for (int i = 1; i <= 100; i++)
                    {
                        Console.WriteLine(i);
                    }
                    Console.WriteLine("Using while loop");
                    int a = 1;
                    while (a <= 100)
                    {
                        Console.WriteLine(a);
                        a++;
                    }
                    Console.WriteLine("Using do-while loop");
                    int y = 1;
                    do
                    {
                        Console.WriteLine(y);
                        y++;
                    } while (y <= 100);

                }
                else if (readInt == 2)
                {
                    for (int j = 2; j <= 100; j += 2)
                    {
                        Console.WriteLine(j);
                    }
                }
                else if (readInt == 3)
                {
                    int m = 1;
                    double val = 2;
                    while (m <= 100)
                    {
                        Console.WriteLine(val);
                        val = val + val;
                        m++;
                    }
                }
                else if (readInt == 4)
                {
                    int sum = 0;
                    for (int x = 1; x <= 10; x++)
                    {
                        sum = sum + x;
                    }
                    Console.WriteLine("The sum of first ten integers = " + sum);
                }
                else
                {
                    Console.WriteLine("Sorry operation not available");
                }
                Console.WriteLine("Do you want to continue: 1/0");
                string ch1 = Console.ReadLine();
                ch = Convert.ToInt32(ch1);
                if(ch == 0){Console.WriteLine("The operation  is over, thank you");}
            }
            }
        }
        
}
