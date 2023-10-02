﻿using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


//Zaawansowane elementy języka C#
namespace Zdarzenie
    { 
    internal class Program
    {
        private static void NewMain(string[] args)
        {
            Stock stock = new Stock("THPW");
            stock.Price = 27.10M;
            // rejestracja w zdarzeniu PriceChanged
            //stock.PriceChanged += stock_PriceChanged;
            stock.Price = 31.59M;



            void stock_PriceChanged(object sender, PriceChangedEventArgs e)
            {
                if ((e.NewPrice - e.LastPrice) / e.LastPrice > 0.1M)
                    Console.WriteLine("Uwaga: wzrost cen akcji o 10%!");
            }
        }
    }

    public class PriceChangedEventArgs : EventArgs
        {
            public readonly decimal LastPrice;
            public readonly decimal NewPrice;
            public PriceChangedEventArgs(decimal lastPrice, decimal newPrice)
            {
                LastPrice = lastPrice; NewPrice = newPrice;
            }
        }
    public class Stock
    {
        string symbol;
        decimal price;
        public Stock(string symbol) { this.symbol = symbol; }
        public event EventHandler PriceChanged;
        protected virtual void OnPriceChanged(EventArgs e)
        {
            PriceChanged?.Invoke(this, e);
        }
        public decimal Price
        {
            get { return price; }
            set
            {
                if (price == value) return;
                price = value;
                OnPriceChanged(EventArgs.Empty);
            }
        }
    }
}
namespace lambda
{

    /*Wyrażenia lambda*/
    class Wykonaj

    {
        static Func<int> Natural()
        {
            int seed = 0;
            Console.WriteLine(seed); 
            return () => seed++;

        }

        static void NewMain()
        {
            //Func<int, int> sqr = x => { return x * x; };
            //Transformer sqr = x => { return x * x; };
            //Console.WriteLine(sqr(3));
            //delegate int Transformer(int i);
            int factor = 2;
            Func<int, int> multiplier = n => n * factor;
            Console.WriteLine(multiplier(3));

            Func<int, int> multiplier2 = n => n * factor;
            factor = 10;
            Console.WriteLine(multiplier2(3)); // 30


            Func<int> natural = Natural();
            Console.WriteLine(natural()); // 0
            Console.WriteLine(natural()); // 1


        }
    }
}

namespace Try
{
    class Test
    {
        static void MainMain(string[] args)
        {
            try
            {
                byte b = byte.Parse(args[0]);
                Console.WriteLine(b);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("podaj argument.");
                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("to nie liczba");
            }
            catch (OverflowException)
            {
                Console.WriteLine("przekazano za duzo");
            }
            finally
            {
                Console.WriteLine("koniec");
            }
        }
    }
}


class Fibonacci
{

    static void Main()
    {

        IEnumerable<int> Fibs(int fibCount)
        {
            for (int i = 0, prevFib = 1, curFib = 1; i < fibCount; i++)
            {
                yield return prevFib;
                int newFib = prevFib + curFib;
                prevFib = curFib;
                curFib = newFib;
            }

        }
        foreach (int fib in Fibs(6))
            Console.WriteLine(fib + " ");
        Console.WriteLine();



        IEnumerable<int> EvenNumbersOnly(IEnumerable<int> sequence)
        {
            foreach (int x in sequence)
                if ((x % 2) == 0)
                    yield return x;
        }

        foreach (int fib in EvenNumbersOnly(Fibs(6)))
            Console.WriteLine(fib);



    }
}

//struktura Nullable <T>

/*public struct Nullable<T> where T : struct
{
    public T Value { get; }
    public bool HasValue { get; }
    public T GetValueOrDefault();
    public T GetValueOrDefault(T defaultValue);

}
{
    Nullable<int> i = new Nullable<int>();
    Console.WriteLine(!i.HasValue);
}*/

/*operatory rownosci*/
class XXX
{ 
    static void Main()
    {
        int? x = 5;
        int? y = null;
        
        bool b = (x.HasValue && y.HasValue)
        ? (x.Value < y.Value)
        : false;

        int? c = (x.HasValue && y.HasValue)
        ? (int?)(x.Value + y.Value)
        : null;
        // c ma wartość null (przy założeniu, że x wynosi 5, a y ma wartość null)

        Console.WriteLine(null == null); // prawda
        Console.WriteLine((bool?)null == (bool?)null); //prawda

        //oOperatory & i | z typem bool
        bool? n = null;
        bool? f = false;
        bool? t = true;
        Console.WriteLine(n | n); // (null)
        Console.WriteLine(n | f); // (null)
        Console.WriteLine(n | t); // prawda
        Console.WriteLine(n & n); // (null)
        Console.WriteLine(n & f); // fałsz
        Console.WriteLine(n & t); // (null)

    }
}


 /* Metoda rozszerzająca jest statyczną metodą statycznej klasy,
gdzie modyfikator this jest stosowany do pierwszego parametru. Typ pierwszego parametru
będzie tym typem, który zostanie rozszerzony.
 */

public static class StringHelper
{
    public static bool IsCapitalized(this string s)
    {
        if (string.IsNullOrEmpty(s)) return false;
        return char.IsUpper(s[0]);
    }
}


namespace Utils
{
    public static class StringHelper
    {
        public static bool IsCapitalized(this string s)
        {
            if (string.IsNullOrEmpty(s)) return false;
            return char.IsUpper(s[0]);
        }
    }
}

/*powolanie sie na namespace Utils aby uzyc metody IsCapitalized
 */
namespace MyApp
{
    using Utils;
    class Test
    {
        static void Main() => Console.WriteLine ("Perth".IsCapitalized());
    }
}

//Typy anonimowe
/*Do typu anonimowego należy odnosić się przy użyciu słowa kluczowego var, ponieważ ten typ
nie ma nazwy.*/
internal class AnonymousGeneratedTypeName
{
    private string name; // rzeczywista nazwa pola nie ma znaczenia
    private int age; // rzeczywista nazwa pola nie ma znaczenia
    public AnonymousGeneratedTypeName(string name, int age)
    {
        this.name = name; this.age = age;
    }
    public string Name { get { return name; } }
    public int Age { get { return age; } }
    // metody Equals i GetHashCode są przesłonięte (zob. rozdział 6.)
    // metoda ToString też jest przesłonięta
}
class Test
{
    static void Main()
    {
        var dude = new { Name = "Bartek", Age = 23 };
        int Age = 23;
        var dude2 = new { Name = "Bartek", Age, Age.ToString().Length };
    }
}

//Krotki
class Boo
{
    public string name;
    public int age;
    public void GetPerson(string name, int age)

    {
        this.name = name; this.age = age;
    }

}
class Goo
{

    static void Main()
    {
        var bob = ("Bartek", 23); // kompilator wydedukuje typy elementów
        Console.WriteLine(bob.Item1); // Bartek
        Console.WriteLine(bob.Item2); //23

        var joe = bob; // joe jest *kopią* boba
        joe.Item1 = "Jacek"; // zmiana elementu Item1 krotki joe z Bartek na Jacek
        Console.WriteLine(bob); // (Bartek, 23)
        Console.WriteLine(joe);//jacek,23

        (string, int) GetPerson() => ("Bartek", 23);
    }
}

//Definiowanie REKORDU
//record Point
//{
//    public Point (double x, double y) => (X, Y) = (x, y); //albo => { this.X = x; this.Y = y; }
//    public double X { get; init; }
//    public double Y { get; init; }
//}

//record Point(double X, double Y)
//{
//    // Tutaj mogą się znajdować opcjonalne definicje dodatkowych składowych klasy...
//}

//record Point
//{
//    public Point (double x, double y) => (X, Y) = (x, y);
//    double _x, _y;
//    public double X { get => _x; init { _x = value; _distance = null; } }
//    public double Y { get => _y; init { _y = value; _distance = null; } }
//    double? _distance;
//    public double DistanceFromOrigin => _distance ??= Math.Sqrt(X * X + Y * Y);
//}
//Point p1 = new Point(2, 3);
//Console.WriteLine(p1.DistanceFromOrigin); // 3,605551275463989
//Point p2 = p1 with { Y = 4 };
//Console.WriteLine(p2.DistanceFromOrigin); // 4,47213595499958

//223 rekordy i porownywanie
//230 Atrybuty

/* Wiązanie statyczne a wiązanie dynamiczne
 dynamic d = ...
 d.Quack();

    Duck d = ... //statyczne
    d.Quack(); 

 dynamic x = "cześć"; // typem statycznym jest dynamic, a typem wykonawczym — string
 var y = "cześć"; // typem statycznym i wykonawczym jest string
 int i = x; // błąd wykonawczy (nie można przekonwertować typu string na int)
 int j = y; // błąd kompilacji (nie można przekonwertować typu string na int)

rzutowanie wyrażenia dynamicznego natyp statyczny daje wyrażenie statyczne:
dynamic x = 2;
var y = (int)x; // typem statycznym y jest int

wywołania konstruktora zawsze dają wyrażenia statyczne — nawet w przypadku wywołańz dynamicznymi argumentami. W tym przykładzie zmienna x otrzyma statyczny typ StringBuilder:
dynamic capacity = 10;
var x = new System.Text.StringBuilder (capacity);

typy statyczne są używane także — w wiązaniu dynamicznym.

class Program
{
    static void Foo (object x, object y) { Console.WriteLine ("oo"); }
    static void Foo (object x, string y) { Console.WriteLine ("os"); }
    static void Foo (string x, object y) { Console.WriteLine ("so"); }
    static void Foo (string x, string y) { Console.WriteLine ("ss"); }
static void Main()
    {
    object o = "cześć";
    dynamic d = "żegnaj";
    Foo (o, d); // os    zgodnie z zasadami rozpoznawania przeciążenia, zostanie wybrana druga implementacja metody Foo ze względu na statyczny typ o i wykonawczy typ d.
    }
}
*/

//Przeciążanie true i false System.Data.SqlTypes.SqlBoolean.
public struct SqlBoolean
{
    public static bool operator true(SqlBoolean x)
    => x.m_value == True.m_value;
    public static bool operator false(SqlBoolean x)
    => x.m_value == False.m_value;
    public static SqlBoolean operator !(SqlBoolean x)
    {
        if (x.m_value == Null.m_value) return Null;
        if (x.m_value == False.m_value) return True;
        return False;
    }
    public static readonly SqlBoolean Null = new SqlBoolean(0);
    public static readonly SqlBoolean False = new SqlBoolean(1);
    public static readonly SqlBoolean True = new SqlBoolean(2);
    private SqlBoolean(byte value) { m_value = value; }
    private byte m_value;
}

//Kod niebezpieczny
class Program
{ 
    unsafe void BlueFilter(int[,] bitmap)
    {
        int length = bitmap.Length;
        fixed (int* b = bitmap)
        {
            int* p = b;
            for (int i = 0; i < length; i++)
                *p++ &= 0xFF;
        }
    }
}

//fixed <= instrukcja 
class Testowe
{
    int x;
    static void Main()
    {
        Test test = new Test();
        unsafe
        {
            fixed (int* p = &test.x) // przypina test
//Typy wartościowe zadeklarowane wewnątrz typów referencyjnych wymagają, aby typ referencyjnybył przypięty
            {
                *p = 9;
            }
            System.Console.WriteLine(test.x);
        }
    }
}

//inne zastosowanie FIXED, tworzenie buforów. 

unsafe struct UnsafeUnicodeString
{
    public short Length;
    public fixed byte Buffer[30]; // alokuje blok 30 bajtów
}
unsafe class UnsafeClass
{
    UnsafeUnicodeString uus;
    public UnsafeClass(string s)
    {
        uus.Length = (short)s.Length;
        fixed (byte* p = uus.Buffer)
            for (int i = 0; i < s.Length; i++)
                p[i] = (byte)s[i];
    }
}
class Testy
{
    static void Main() { new UnsafeClass("Christian Troy"); }
}


//Wskaźnik pusty (void*). Zmiennej tego typu nie można poddać dereferencji i nie można przy jej użyciu wykonywać operacji arytmetycznych.
class Przyklad
{
    unsafe static void Main()
    {
        short[] a = { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 };
        fixed (short* p = a)
        {
            // sizeof zwraca rozmiar typu wartościowego w bajtach
            Zap(p, a.Length * sizeof(short));
        }
        foreach (short x in a)
            System.Console.WriteLine(x); // drukuje same zera
    }
    unsafe static void Zap(void* memory, int byteCount)
    {
        byte* b = (byte*)memory;
        for (int i = 0; i < byteCount; i++)
            *b++ = 0;
    }
}

//245