using System;
using System.Collections.Generic;

class Animal{
    public virtual void MakeSound(){
        Console.WriteLine("Generic animal sound:\n");
    }
}

class Dog : Animal{
    public override void MakeSound(){
        Console.WriteLine("Dog: Woof! Woof!");
    }
}

class Cat : Animal{
    public override void MakeSound(){
        Console.WriteLine("Cat: Meow! Meow!");
    }
}

class Cow : Animal
{
    public override void MakeSound(){
        Console.WriteLine("Cow: Moo! Moo!");
    }
}

class Program{
    public static void Main(string[] args){
        List<Animal> animals = new List<Animal>{
            new Dog(),
            new Cat(),
            new Cow()
        };
        
        Animal pets = new Animal();
        pets.MakeSound();

        foreach (var animal in animals){
            animal.MakeSound();
        }
    }
}