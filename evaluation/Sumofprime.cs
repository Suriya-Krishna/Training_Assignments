using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SumOfPrimenumbers
{
	public class Program
	{
		public static void Main(string[] args)
		{
			int count =0;
			long sum = 0;
			for(int i=2;count<=500;i++){
			  if(Prime(i)){
			    sum=sum+i;
			    count++;
			  }
			}
			Console.WriteLine("The sum is "+sum);
		}
		public static bool Prime(int number){
		  int x = (int)Math.Floor(Math.Sqrt(number));
		  if(number==1)return false;
		  if(number==2)return true;
		  else
		    for(int j=2;j<=(x);++j){
		      if(number%j==0)return false;
		    }
		    return true;
		  
		} 
	}
}
