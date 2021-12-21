using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ArrayMultiply
{
	public class Program
	{
		public static void Main(string[] args)
		{
		  Console.WriteLine("Enter the number of terms");
		  string temp1 = Console.ReadLine();
		  int num1=Convert.ToInt32(temp1);
			int[] array1=MakeArray(num1);
			int[] array2=MakeArray(num1);
			int[] array3= new int[num1];
			for(int i=0;i<num1;i++){
			  array3[i]=array2[i] * array1[i];
			}
			for(int i=0;i<array3.Length;i++){
			  Console.WriteLine(array3[i]);
			}
		}
		public static int[] MakeArray(int num){
		  int[] new_array= new int[num];
		  for(int j=0;j<num;j++){
		    Console.WriteLine("Enter the integer");
		    string temp = Console.ReadLine();
		    int n1=Convert.ToInt32(temp);
		    new_array[j]=n1;
		  }
		  return new_array;
		  }
	}
}
