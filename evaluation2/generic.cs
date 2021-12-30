using System.IO;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("----------Dictionary----------");
        var new_dict = new Dictionary<int,string>(){
            {1,"Rima"},{2,"Aswathi"}
        };
        new_dict.Add(3,"Suriya");
        new_dict.Add(4,"Sreelakshmi");
        new_dict.Add(5,"Soja");
        
        Console.WriteLine("Student List");
        foreach(var items in new_dict)
                
                Console.WriteLine("ID : {0} | Name : {1}", items.Key, items.Value);
                
        Console.WriteLine("----------List----------");
        var numbers1 = new List<int>() {1,2,3,4,5,6};
        var numbers2 = new List<int>() {11,12,13,14,15,16};
        for(int i=0;i<numbers1.Count;i++){
            
            Console.WriteLine("Added number : {0} ", numbers1[i]+numbers2[i]);
        }
        
    }
}
