using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Reversewords
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Enter the string you want to reverse");
			string original=Console.ReadLine();
			string[] reversed = original.Split(' ');
			Array.Reverse(reversed);
			Console.Write("The reverse string is: ");
			int n = reversed.Length;
			for(int i=0;i<n;i++){
			  Console.Write(reversed[i] + " ");
			}
			
		}
	}
}
