// Properties and Encapsulation
class Person
{
    //private string name; // field

    //public string Name   // property
    //{
    //    get { return name; }   // get method
    //    set { name = value; }  // set method
    //}
    // OR Using automatic properties:
    public string Name  // property
    { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        Person myObj = new Person();
        myObj.Name = "Liam";
        Console.WriteLine(myObj.Name);

        // Create a myCar object
        Car myCar = new Car();

        // Call the honk() method (From the Vehicle class) on the myCar object
        myCar.honk();

        // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
        Console.WriteLine(myCar.brand + " " + myCar.modelName);
    }
}
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