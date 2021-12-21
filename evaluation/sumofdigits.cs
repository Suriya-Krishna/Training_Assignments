using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SumOfdigits
{
	public class Program
	{
		public static void Main(string[] args)
		{
		  string number=Console.ReadLine();
		  long numb=Convert.ToInt64(number);
			long sum=0;
			long temp=0;
			while(numb>0){
			  temp=numb%10;
			  sum=sum+temp;
			  numb=numb/10;
			}
			Console.WriteLine("The Sum is "+sum);
		}
	
	}
}
