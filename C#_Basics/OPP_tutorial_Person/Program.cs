
/*"inheritance concept"  two categories:

    Derived Class (child) - the class that inherits from another class
    Base Class (parent) - the class being inherited from

To inherit from a class, use the : symbol.*/

class Vehicle  // base class (parent) 
{
    public string brand = "Ford";  // Vehicle field
    public void honk()             // Vehicle method 
    {
        Console.WriteLine("Tuut, tuut!");
    }
}

class Car : Vehicle  // derived class (child)
{
    public string modelName = "Mustang";  // Car field
}

/*Inheritance lets us inherit fields and methods from another class. Polymorphism uses those methods to perform different tasks*/
class Animal
{
    public virtual void AnimalSound()
    {
        Console.WriteLine("The sound");
    }
}
class Pig: Animal
{
    public override void AnimalSound()
    {
        Console.WriteLine("pig soound");
    }
}
class Dog:Animal
{
    public override void AnimalSound()
    {
        Console.WriteLine("dog soound: bow");
    }
}

abstract class Anima //abstract class Animal 
{
    public abstract void animalSound();
    public void sleep()
    {
        Console.WriteLine("Zzz");
    }
}
class SmallA : Anima
{
    public override void animalSound()
    {
        Console.WriteLine("The pig says: wee wee");
    }
}

//interface
class Zwierz
{
    interface IAnimal
    {
        void Sound();
        void Run();
    }
}
class Kotek : Zwierz
{
    public void Sound()
    {
        Console.WriteLine("The pig says: wee wee, provided from interface");
    }
}

//Multiple Interfaces 
interface IFirstInterface
{
    void myMethod(); // interface method
}

interface ISecondInterface
{
    void myOtherMethod(); // interface method
}
class DemoClass : IFirstInterface, ISecondInterface
{
    public void myMethod()
    {
        Console.WriteLine("Some text from IFirstInterface ..");
    }
    public void myOtherMethod()
    {
        Console.WriteLine("Some other text from ISecondInterface...");
    }
}


class Odglosy
{
    static void Main()
    {
        Animal myAnimal = new();
        Animal myPig = new Pig();
        Animal myDog = new Dog();
        myAnimal.AnimalSound();
        myPig.AnimalSound();
        myDog.AnimalSound();

        SmallA mysmall = new ();
        mysmall.animalSound();
        mysmall.animalSound();
        Kotek mykot = new();
        mykot.Sound();

        DemoClass myObj = new DemoClass();
        myObj.myMethod();
        myObj.myOtherMethod();

    }
}