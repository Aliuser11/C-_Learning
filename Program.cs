using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * wykaz wybranych modyfikatorów typów dla literałów:
f F  x = 34.5f float
d D 3d = 3.0 double
m M 3m decimal
l L 12345L long
*/
namespace Trial_projects
{
    internal class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Hello, World!");
            int x, y = 3, z;
            x = 5;
            z = x;
            int c = new int(); //Dla typu int wartością domyślną jest 0
                               // Dla typów referencyjnych wartością domyślną jest  null
            Console.WriteLine(x);
            Console.WriteLine(z);
            Console.WriteLine(c);

            int a, b, wynik;
            a = 10;
            b = 11;
            wynik = 2 * a - 3 * b;
            Console.WriteLine("wynik:");
            Console.WriteLine(wynik);
            Console.ReadKey();
        }

        static void temperature (string[] args)
        {
            // temperatura
            double F, C;
            Console.WriteLine("Podaj temperatrure");
            F = double.Parse(Console.ReadLine()); //metody double.Parse(), która zamieni typ string na typ double
            C = 5.0 / 9 * (F - 32);
            Console.WriteLine(C);

            //przyklad uzycia rzutowania
            const int komputery = 24;
            int studenci;
            double wyniki;
            Console.WriteLine("Podaj liczbe studentow: ");
            studenci = Convert.ToInt32(Console.ReadLine()); //albo int.Parse()
            wyniki = (double)studenci / komputery; // rzutowanie
            Console.WriteLine(wyniki);
            Console.ReadKey();
        }
        static void temperate(string[] args)
        {
            //obl wyrazenie matematyczne:
            double aa, bb;
            Console.WriteLine("podaj aa wieksze od 0:");
            aa = Convert.ToDouble(Console.ReadLine());
            bb = Math.Sqrt(Math.Abs(Math.Sin(aa)) * Math.Log(aa, 2.0));
            Console.WriteLine(bb);

            //Operatory inkrementacji oraz dekrementacji
            int t = 0, o, ot;
            ot = ++t * 2; // t = 1
            o = t++ * 2;
            // ++ zwieksza o 1| -- zmniejsza
            /*jeśli operator jest przed
            zmienną, to zmienna ta będzie zwiększona (lub zmniejszona) przed jej użyciem w wyrażeniu.
            Jeśli zaś operator jest po zmiennej, to zmienna ta będzie zwiększona (lub zmniejszona) po jej
            odczytaniu w wyrażeniu.*/

            Console.WriteLine(t);
            Console.WriteLine(o);
            Console.WriteLine(ot);

            int xx, yy = 4;
            xx = (yy += 3); // xx = 7
            xx = ++yy; // 8
            xx = yy--; // 7
            Console.WriteLine(xx);
            Console.WriteLine(yy);
            Console.ReadKey();
        }
        static void koniunkcja(string[] args)
        {
            // koniunkcja warunkowa „&&” oraz koniunkcja „&” (bezwarunkowa)
            double wiek, PLN;
            bool kino;
            Console.WriteLine("Podaj wiek: ");
            wiek = double.Parse(Console.ReadLine());
            Console.WriteLine("Ile masz pieniędzy: ");
            PLN = double.Parse(Console.ReadLine());
            kino = (wiek >= 18 && PLN >= 20); // zwraca True albo False
            Console.WriteLine(kino);

            //Złożone wyrażenia logiczne
            int q = 1, w = 2, r = 3;
            bool wyniku;
            wyniku = ((q == 1 || w != 5) && r < 1);
            Console.WriteLine(wyniku);
            Console.ReadKey();
        }
        static void operacje_tekst(string[] args)
        {

            //operacje na tekstach, znak ispecjalne
            string tekst;
            Console.WriteLine("Podaj imię");
            tekst = Console.ReadLine();
            tekst = "Cześć " + tekst;
            Console.WriteLine(tekst);
            Console.WriteLine(tekst.Length); // zwroci liczbę znaków

            Console.WriteLine("Linia1\nLinia2"); // \nnowej linii
            Console.WriteLine("Wzrost 170\tWaga 65"); // \t - tabulacja wciecie
            Console.WriteLine(@"Wzrost 170\tWaga 65"); // @ - dosłowna interpretacja
            Console.WriteLine("C:\\Windows\\Temp"); // podwójny "\\" wstawia "\"
            Console.WriteLine("Tytuł filmu: \"Rój\""); // znak \" wstawia znak "

            //{index zmiennej podany}
            int suma = 10;
            double xxx = 12.345678, yyy = 24.56, wskaznik = 0.45;
            string imie = "Ala", naz = "Nowak";
            Console.WriteLine("1. Imię: {0,15} Nazwisko: {1,20}", imie, naz);
            Console.WriteLine("2. Imię: {0,-15} Nazwisko: {1,-20}", imie, naz);
            Console.WriteLine("3. Wartość {0, 10} to suma", suma);
            Console.WriteLine("4. Wartość {0,-10} to suma", suma);
            Console.WriteLine("5. Wskaźnik: {0,8:P}", wskaznik); // P to %
            Console.WriteLine("6. Waga: {0,10} kg", xxx);
            Console.WriteLine("7. {0,-10:F4} (4 cyfry po przecinku)", xxx);
            Console.WriteLine("8. Wartość xxx={0,-10:F4} yyy={1,-10:F2}", xxx, yyy);
            Console.WriteLine("9. A ta liczba będzie w klamrach {{{0}}}", yyy); // potrójna klamra
            Console.ReadKey();
        }

        //            //zadania do samodzielnego rozwiązania 2.7

        static void zad_temp(string[] args)
        {
//            /*
//            program przeliczający temperaturę w stopniach Celsjusza na temperaturę w  stopniach Fahrenheita. 
//            Program ma prosić użytkownika o podanie temperatury w stopniach Celsjusza. Wzór: F = 32 + (9/5)*C
            double F, C;
            Console.WriteLine("Podaj temperatrure w C: ");
            C = double.Parse(Console.ReadLine()); //metody double.Parse(), która zamieni typ string na typ double
            F = 32 + (9.0 / 5.0) * C;
            Console.WriteLine("{0} w celsjuszach to w farenheitach : ", C);
            Console.WriteLine(F);
            Console.ReadKey();
        }
        //static void rownanie_kwadratowe(string[] args)
        //{
            //             */
            //            /*Napisz program, który oblicza deltę dla równania kwadratowego ax^2 + bx + c = 0.
            //            Program ma prosić użytkownika o podanie współczynników równania a, b oraz c.
            //            wzor delta = b^2 - 4 ac */
            //int a, b, c, delta, p = 2;
            //Console.WriteLine("Podaj a");
            //a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Podaj b");
            //b = int.Parse(Console.ReadLine());
            //Console.WriteLine("Podaj c");
            //c = int.Parse(Console.ReadLine());
            //potega = Console.WriteLine($"{b}^{p} = {(long)Math.Pow(b, p):N0} (0x{(long)Math.Pow(value, power):X})");
            //delta = potega - (4 * a * c)
            //Console.WriteLine(delta);
            //Console.WriteLine("delta wychodzi z rownania {1} ^ 2 - 4 * {0} * {2}", a, b, c);
            //Console.ReadKey();
        //}
        static void wskaznik (string[] args)
        {
                //            /* oblicz wskaznik BMI = masa/wzrost kg/m */
            int masa, wzrost, wynik;
            Console.WriteLine("Podaj wzrost (m): ");
            masa = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wage (kg): ");
            wzrost = int.Parse(Console.ReadLine());
            wynik = masa / wzrost;
            Console.WriteLine(wynik);
            Console.ReadKey();
        }
        //static void gestosc(string[] args)
        //{
        ////Po wykonaniu przedstawionego niżej kodu programu zmienna gestoscZaludnienia
        ////przyjmie wartość 0.Odpowiedz dlaczego i zmień program(w linii, gdzie jest obliczana
        ////zmienna gestoscZaludnienia) tak, aby wartość tej zmiennej wynosiła 0,1(czyli 10 / 100)
        //    double powierzchnia, osoby;
        //    decimal powierzchnia = 100.0M;
        //    osoby = 10.0M;
        //    double gestoscZaludnienia =   osoby / powierzchnia;
        //    Console.WriteLine("gestosc zaludnienia:");
        //    Console.WriteLine(gestoscZaludnienia);
        //    Console.ReadKey();
        //}
        static void przyklad(string[] args)
        {
            //iny przykład:
            double a = 1.0;
            double b = 3.0;
            Console.WriteLine(a / b);

            decimal c = 1.0M;
            decimal d = 3.0M;
            Console.WriteLine(c / d);


            //            // 2.4 - 2.10
            int u = 100;
            Console.WriteLine(++u * 2); // wynik 202
            int mu = 2, yc = 3;
            mu *= yc * 2; // mu = 12
            Console.WriteLine(mu);

            int my, ix = 4;
            my = (ix -= 2);// my = 2
            my = ix++; // my = 5
            my = ix--; //my = 3
            Console.WriteLine(my);

            int a4, a5 = 5;
            a4 = ++a5 * 2; //12
            a4 = a5++; //6
            a4 = a5--; //4
            Console.WriteLine(++a5); //7

            bool p;
            int py = 1, zy = 1;
            p = (py == 1 && zy++ == 1);
            Console.WriteLine(p);

            // a
            int x = 1, y = 4, z = 2;
            bool wynik = (x++ > 1 && y++ == 4 && z-- > 0); //po pierwszym false nie sprawdza kolejnych 
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
            Console.ReadKey();
        }


        static void przyklad_b(string[] args)
        {
            int x = 1, y = 4, z = 2;
            bool wynik = (x++ > 1 & y++ == 4 && z-- > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z); //False x=2; y=5;z=2 po kolei az blad
            Console.ReadKey();
        }
        static void przyklad_c(string[] args)
        {
            int x = 1, y = 4, z = 2;
            bool wynik = (x++ > 1 & y++ == 4 & z-- > 0);// x = 2;y = 5;z=1 false kazde osobno bo &
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
            Console.ReadKey();
        }
        static void przyklad_d(string[] args)
        {
            int x = 1, y = 3, z = 4;
            bool wynik = (x == 1 || y++ > 2 || ++z > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z); // true nie zmienia y i z 
            Console.ReadKey();
        }
        static void przyklad_e(string[] args)
        { 
            int x = 1, y = 3, z = 4;
            bool wynik = (x == 1 | y++ > 2 || ++z > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z); //true zmienia y=4
            Console.ReadKey();
        }

        static void przyklad_f(string[] args )
        { 
            int x = 1, y = 3, z = 4;
            bool wynik = (x == 1 | y++ > 2 | ++z > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z); //true zmienia y i z bo |
            Console.ReadKey();

//rozdział 3 str57 
}

}
}
