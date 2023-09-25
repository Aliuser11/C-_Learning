using Microsoft.SqlServer.Server;
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

//212