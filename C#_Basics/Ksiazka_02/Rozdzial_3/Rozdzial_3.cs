/*Tworzenie Typów*/
using System;
using System.Security.Cryptography.X509Certificates;

public class Test
{
    public const string Message = "Witaj, świecie"; //stała
}

//metody wyrażeniowe
class MetodyWyrazeniowe
/*int Foo (int x) { return x * 2; }
 mozna zapisać inaczej : */
{
    int Foo(int x) => x * 2; // zastępuje return

    void Fool(int x) => Console.WriteLine(x); //typ zwrotny -> void
    int Cube(int value) => value * value * value; //metoda zdefiniowana w innej metodzie
}

//konstruktor egzemplarzy

//class Znikaj
//{
//    public string Pandasy()
//    {
//        Panda p = new Panda("Petey");
//        Console.WriteLine(p);
//    } // wywołanie konstruktora
//}
public class Panda
{
    string name; // definicja pola
    //public Panda(string n) // definicja konstruktora
    //{
    //    name = n; // kod inicjalizacyjny (ustawienie wartości pola)
    //}

    //ALBO :
    public Panda(string n) => name = n;
}
public class Wine
{
    public decimal Price;
    public int Year;
    public Wine(decimal price) { Price = price; }
    public Wine(decimal price, int year) : this(price) { Year = year; }
    public Wine(decimal price, DateTime year) : this(price, year.Year) { }
}

/* destruktory: Metoda dekonstrukcji musi nazywać się Deconstruct i zawierać przynajmniej jeden parametr wyjściowy*/
class Rectangle
{
    public readonly float Width, Height;
    public Rectangle(float width, float height)
    {
        Width = width;
        Height = height;
    }
    public void Deconstruct(out float width, out float height)
    {
        width = Width;
        height = Height;
    }
}

//Do wywoływania dekonstruktora służy specjalna składnia:
class WywolajDekonstruktor
{
    public void Dekonstruktor()
    {
        var rect = new Rectangle(3, 4);

        (float width, float height) = rect; // dekonstrukcja
        //albo
        //float width, height;
        //rect.Deconstruct(out width, out height);
        //albo
        //rect.Deconstruct(out var width, out var height);
        Console.WriteLine(width + " " + height); // 3 4

        // a calosc mozna skrocic:
        //var (width, height) = rect;
    }
}
//Inicjalizatory obiektów
public class Bunny
{
    public string Name;
    public bool LikesCarrots;
    public bool LikesHumans;
    public Bunny() { }
    public Bunny(string n) { Name = n; }
    public Bunny(string name,
                bool likesCarrots = false,
                bool likesHumans = false)
    {
        Name = name;
        LikesCarrots = likesCarrots;
        LikesHumans = likesHumans;
    }
}

class WywolajBunny
{
    public static void Bun()
    {
        //Bunny b1 = new Bunny { Name = "Bo", LikesCarrots = true, LikesHumans = false };
        //Bunny b2 = new Bunny("Bo") { LikesCarrots = true, LikesHumans = false };

        //to samo co wyżej, rozpisane
        Bunny temp1 = new Bunny(); // temp1 to nazwa wygenerowana przez kompilator
        temp1.Name = "Bo";
        temp1.LikesCarrots = true;
        temp1.LikesHumans = false;
        Bunny b1 = temp1;

        Bunny temp2 = new Bunny("Bo");
        temp2.LikesCarrots = true;
        temp2.LikesHumans = false;
        Bunny b2 = temp2;
        Console.WriteLine(b2);
        Console.WriteLine(b2);
        Bunny b3 = new Bunny(name: "Bo",
                            likesCarrots: true);
        Console.WriteLine(b3);
    }

}
/*Referencja this |Referencji this można używać tylko w niestatycznych składowych klas i struktur*/

public class Niedzwiedz
{
    public Niedzwiedz Mate;
    public void Marry(Niedzwiedz partner)
    {
        Mate = partner;
        partner.Mate = this;
    }
}
public class Testy
{
    string name;
    public Testy(string name) { this.name = name; }
}

/*Własności :: Własności deklaruje się tak jak pola, ale z dodatkiem bloku get/set
Elementy get i set to metody dostępowe własności*/

public class Stock
{
    decimal currentPrice; // prywatne pole pomocnicze
    public decimal CurrentPrice // własność publiczna
    {
        get { return currentPrice; }
        set { currentPrice = value; }
    }
    //albo inicjalizator wlasnosci
    //Własności z inicjalizatorami mogą być tylko do odczytu
    public decimal CurrentPricee { get; set; } = 123;

    decimal currentPrices, sharesOwned;
    //public decimal Worth
    //{
    //    get { return currentPrices * sharesOwned; }
    //}
    //wlasnosc wyrazeniowa, to co wyzej a krocej =>
    public decimal Worth => currentPrice * sharesOwned;
    public decimal Worths
    {
        get => currentPrice * sharesOwned;
        set => sharesOwned = value / currentPrice;
    }
}
public class El
{
    public static void Oblicz()
    {
        Stock msft = new Stock();
        msft.CurrentPrice = 30;
        msft.CurrentPrice -= 3;
        Console.WriteLine(msft.CurrentPrice); //27
    }
}
//Dostępność metod get i set
public class Foo
{
    private decimal x;
    public decimal X
    {
        get { return x; }
        private set { x = Math.Round(value, 2); } // set jest private
    }
}
//public class Note
//{
//    public int Pitch { get; init; } = 20; // własność „tylko do inicjalizacji”
//    public int Duration { get; init; } = 100; // własność „tylko do inicjalizacji”

//}


//tylko do odczytu wlasnosci
public class Note
{
    public int Pitch { get; }

    public int Duration { get; }
        public Note(int pitch = 20, int duration = 100)
        {
            Pitch = pitch; Duration = duration;
        }
}
//public class Notes
//{
//    readonly int _pitch;
//    public int Pitch { get => _pitch; init => _pitch = value; }

//indeksatory
class Sentence
{
    string[] words = "Nosił wilk razy kilka".Split();
    public string this[int wordNum] // indeksator [] kwadratowe nawiasy
    {
        get { return words[wordNum]; }
        set { words[wordNum] = value; }
    }
}
class Indeksator
{
    public static void Ind()
    {
        Sentence s = new Sentence();
        Console.WriteLine(s[1]); // wilk
        s[1] = "kangur";
        Console.WriteLine(s[1]); // kangur
    }
}
//konstruktor statyczny
class Text
{
    static Text() { Console.WriteLine("Typ zainicjalizowany."); }
}
class Fo
{
    public static Fo Instance = new Fo();
    public static int X = 3;
    Fo() => Console.WriteLine(X); // 0
}

/*Dziedziczenie*/
public class Asset
{
    public string Name;
}
public class Stockk : Asset // dziedziczy po Asset
{
    public long SharesOwned;
}
public class House : Asset // dziedziczy po Asset
{
    public decimal Mortgage;
}
class Dziedziczenie
{
    public static void Fly()
    {
        Stockk msft = new Stockk { Name = "MSFT", SharesOwned = 1000};
        Console.WriteLine(msft.Name); // MSFT
        Console.WriteLine(msft.SharesOwned); // 1000
        House mansion = new House
        {
            Name = "Mansion",
            Mortgage = 250000
        };
        Console.WriteLine(mansion.Name); // Mansion
        Console.WriteLine(mansion.Mortgage); // 250000

        //rzutowanie w gore
        Stockk msfft = new Stockk();
        Asset a = msfft; // rzutowanie w górę // zmienna a jest typu Asset, ograniczony dostep!
        Console.WriteLine(a == msft); // prawda

        // rzutowanie w dol
        //Stockk msftt = new Stockk();
        //Asset aa = msftt; // rzutowanie w górę
        //Stock s = (Stockk)aa; // rzutowanie w dół
        //Console.WriteLine(s.SharesOwned); // nie ma błędu
        //Console.WriteLine(s == aa); // prawda
        //Console.WriteLine(s == msftt); // prawda

        /*Operator as wykonuje rzutowanie w dół, ale w razie niepowodzenia operacji zamiast zgłaszać
        wyjątek, zwraca wartość null*/

    }
public static void Display(Asset asset) // podklasa klasy
{
    System.Console.WriteLine(asset.Name);
}
}

// operatory as oraz in s126
// abstrakcyjne klasy i skladowe
/*Jeśli klasa jest abstrakcyjna, nie można tworzyć jej obiektów. Możliwe jest tylko tworzenie obiektów jej konkretnych podklas.*/

//Metoda ToString
namespace String
{
    //class Tostring
    //{
    //    int x = 1;
    //    string s = x.ToString();
    //}
    public class Panda
    {
        public string Name;
        public override string ToString() => Name;
    }
    class Verify
    {
        static void Ver()
        {
            Panda p = new Panda { Name = "Piotrek" };
            Console.WriteLine(p); // Piotrek
        }
    }
}
//STRUKTURY
namespace Punkt
{
    public struct Point
    {
        int x, y;
        public Point(int x, int y) { this.x = x; this.y = y; }
    }
    //tylko do odczytu
    readonly struct Punkcik
    {
        public readonly int X, Y;
    }
    class Some
    {
        void SomeMethod()
        {
            Point p; // p będzie przechowywany na stosie
        }
        struct Point { public int X, Y; }
    }
    class View
    {
        public static void Ccc()
        {
            Point p1 = new Point(); // p1.x i p1.y będą miały wartość 0
            Point p2 = new Point(1, 1); // p2.x i p2.y będą miały wartość 1
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Point p3 = default;
            Console.WriteLine(p3);
            Punkcik pu1 = new Punkcik();
            Console.WriteLine(pu1);
        }

    }

}
/*Modyfikatory dostępu
public: peny dostép, domylny poziom

internal domyślny poziom dostępności typów niezagnieżdżonych.

private  domyślny poziom dostępności składowych klas i struktur.

protected Dostępność ograniczona do typu i jego podklas.

protected internal Suma modyfikatorów protected i internal. Składowa zdefiniowana jako protected internal jest dostępna na dwa sposoby.

private protected (od C# 7.2) Przecięcie funkcjonalności protected i internal. Składowa zdefiniowana jako private protected
jest dostępna tylko w zawierającym ją typie lub podklasach znajdujących się w tym samym zestawie (co sprawia, że jest mniej dostępna niż składowa mająca tylko modyfikator
protected lub internal).*/

/*interfejs cos jak klasa abstrakcyjna
 nterfejsów używaj do reprezentacji typów o niezależnych implementacjach.*/
public interface IEnumerator
{
    bool MoveNext();
    object Current { get; }
    void Reset();
}
internal class Countdown : IEnumerator //publiczna implementacja skkadowych interfejsu
{
    int count = 11;
    public bool MoveNext() => count-- > 0;
    public object Current => count;
    public void Reset() { throw new NotSupportedException(); }
}

/*Typ zagnieżdżony to taki, który jest zadeklarowany w zakresie innego typu.*/
public class TopLevel
{
public class Nested { } // klasa zagnieżdżona
public enum Color { Red, Blue, Tan } 
}
public class NieTopLevel
{
    TopLevel.Color color = TopLevel.Color.Red;
}

//typ generyczny

public class Stack<T>
{
    int position;
    T[] data = new T[100];
    public void Push(T obj) => data[position++] = obj;
    public T Pop() => data[--position];
}



class TypGeneryczny
{
    static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }
    public static void Main()
    {
        int a= 5;
        int b= 10;
        Swap(ref a, ref b);
        var stack = new Stack<int>();
        stack.Push(5);
        stack.Push(10);
        int x = stack.Pop(); 
        int y = stack.Pop(); 
        Console.WriteLine(x); //10
        Console.WriteLine(y); //5

    }

}
//Deklarowanie parametrów typów s156

