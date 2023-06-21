using System;

public class Prop 
{
    private string name ;
    private int age ;
    
    public string naming
    {   
        set
        {
        if(value == null) 
            throw new Exception("name not eql to null");
        else 
            name = value ;
        }
        get
        {
            return name;
        }
    }
    
    public int agein
    {   
        set 
        {
        if(value <= 0) 
            throw new Exception("age should greater than zero");
        else 
            age = value ;
        }
        get
        {
            return age;
        }
    }
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Prop obj1 = new Prop();
        obj1.naming = "aaaa";
        //obj1.agein(-10);
        Console.WriteLine ("obj1 name:"+obj1.naming);
        Console.WriteLine ("obj1 age:"+obj1.agein);
    }
}