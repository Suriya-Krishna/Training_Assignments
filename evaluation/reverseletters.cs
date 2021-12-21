using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ReverseLetters
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Enter the string you want to reverse");
			string Str = Console.ReadLine();
			char[] new_str = new char[Str.Length];
			for(int i=0,j=Str.Length-1;i<=j;i++,j--){
			  new_str[i]=Str[j];
			  new_str[j]=Str[i];
			}
			Console.Write("The reversed string is :");
			for(int i=0; i<new_str.Length;i++){
			  
			  Console.Write(new_str[i]);
			}
		}
	}
}
