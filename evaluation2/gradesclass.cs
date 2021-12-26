using System.IO;
using System;

class Program
{
    static void Main()
    {
           Console.WriteLine("Enter the no: of students");
           string number = Console.ReadLine();
           int num = Convert.ToInt32(number);
           for(int i=0;i<num;i++){
        	ReportOfStudent student1 = new ReportOfStudent();
        	Console.WriteLine("Enter the name and section");
        	string name= Console.ReadLine();
        	string sect=Console.ReadLine();
			    student1.details(name, sect);
			    Console.WriteLine("Enter the mark");
            string mark1 = Console.ReadLine();
            int num1 = Convert.ToInt32(mark1);
            string mark2 = Console.ReadLine();
            int num2 = Convert.ToInt32(mark2);
            string mark3 = Console.ReadLine();
            int num3 = Convert.ToInt32(mark3);
            string mark4 = Console.ReadLine();
            int num4 = Convert.ToInt32(mark4);
            string mark5 = Console.ReadLine();
            int num5 = Convert.ToInt32(mark5);
            
			student1.marks(num1,num2,num3,num4,num5);
             Console.WriteLine("");  
           }
    }
}
public class ReportOfStudent
	  {
	    int chemistry, physics, maths, biology,english;
	    string name, section;
	    public void details(string nam,string sect){
	      name=nam;
	      section=sect;
	      Console.WriteLine("Name : "+ name);
	      Console.WriteLine("Section : "+ section);
	      
	    }
	    public void grades(int x){
	      if (x>=90){
	        Console.WriteLine(" Grade : A+");
	        
	      }
	      else if(x>=80){
	       Console.WriteLine(" Grade : A");}
	      else if(x>=70){
	      Console.WriteLine(" Grade : B+");}
	      else if(x>=60){
	      Console.WriteLine(" Grade : B");}
	      else if(x>=50){
	      Console.WriteLine(" Grade : C+");}
	      else if(x>=40){
	      Console.WriteLine(" Grade : C");}
	      else if(x>=30){
	        Console.WriteLine(" Grade : D");
	        
	      }
	      else{Console.WriteLine("Grade : E");}
	      }
	     public void totalMandG(int x, int y, int z, int a, int b){
	       int marks = x+y+z+a+b;
	       Console.WriteLine("Total mark out of 500 : "+ marks);
	       int avg = marks/5;
	       Console.Write("Total ");
	       grades(avg);
	     }
	     public void marks(int p, int q, int r,int s, int t){
	       chemistry=p;
	       physics=q;
	       maths=r;
	       biology=s;
	       english=t;
	       Console.Write("Chemistry : "+chemistry);
	       grades(chemistry);
	       Console.Write("Physics : "+physics);
	       grades(physics);
	       Console.Write("Maths : "+maths);
	       grades(maths);
	       Console.Write("Biology : "+biology);
	       grades(biology);
	       Console.Write("English : "+english);
	       grades(english);
	       totalMandG(chemistry,physics,maths,biology,english);
	     }
	    }
