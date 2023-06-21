using System;

abstract class Animal
{
    public abstract void MakeSound(); 

    public void Sleep() 
    {
        Console.WriteLine("The animal is sleeping.");
    }
}


class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("The cat meows.");
    }
    
    public void Sleep() 
    {
        Console.WriteLine("?????????????????");
    }
}

class Program
{
    static void Main()
    {
        // animal parent class in first line
        Animal animal = new Cat();
        Cat animal1 = new Cat();
        animal.MakeSound(); 
        animal.Sleep();    
        animal1.MakeSound(); 
        animal1.Sleep(); 
    }
}
