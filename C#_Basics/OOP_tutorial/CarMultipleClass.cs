using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_tutorial
{
    //Using Multiple Classes
public class Cars
    {
        public string color = "red";
        //To create an object of class, specify the class name, followed by the object name, and use the keyword new
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cars myObject1 = new();
            Cars myObject2 = new();
            Console.WriteLine(myObject1.color);
            Console.WriteLine(myObject2.color);
            Console.ReadLine();
        }
    }

}
