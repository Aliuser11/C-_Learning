using N1;
using System;
using System.Diagnostics.Contracts;
using System.Text;

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

//Operatory warunkowe  & |
//class Pogoda
//{
//    static bool UseUmbrella(bool rainy, bool sunny, bool windy)
//    {
//        //return !windy && (rainy || sunny); /stosują skróconą metodę obliczania wartości
//        return !windy & (rainy | sunny);  // NIE stosują skróconą metodę obliczania wartości
//    }
//Operator warunkowy (trójargumentowy)
/*postać q ? a : b. Jeśli warunek q jest spełniony, następuje wykonanie wyrażenia a,
 w przeciwnym przypadku wykonywane jest wyrażenie b.*/
//    public int Max(int a, int b)
//    {
//        return (a > b) ? a : b; 
//    }
//}
//class SprawdzPogode
//{
//    public static void Main(string[] args)
//    {
//        Pogoda pog1 = new Pogoda();
//        Console.WriteLine(pog1.Max(10, 6));
//        Console.WriteLine(pog1.Max(8, 16));
//        Console.ReadKey();
//    }
//}

/*Tabela --> Sekwencje specjalne:
Znak   Znaczenie     Wartość
\' Pojedynczy cudzysłów 0x0027
\" Podwójny cudzysłów prosty 0x0022
\\ Ukośnik wsteczny 0x005C
\0 Wartość null 0x0000
\a Alert 0x0007
\b Backspace 0x0008
\f Wysuw strony 0x000C
\n Nowy wiersz 0x000A
\r Powrót karetki 0x000D
\t Tabulator poziomy 0x0009
\v Tabulator pionowy 0x000B*/

//string
//class KonkatencjaInterpolacja
//{
//    public static void Main()
//    {
//        string s = "a" + "b";
//        string ss = "a" + 5; // a5
//        Console.WriteLine(s + ss);
//        /*Łańcuch poprzedzony znakiem $ nazywa się łańcuchem interpolowanym, czyli takim, 
//         w którym można wpisywać wyrażenia w klamrach:*/
//        int xx = 4;
//        Console.Write($"Kwadrat ma {xx} boki.\n"); // wyswietla w konsoli: Kwadrat ma 4 boki.
//        bool b = true;
//        Console.WriteLine($"Odpowiedź w systemie binarnym to {(b ? 1 : 0)}");
//    }
//}

//TABLICE
//class Tablice
//{
//    public struct Point { public int X, Y; }
//    static void Main()
//    {
//        //Wszystkie tablice dziedziczą po klasie System.Array
//        char[] vowels = new char[6];
//        vowels[0] = 'a';
//        vowels[1] = 'e';
//        vowels[2] = 'i';
//        vowels[3] = 'o';
//        vowels[4] = 'u';
//        vowels[5] = 'y';
//        Console.WriteLine(vowels[1]); // wypisze e
//        for (int i = 0; i < vowels.Length; i++)
//        {
//            Console.Write(vowels[i]); // aeiouy
//        }
//        //albo
//        char[] vowels2 = new char[] { 'a', 'e', 'i', 'o', 'u', 'y' };
//        //lub jeszcze tak
//        char[] vowels3 = { 'a', 'e', 'i', 'o', 'u', 'y' };

//        int[] a = new int[1000];
//        Console.Write(a[123]);

//        Point[] ab = new Point[1000];
//        int ix = ab[500].X; // 0


//    }
//}

//class IndeksyZakresy
//{
//    /*Indeksy umożliwiają odwoływanie się do elementów względem końca tablicy za pomocą operatora
//    ^. Na przykład ^1 odnosi się do ostatniego elementu, ^2 — do przedostatniego itd.:*/
//    public void Main()
//    {
//        char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'y' };
//        char lastElement = vowels[^1]; // 'y'
//        char secondToLast = vowels[^2]; // 'u'
//        Index first = 0;
//        Index last = ^1;
//        char firstElement = vowels[first]; // 'a'
//        char lastElement = vowels[last]; // 'y'
//        char[] firstTwo = vowels[..2]; // 'a', 'e'
//        char[] lastThree = vowels[2..]; // 'o', 'u', 'y'
//        char[] middleOne = vowels[2..3]; // 'i'
//        char[] lastTwo = vowels[^2..]; // 'u', 'y'
//        Range firstTwoRange = 0..2;
//        char[] firstTwo = vowels[firstTwoRange]; // 'a', 'e'
//    }
//}

//class TabliceWielowymiarowe
//{
//    public static void Main()
//    {
//        //tablica prostokatna:
//        int[,] matrix = new int[3, 3];
//        for (int i = 0; i < matrix.GetLength(0); i++)
//            for (int j = 0; j < matrix.GetLength(1); j++)
//                matrix[i, j] = i * 3 + j;
//        // albo tak można ja stworzyc
//        int[,] matrix2 = new int[,]
//        {
//            {0,1,2},
//            {3,4,5},
//            {6,7,8}
//        };

//        //Tablice nieregularne
//        int[][] matrix3 = new int[3][];
//        for (int i = 0; i < matrix3.Length; i++)
//            {
//                matrix3[i] = new int[3];
//                for (int j = 0; j < matrix3[i].Length; j++)
//                    matrix3[i][j] = i * 3 + j;
//            Console.WriteLine(matrix3);
//            }
//        int[][] matrix4 = new int[][]
//        {
//            new int[] {0,1,2},
//            new int[] {3,4,5},
//            new int[] {6,7,8,9}

//        };
//        int[,] rectangularMatrix =
//        {
//            {0,1,2},
//            {3,4,5},
//            {6,7,8}
//        };

//        int[][] jaggedMatrix =
//        {
//            new int[] {0,1,2},
//            new int[] {3,4,5},
//            new int[] {6,7,8}
//        };
//        var rectMatrix = new int[,] // rectMatrix jest niejawnie typu int[,]
//        {
//            {0,1,2},
//            {3,4,5},
//            {6,7,8}
//        };
//        var jaggedMat = new int[][] // jaggedMat jest niejawnie typu int[][]
//        {
//            new int[] {0,1,2},
//            new int[] {3,4,5},
//            new int[] {6,7,8}
//        };
//        var vowels2 = new[] { 'a', 'e', 'i', 'o', 'u', 'y' }; // kompilator wydedukuje typ char[]
//        var nex = new[] { 1, 10000000000 }; // wszystkie elementy można przekonwertować na typ long
//    }
//}

//class ZmienneIparametry //metoda rekurencyjna, tzn. wywołująca samą siebie.
//{
//    static int Factorial(int x)     // stos
//    {
//        if (x == 0) return 1;
//        return x * Factorial(x - 1);
//    }
//    public string StringBuilder(string obiekt)
//    {
//        return obiekt;
//    }
//}
//class Wynik
//{ 
//    public static void Main()
//    {
//        StringBuilder ref1 = new StringBuilder("obiekt1");
//        Console.WriteLine(ref1);
//        // obiekt typu StringBuilder wskazywany przez zmienną ref1 można już przekazać
//        // do systemu usuwania nieużytków
//        StringBuilder ref2 = new StringBuilder("obiekt2");
//        StringBuilder ref3 = ref2;
//        // obiekt StringBuilder wskazywany przez zmienną ref2 jeszcze nie jest gotowy
//        // do przekazania systemowi usuwania nieużytków
//        Console.WriteLine(ref3); // obiekt2
//    }
//}
/* wartosci domyslne
 Typ          Wartość domyślna
typy referencyjne null
typy numeryczne i wyliczeniowe 0
Typ char         '\0'
Typ bool        false  */
//class Statement
//{
//    static void Foos(StringBuilder fooSB)
//    {
//        fooSB.Append("test");
//        fooSB = null;
//    }

//    public int Foo(int p)
//    {
//        p = p + 1; // zwiększa p o 1
//        Console.WriteLine(p); // drukuje p na ekranie
//        return p;
//    }
//}
//class Boo
//{
//    static void Main()
//    {
//        int x = 8;
//        Foo f1 = new Statement.Foo(x);
//        Foo(x); // tworzy kopię x

//        Console.WriteLine(x); // x nadal ma wartość 8
//        StringBuilder sb = new StringBuilder();
//        Foos(sb);
//        Console.WriteLine(sb.ToString()); // test
//    }
//}

//Modyfikator ref
/* int x = 8;
Foo (ref x); // niech Foo bezpośrednio zadziała na x
Console.WriteLine (x); // x ma teraz wartość 9
static void Foo (ref int p)
{
p = p + 1; // zwiększa p o 1
Console.WriteLine (p); // drukuje p na ekranie
}*/

//namespace Podrecznik
//{
//    class Modyfikator
//    {
//        static string Swap(ref string a, ref string b)
//        {
//            string temp = a;
//            a = b;
//            b = temp;
//        }
//    }
//    class Program
//    {
//        public static void Main()
//        {
//            string x = "Penn";
//            string y = "Teller";
//            Swamp s1 = new Modyfikator.Swamp(ref x, ref y);
//            Console.WriteLine(x); // Teller
//            Console.WriteLine(y); // Penn

//        }

//    }
//}

/*Modyfikator out do zwrócenia więcej niż jednej wartości przez metodę.

string a, b;
Split ("Stevie Ray Vaughn", out a, out b);
//albo  w jednej linijce:
Split ("Stevie Ray Vaughan", out string a, out string b);
//i potem juz:
Console.WriteLine (a); // Stevie Ray
Console.WriteLine (b); // Vaughn

void Split (string name, out string firstNames, out string lastName)
{
    int i = name.LastIndexOf (' ');
    firstNames = name.Substring (0, i);
    lastName = name.Substring (i + 1);
}
 out oraz  ref, są przekazywane przez referencję.*/

//Implikacje przekazywania przez referencj 

//class Test
//{
//    static int x;
//    static string X = "Stara wartość";
//    static ref string GetX() => ref X; // Ta metoda zwraca ref

//    static void Main() 

//    {
//        Instrukcje.ShowCard(13);
//        TellMeWhatICanDo(12);
//        Console.WriteLine(" : bo taki wiek");
//        ref string xRef = ref GetX(); // Przypisanie wyniku do lokalnej zmiennej ref
//        xRef = "Nowa wartość";
//        Console.Write("xref : ");
//        Console.WriteLine(X);
//        //ref int numRef = ref Numbers[2];
//        Bar(d: 3);
//        Foo(out x);
//        Fool(x: 1, y: 2); // 1, 2
//        int total = Sum(1, 2, 3, 4);
//        Console.Write($"suma:");
//        Console.WriteLine( total); // 10
//    }
//    static void TellMeWhatICanDo(int age)

//    {
//        Console.WriteLine("zabawa kartami");
//        if (age >= 35)
//            Console.WriteLine("Możesz być prezydentem!");
//        else if (age >= 21)
//            Console.WriteLine("Możesz pić alkohol w USA!");
//        else if (age >= 18)
//            Console.WriteLine("Możesz brać udział w wyborach!");
//        else
//            Console.WriteLine("Możesz jeszcze poczekać!");
//    }

//    static void Foo(out int y)
//    {
//        Console.WriteLine("{0} to x",  x); // x wynosi 0
//        y = 1; // modyfikacja y
//        Console.WriteLine("{0} to x", x); // x wynosi 1

//    }
//    public void Numbers()
//    {
//        int [] numbers = { 0, 1, 2, 3, 4 };

//    }
//    static void Bar(int a = 0, int b = 0, int c = 0, int d = 0) { Console.Write(" bar abcd =  "); Console.WriteLine(a + ": " + b + ": " + c + ": " + d); }
//    static void Fool(int x, int y) { Console.Write(x + ", " + y); Console.WriteLine(" fool x + y"); }
//    static int Sum(params int[] ints)
//    {
//        int sum = 0;
//        for (int i = 0; i < ints.Length; i++)
//            sum += ints[i]; // zwiększa sum o ints[i]
//        return sum;
//    }
//}

// if else switch continue
//class Instrukcje
//    /*• break (przeskok na koniec instrukcji switch);
//• goto case x (przeskok do innej klauzuli case);
//• goto default (przeskok do klauzuli default);
//• inna instrukcja skoku — return, throw, continue lub goto etykieta.*/
//{
//    public static void ShowCard(int cardNumber)
//    {
//        switch (cardNumber)
//        {
//            case 13:
//                Console.WriteLine("Król");
//                break;
//            case 12:
//                Console.WriteLine("Dama");
//                break;
//            case 11:
//                Console.WriteLine("Walet");
//                break;
//            case -1: 
//                goto case 12; 
//            default: // wykonania dla  pozostałych numerów 
//                Console.WriteLine(cardNumber);
//                break;
//        }
//        //albo cos takiego
//        switch (cardNumber)
//        {
//            case 13:
//            case 12:
//            case 11:
//            Console.WriteLine("Figura");
//                break;
//            default:
//            Console.WriteLine("Inna karta");
//                break;
//        }

//    }
//}

//class SwichType

//{
//    static void Main()
//    {
//        Console.WriteLine("typy\n");
//        TellMeTheType(12);
//        TellMeTheType("hello");
//        TellMeTheType(true);
//    }


//    public static void TellMeTheType(object x) // object zezwala na każdy typ
//    {
//        switch (x)
//        {
//            case int i:
//                Console.WriteLine("To jest liczba całkowita!");
//                Console.WriteLine($"Kwadrat {i} wynosi {i * i}");
//                break;
//            case string s:
//                Console.WriteLine("To jest łańcuch.");
//                Console.WriteLine($"Długość {s} wynosi {s.Length}");
//                break;
//            default:
//                Console.WriteLine("Nie wiem, czym jest x.");
//                break;
//        }
//        //albo
//        switch (x)
//        {
//            case bool b when b == true: // wykonuje kod tylko wtedy, gdy b jest prawdą
//                Console.WriteLine("Prawda!");
//                break;
//            case bool _:
//                Console.WriteLine("Fałsz!"); // docelowa wartosc bool to falsz
//                break;
//        }
//        switch (x)
//        {
//            case float f when f > 1000:
//            case double d when d > 1000:
//            case decimal m when m > 1000:
//                Console.WriteLine("W tym miejscu możemy odwoływać się do x, ale nie do f, d ani m");
//                break;
//        }
//        //Wyrażenia switch są zwięźlejsze odinstrukcji switch

//    }
//}

// inrstrukcje iteracyjne
//class Iteracje
//{
//    static void Main()
//    {
//        int ii = 0;
//        do
//        {
//            Console.WriteLine(ii);
//            ii++;
//        }
//        while (ii < 3);
//        //Pętla do-while różni się od while tylko tym, że wyrażenie testuje po wykonaniu bloku instrukcji
//        Console.WriteLine("inny przyklad");
//        int j = 0;
//        while (j < 3)
//        {
//            Console.Write(j);
//            j++;
//        }
//        Console.WriteLine("przyklad kolejny: ");
//        for (int wu = 0; wu < 3; wu++)
//        {
//            Console.WriteLine(wu);
//        }
//        Console.WriteLine("fibonacci");
//        for (int i = 0, prevFib = 1, curFib = 1; i < 10; i++)
//        {
//            Console.WriteLine(prevFib);
//            int newFib = prevFib + curFib;
//            prevFib = curFib; curFib = newFib;
//        }
//        //foreach
//        Console.WriteLine("napisze p i w o : ");
//        foreach (char c in "piwo\n") // c jest zmienną iteracyjną
//        {
//            Console.WriteLine(c);
//        }
//        //break
//        Console.WriteLine("break:\n");
//        int ygrek = 0;
//        while(true)
//        {
//            Console.WriteLine(ygrek);
//            if (ygrek++ > 5)

//                break;
//        }
//        //continue
//        Console.WriteLine("continue\n");
//        for (int iv = 0; iv < 10; iv++)
//        {
//            if ((iv % 2) == 0) 
//                continue; 
//            Console.Write(iv + " ");
//        }
//        // goto
//        Console.WriteLine("goto\n");
//        int iq = 1;
//        startLoop:
//        if (iq <= 5)
//        {
//            Console.Write(iq + " ");
//            iq++;
//            goto startLoop;
//        }
//        //return
//        decimal AsPercentage(decimal d)
//        {
//            decimal p = d * 100m;
//            return p; // zwraca wartość do metody wywołującej
//        }
//        Console.WriteLine(AsPercentage(3));

//        Console.WriteLine("Instrukcja throw");
//        //Instrukcja throw
//        /*if (w == null)
//        throw new ArgumentNullException*/
//}

//}


//Przestrzenie nazw 

namespace Outer
{
    namespace Middle
    {
        namespace Inner
        {
            class Klasa1 { }
            class Klasa2 { }
        }
    }
}
//to samo co cwyżej, krocej napisane
//namespace Outer.Middle.Inner
//{
//    class Klasa1 { }
//    class Klasa2 { }
//}

//gdy te same nazwy występują używamy identyfikatora by je rozróznić w wybrac odpowiednie
namespace Outer
{
    class Foo { }
    namespace Inner
    {
        class Foo { }
        class Test
        {
            Foo f1; // = Outer.Inner.Foo
            Outer.Foo f2; // = Outer.Foo
        }
    }
}

namespace N1
{
    class Class1 { }
}
namespace N2
{
    using N1;
    class Class2 : Class1 { } // Class1 jest tylko w N1 dostępne, jesli nie użyjemy 'using' nie dobierzemy sie do niej
}
namespace N2
{
    class Class3 : Class1 { } // błąd kompilacji
}

//Do kwalifikacji przestrzeni nazw służą znaki ::.
//extern alias W1;
//extern alias W2;
//class Test
//W1::Widgets.Widget w1 = new W1::Widgets.Widget();
//W2::Widgets.Widget w2 = new W2::Widgets.Widget();