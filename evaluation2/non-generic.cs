using System.IO;
using System;
using System.Collections;

class Program
{
    static void Main()
    {
        var new_list = new ArrayList();
        var new_list1 = new ArrayList(){
            101, "Suriya", "Windows", true, "Dotnet", 'S'
        };
        string[] fr_list = {"Soja","Sreelakshmi","Rima","Aswathi"};
        var new_stack = new Stack();
        new_stack.Push(102);
        new_stack.Push(103);
        new_stack.Push(104);
        new_stack.Push(105);
        
        var myqueue = new Queue();
        myqueue.Enqueue("My");
        myqueue.Enqueue("Details");
        
        var new_hash = new Hashtable();
        new_hash.Add(1,"SQL");
        new_hash.Add(2,"C#");
        new_hash.Add(3,"Js");
        new_hash.Add(4,"jQuery");
        new_hash.Add(5,"MVC");
        new_hash.Add(6,"Web API");
        
        new_list.AddRange(new_list1);
        new_list.AddRange(fr_list);
        new_list.AddRange(new_stack);
        new_list.AddRange(myqueue);
        new_list.AddRange(new_hash);
        
        for(int i=0;i<new_list.Count;i++){
            Console.WriteLine(new_list[i] + " ");
            
                /*var n = new_list[i];
                    Console.Write("Key:{0}, Value:{1}", n.Key,n.Value);*/
                
            
            
        }
    }
}
