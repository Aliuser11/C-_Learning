using System;
//Using Multiple Classes
public class Cars
{
    public string color = "red";
    public string model;
    //To create an object of class, specify the class name, followed by the object name, and use the keyword new
    //Constructors can be used to set initial values for fields
    public Cars() // class constructor
    {
        model = "Mustang";
    }
}
//Create a Car class with three class members: two fields and one method.
class MySecondCar
{

    public string color = "red"; // a field; variables inside a class are called fields
    public int maxSpeed = 200;
    public int minSpeed; //leave the fields blank, and modify them when creating the object
    public void Full()
    {
        Console.WriteLine("Method inside a class");
    }

}
class MultipleCarObjects
{
    public string model;
    public string color;
    public int year;
    public void Full()
    {
        Console.WriteLine("Another Method inside a class");
    }
}
class CarsConstructor
{
    public string model;
    public int year;
    public CarsConstructor(string modelName, int modelYear)
    {
        model = modelName;
        year = modelYear;
    }
}


public class ProgramCar
{
    static void Main(string[] args)
    {
        Cars myObject1 = new();
        MySecondCar myObject2 = new();
        Console.WriteLine(myObject1.color);//from Cars class
        Console.WriteLine(myObject1.model);//this will call the constructor

        Console.WriteLine(myObject2.maxSpeed); // from other class
        //modify field when creating the object
        myObject2.minSpeed = 50;
        Console.WriteLine(myObject2.minSpeed);

        MultipleCarObjects Ford = new();
        Ford.model = "Mustang";
        Ford.color = "red";
        Ford.year = 1969;

        MultipleCarObjects Opel = new ();
        Opel.model = "Astra";
        Opel.color = "white";
        Opel.year = 2005;

        Console.WriteLine($"ford model: "+ Ford.model);
        Console.WriteLine(Opel.model);
        myObject2.Full();  // access the method inside MySedondCar class

        CarsConstructor Fiat = new("Mustang", 1963);
        Console.WriteLine(Fiat.model+" "+ Fiat.year); // made from constructor wit parameter
    }
}

