using System;

public enum gender
    {
        male,
        female,
        unknown
    }
    
public class HelloWorld
{
    public static void Main(string[] args)
    {   
        Person p1 = new Person{name = "aaa",gen = gender.male};
        Person p2 = new Person{name = "bbb",gen = gender.female};
        Person p3 = new Person{name = "ccc",gen = gender.unknown};
        Console.WriteLine (p1.name+" "+p1.gen);
        Console.WriteLine (p2.name+" "+p2.gen);
        Console.WriteLine (p3.name+" "+p3.gen);
    }
    
}

public class Person 
{
    public string name{ get; set;}
    public gender gen{ get; set;}
}