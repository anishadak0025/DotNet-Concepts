using System.Collections.Generic;

class Program
{
    static void Main()
    {
      List<int> students = new List<int>()
        {
            1,
            2
        };
    
       foreach (int s in students)
        {
            Console.WriteLine(s);
        }
    }
}

