using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        
        Func<int, int, int> addFunction = (x, y) => x + y;

        int result = addFunction(5, 3);
        
        Console.WriteLine("Result: " + result);
        
        int[] arr = {1,2,3,4,5};
        
        Array.ForEach(arr , i => {
            
            if(i%2 == 0)
            
            Console.WriteLine(i+"- even");
            
            else 
            
            Console.WriteLine(i+"- odd");
            }
        );
    }
}
