using System;
//class Mnozenie
//{
//    public int FeetToInches(int feet)
//    {
//        int inches = feet * 12;
//        return inches;
//    }
//    public int Publikuj(int a)
//    {
//        return FeetToInches(a);
//    }

//}

//class Glowna
//{
//    private static void Main(string[] args)
//    {
//        int x = 12 * 30; // instrukcja 1
//        Console.WriteLine(x); // instrukcja 2
//    }
//}

//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        int FeetToInches(int feet)
//        {
//            int inches = feet * 12;
//            return inches;
//        }

//        Console.WriteLine(FeetToInches(30)); // 360
//    }
//}

//public class UnitConverter
//{
//    int ratio; // pole
//    public UnitConverter(int unitRatio) // konstruktor
//    {
//        ratio = unitRatio;
//    }
//    public int Convert(int unit) // metoda
//    {
//        return unit * ratio;
//    }
//}
//class Pragramuj
//{
//    public static void Druk()
//    {
//        UnitConverter feetToInchesConverter = new UnitConverter(12);
//    }
//}

namespace Animals
{
    public class Panda
    {
        public string Name; // Instance field
        public static int Population; // Static field
        public Panda(string n) // Constructor
        {
            Name = n; // Assign the instance field
            Population += 1; // Increment the static Population field
        }
    }
    class WynikPandy
    {
        public static void Main(string[] args)
        {
            Animals.Panda p = new Animals.Panda("Pan Dee");
            Panda p2 = new Panda("Pan Dah");
            Console.WriteLine(p.Name); // Pan Dee
            Console.WriteLine(p2.Name); // Pan Dah
            Console.WriteLine(Panda.Population); // 2
        }
    }
}

