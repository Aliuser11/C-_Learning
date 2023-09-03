using System;
public class Program
{
    static void Main()
    {

    }
}
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
    //    private static void MM(string[] args)
    //    {
    //        int x = 12 * 30; // instrukcja 1
    //        Console.WriteLine(x); // instrukcja 2
    //    }
    //}

    //internal class Program
    //{
    //    private static void Aain(string[] args)
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

    //namespace Animals
    //{
    //    public class Panda
    //    {
    //        public string Name; // Instance field
    //        public static int Population; // Static field
    //        public Panda(string n) // Constructor
    //        {
    //            Name = n; // Assign the instance field
    //            Population += 1; // Increment the static Population field
    //        }
    //    }
    //    class WynikPandy
    //    {
    //        public static void XXX(string[] args)
    //        {
    //            Animals.Panda p = new Animals.Panda("Pan Dee"); // korzystanie z przestrzeni animals
    //            Panda p2 = new Panda("Pan Dah");
    //            Console.WriteLine(p.Name); // Pan Dee
    //            Console.WriteLine(p2.Name); // Pan Dah
    //            Console.WriteLine(Panda.Population); // 2
    //        }
    //    }
    //}

    /*int x = 12345; // int to 32-bitowa liczba całkowita
    long y = x; // niejawna konwersja na 64-bitowy typ całkowitoliczbowy
    short z = (short)x; // jawna konwersja na 16-bitowy typ całkowitoliczbowy*/

    //namespace Liczbyyy
    //{
    //    public struct Point { public int X, Y; }

    //}
    //class Sprawdz
    //{
    //    static void CMain(string[] args)
    //    {
    //        Liczbyyy.Point p1 = new Liczbyyy.Point();
    //        p1.X = 7;
    //        Liczbyyy.Point p2 = p1; // przypisanie powoduje utworzenie kopii
    //        Console.WriteLine(p1.X); // 7
    //        Console.WriteLine(p2.X); // 7
    //        p1.X = 9; // zmiana p1.X
    //        Console.WriteLine(p1.X); // 9
    //        Console.WriteLine(p2.X); // 7
    //    }

    //}

    /* systematyka typów predefiniowanych: W języku C# obecne są następujące typy predefiniowane:

    Typy wartościowe
    • Liczbowe
    • liczby całkowite ze znakiem (sbyte, short, int, long);
    • liczby całkowite bez znaku (byte, ushort, uint, ulong);
    • liczby rzeczywiste (float, double, decimal).
    • Logiczny (bool).
    • Znakowy (char).

    Typy referencyjne
    • Łańcuchowy (string).
    • Obiektowy (object).*/

    //class milion
    //{
    //    int million = 1_000_000; // literałach liczbowych można używać znaków podkreślenia
    //    double d = 1.5; //Literały reprezentujące liczby rzeczywiste mogą być wyrażane w formacie dziesiętnym lub wykładniczym,
    //    double milllion = 1E06;
    //    public double Publikacja(double d, int million, double milllion)
    //    {
    //        System.Console.WriteLine(d.GetType()); // Double (double)
    //        Console.WriteLine(milllion.GetType()); // Double (double)
    //        Console.WriteLine(million.GetType()); // int
    //        return 0;
    //    }
    //}

    /* Przedrostki iterałów liczbowych:
    F float float f = 1.0F;
    D double double d = 1D;
    M decimal decimal d = 1.0M;
    U uint uint i = 1U;
    L long long i = 1L;
    UL ulong ulong i = 1UL;*/

    //class Operatory
    //{
    //    public void M(string[] args)
    //    {
    //        long i = 5;
    //        double x = 4.0;
    //        float f = 4.5F;
    //        decimal d = -1.23M;
    //        int i1 = 100000001;
    //        float ff = i1; // rząd wielkości zachowany, utracona precyzja
    //        int i2 = (int)ff; // 100000000
    //        //Przepełnienie całkowitoliczbowe
    //        int a = int.MinValue;
    //        a--;
    //        Console.WriteLine(a == int.MaxValue); // prawda
    //        //Operator checked
    //        int aa = 1000000;
    //        int bb = 1000000;
    //        int cc = checked(aa * bb); // sprawdza tylko wyrażenie
    //        checked // sprawdza wszystkie wyrażenia
    //        { // w bloku instrukcji

    //            cc = aa * bb;

    //        }
    //        int xx = int.MaxValue;
    //        int yy = unchecked(xx + 1);
    //        unchecked { int z = xx + 1; }
    //    }
    //}

    ////Typ logiczny i operatory

    //class Porownanie

    //{
    //    public Porownanie()
    //    {
    //        int x = 1;
    //        int y = 2;
    //        int z = 1;
    //        //W przypadku typów referencyjnych równość jest standardowo określana na podstawie referencji,
    //        //a nie rzeczywistej wartości obiektu
    //        Console.WriteLine(x == y); // fałsz
    //        Console.WriteLine(x == z); // prawda
    //        Dude d1 = new Dude("Jan");
    //        Dude d2 = new Dude("Jan");
    //        Console.WriteLine(d1 == d2); // fałsz
    //        Dude d3 = d1;
    //        Console.WriteLine(d1 == d3); // prawda
    //    }
    //    public class Dude
    //    {
    //        public string Name;
    //        public Dude(string n) { Name = n; }
    //    }
    //    public void MCain(string[]args)
    //    {
    //        Porownanie p1 = new Porownanie();
    //    }

    //}

//Operatory warunkowe s64