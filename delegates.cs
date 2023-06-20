using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {   
        IsEven iseven = new IsEven(method);
        
        Main1.even(10,iseven);
        
    }
    public static bool method(int n) 
    {
        return n%2==0;
    }
}
delegate bool IsEven(int n);

class Main1
{
    public static void even(int n , IsEven method) 
    {
        if(method(n)) 
        Console.WriteLine ("Given input is EVEN");
        else 
        Console.WriteLine ("Given input is Odd");
    }
}