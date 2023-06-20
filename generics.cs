using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {   
        bool temp = Eq<string>.method("a" , "a");
        Console.WriteLine("Given input are Equal : "+temp);
        Eql obj1 = new Eql();
        bool temp1 = obj1.method("a","b");
        Console.WriteLine("Given input are Equal : "+temp1);
        Console.ReadLine();
    }
}

public class Eq<T>
{
    public static bool method (T a , T b) 
    {
        return a.Equals(b);
    }
}

public class Eql
{
    public bool method (object a , object b) 
    {
        return a == b;
    }
}