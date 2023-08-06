//using Microsoft.Win32;
//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Schema;

//f F  x = 34.5f float
//d D 3d = 3.0 double
//m M 3m decimal
//l L 12345L long */

//Console.WriteLine("Hello, World!");
//int x, y = 3, z;
//x = 5;
//z = x;
//int c = new int(); //Dla typu int wartością domyślną jest 0
//                   // Dla typów referencyjnych wartością domyślną jest  null
//Console.WriteLine("x,y,z");
//Console.WriteLine("x:{0}", x);
//Console.WriteLine("z:{0}", z);
//Console.WriteLine("c:{0}", c);
//Console.ReadKey();

//int a, b, wynik;
//a = 10;
//b = 11;
//wynik = 2 * a - 3 * b;
//Console.WriteLine("operacja matematyczna");
//Console.WriteLine("wynik:");
//Console.WriteLine(wynik);
//Console.ReadKey();

//double F, C;
//Console.WriteLine("obl. temperature");
//Console.WriteLine("Podaj temperatrure");
//F = double.Parse(Console.ReadLine()); //metody double.Parse(), która zamieni typ string na typ double
//C = 5.0 / 9 * (F - 32);
//Console.WriteLine(C);
//Console.ReadKey();


////przyklad uzycia rzutowania
//const int komputery = 24;
//int studenci;
//double wyniki;
//Console.WriteLine("przyklad uzycia rzutowania");
//Console.WriteLine("Podaj liczbe studentow: ");
//studenci = Convert.ToInt32(Console.ReadLine()); //albo int.Parse()
//Console.WriteLine("stosunek liczby studentow do dostepnych komputerow");
//wyniki = (double)studenci / komputery; // rzutowanie
//Console.WriteLine(wyniki);
//Console.ReadKey();

////obl wyrazenie matematyczne:
//double aa, bb;
//Console.WriteLine("podaj aa wieksze od 0:");
//aa = Convert.ToDouble(Console.ReadLine());
//bb = Math.Sqrt(Math.Abs(Math.Sin(aa)) * Math.Log(aa, 2.0));
//Console.WriteLine("obl wyrazenie matematyczne\n");
//Console.WriteLine(bb);
//Console.ReadKey();

////Operatory inkrementacji oraz dekrementacji
//int t = 0, o, ot;
//ot = ++t * 2; // t = 1
//o = t++ * 2;
//// ++ zwieksza o 1| -- zmniejsza
//zmienną, to zmienna ta będzie zwiększona (lub zmniejszona) przed jej użyciem w wyrażeniu.
//Jeśli zaś operator jest po zmiennej, to zmienna ta będzie zwiększona (lub zmniejszona) po jej
//odczytaniu w wyrażeniu.*/
//Console.WriteLine("Operatory inkrementacji oraz dekrementacji");
//Console.WriteLine(t);
//Console.WriteLine(o);
//Console.WriteLine(ot);
//Console.ReadKey();

//int xx, yy = 4;
//xx = (yy += 3); // xx = 7
//xx = ++yy; // 8
//xx = yy--; // 7
//Console.WriteLine(xx);
//Console.WriteLine(yy);
//Console.ReadKey();

//// koniunkcja warunkowa „&&” oraz koniunkcja „&” (bezwarunkowa)
//double wiek, PLN;
//bool kino;
//Console.WriteLine("Koniunkcja && i &");
//Console.WriteLine("Podaj wiek: ");
//wiek = double.Parse(Console.ReadLine());
//Console.WriteLine("Ile masz pieniędzy: ");
//PLN = double.Parse(Console.ReadLine());
//kino = (wiek >= 18 && PLN >= 20); // zwraca True albo False
//Console.WriteLine(kino);
//Console.ReadKey();

////Złożone wyrażenia logiczne
//int q = 1, w = 2, r = 3;
//bool wyniku;
//Console.WriteLine("Złożone wyrażenia logiczne");
//wyniku = ((q == 1 || w != 5) && r < 1);
//Console.WriteLine(wyniku);
//Console.ReadKey();

////operacje na tekstach, znak ispecjalne
//string tekst;
//Console.WriteLine("Podaj imię");
//tekst = Console.ReadLine();
//tekst = "Cześć " + tekst;
//Console.WriteLine(tekst);
//Console.WriteLine(tekst.Length); // zwroci liczbę znaków
//Console.WriteLine("Linia1\nLinia2"); // \nnowej linii
//Console.WriteLine("Wzrost 170\tWaga 65"); // \t - tabulacja wciecie
//Console.WriteLine(@"Wzrost 170\tWaga 65"); // @ - dosłowna interpretacja
//Console.WriteLine("C:\\Windows\\Temp"); // podwójny "\\" wstawia "\"
//Console.WriteLine("Tytuł filmu: \"Rój\""); // znak \" wstawia znak "
//Console.ReadKey();

////{index zmiennej podany}
//int suma = 10;
//double xxx = 12.345678, yyy = 24.56, wskaznik = 0.45;
//string imie = "Ala", naz = "Nowak";
//Console.WriteLine("1. Imię: {0,15} Nazwisko: {1,20}", imie, naz);
//Console.WriteLine("2. Imię: {0,-15} Nazwisko: {1,-20}", imie, naz);
//Console.WriteLine("3. Wartość {0, 10} to suma", suma);
//Console.WriteLine("4. Wartość {0,-10} to suma", suma);
//Console.WriteLine("5. Wskaźnik: {0,8:P}", wskaznik); // P to %
//Console.WriteLine("6. Waga: {0,10} kg", xxx);
//Console.WriteLine("7. {0,-10:F4} (4 cyfry po przecinku)", xxx);
//Console.WriteLine("8. Wartość xxx={0,-10:F4} yyy={1,-10:F2}", xxx, yyy);
//Console.WriteLine("9. A ta liczba będzie w klamrach {{{0}}}", yyy); // potrójna klamra
//Console.ReadKey();

////zadania
//Program ma prosić użytkownika o podanie temperatury w stopniach Celsjusza. Wzór: F = 32 + (9/5)*C*/
//Console.WriteLine("Podaj temperatrure w C: ");
//C = double.Parse(Console.ReadLine()); //metody double.Parse(), która zamieni typ string na typ double
//F = 32 + (9.0 / 5.0) * C;
//Console.WriteLine("{0} w celsjuszach to w farenheitach : ", C);
//Console.WriteLine(F);
//Console.ReadKey();

/////*Napisz program, który oblicza deltę dla równania kwadratowego ax^2 + bx + c = 0.
////Program ma prosić użytkownika o podanie współczynników równania a, b oraz c.
////wzor delta = b^2 - 4 ac */

//int delta, p = 2;
//Console.WriteLine("Podaj a");
//a = int.Parse(Console.ReadLine());
//Console.WriteLine("Podaj b");
//b = int.Parse(Console.ReadLine());
//Console.WriteLine("Podaj c");
//c = int.Parse(Console.ReadLine());
//double potega = Math.Pow(b, p);
//delta = (int)((double)potega - (4 * a * c));
//Console.WriteLine(delta);
//Console.WriteLine("delta wychodzi z rownania {1} ^ 2 - 4 * {0} * {2}", a, b, c);
//Console.ReadKey();


//decimal masa, wzrost;
//Console.WriteLine("Podaj wzrost (m): ");
//wzrost = decimal.Parse(Console.ReadLine());
//Console.WriteLine("Podaj wage (kg): ");
//masa = decimal.Parse(Console.ReadLine());
//wynik = (int)(masa / (decimal)Math.Pow((double)wzrost, 2));
//Console.WriteLine(wynik);
//Console.ReadKey();


//przyjmie wartość 0.Odpowiedz dlaczego i zmień program(w linii, gdzie jest obliczana
//zmienna gestoscZaludnienia) tak, aby wartość tej zmiennej wynosiła 0,1(czyli 10 / 100)*/
//double osoby;
//decimal powierzchnia = 100.0M;
//osoby = (double)10.0M;
//Console.WriteLine("gestosc zaludnienia:");
//double gestoscZaludnienia = osoby / (double)powierzchnia;
//Console.WriteLine(gestoscZaludnienia);
//Console.ReadKey();


////inny przykład:
//a = (int)1.0;
//b = (int)3.0;
//c = (int)1.0;
//Console.WriteLine(a / b);
//decimal d = 3.0M;
//Console.WriteLine(c / d);
//Console.ReadKey();

//// 2.4 - 2.10
//int u = 100;
//Console.WriteLine(++u * 2); // wynik 202
//int mu = 2, yc = 3;
//mu *= yc * 2; // mu = 12
//Console.WriteLine(mu);
//Console.ReadKey();

//int my, ix = 4;
//my = (ix -= 2);// my = 2
//my = ix++; // my = 5
//my = ix--; //my = 3
//Console.WriteLine(my);
//Console.ReadKey();

//int a4, a5 = 5;
//a4 = ++a5 * 2; //12
//a4 = a5++; //6
//a4 = a5--; //4
//Console.WriteLine(++a5); //7
//Console.ReadKey();

////double py = 1, zy = 1;
////p = py == (double)1.0 && zy++ == 1.0;
////Console.WriteLine(value: p);
////Console.ReadKey();

//// a
////int x = 1, y = 4, z = 2;
////bool wynik = (x++ > 1 && y++ == 4 && z-- > 0); //po pierwszym false nie sprawdza kolejnych 
////Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
////Console.ReadKey();

////int x = 1, y = 4, z = 2;
////bool wynik = (x++ > 1 & y++ == 4 && z-- > 0);
////Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z); //False x=2; y=5;z=2 po kolei az blad
////Console.ReadKey();

////int x = 1, y = 4, z = 2;
////bool wynik = (x++ > 1 & y++ == 4 & z-- > 0);// x = 2;y = 5;z=1 false kazde osobno bo &
////Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
////Console.ReadKey();

////int x = 1, y = 3, z = 4;
////bool wynik = (x == 1 || y++ > 2 || ++z > 0);
////Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z); // true nie zmienia y i z 
////Console.ReadKey();

////int x = 1, y = 3, z = 4;
////bool wynik = (x == 1 | y++ > 2 || ++z > 0);
////Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z); //true zmienia y=4
////Console.ReadKey();

////int x = 1, y = 3, z = 4;
////bool wynik = (x == 1 | y++ > 2 | ++z > 0);
////Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z); //true zmienia y i z bo |
////Console.ReadKey();

//////R3.Sterowanie działaniem programu 57 - 90

//z = 3;
//Console.WriteLine("podaj a :\n");
//a = int.Parse(Console.ReadLine());
//Console.WriteLine("podaj b :\n");
//b = int.Parse(Console.ReadLine());
//if (a < b)
//{
//    Console.WriteLine("{0} jest mniejsze od  {1}\t", a, b);
//}
//else
//{
//    Console.WriteLine("{0} nie jest mniejsze od  {1}\t", a, b);
//}
//if (a == b)
//{
//    Console.WriteLine("{0} jest takie jak {1}\t", a, b);
//}
//if ((a == 1) || (a == -1))
//{
//    Console.WriteLine("wartosc bezwzgledna to 1 \n");
//}
//else
//{
//    Console.WriteLine("wartosc bezwzgledna jest rozna od 1 \n");
//}
//if (a == 1 || b != 5 && z < 1)
//{
//    Console.WriteLine("warunek spelniony \n"); // warunek spełniony
//    /*Ponieważ operator koniunkcji && ma wyższy priorytet niż operator alternatywy ||, to wyrażenie to będzie wartościowane zgodnie z zapisem:
//        * x == 1 || (y != 5 && z < 1)*/
//}
//else
//{
//    Console.WriteLine("warunek NIE JEST spelniony \n");
//}
//Console.ReadKey();


//Console.WriteLine("Podaj imie\n");
//imie = Console.ReadLine();
//Console.WriteLine("Podaj nazwisko\n");
//naz = Console.ReadLine();
//if (imie.Length + naz.Length < 30)
//{
//    tekst = imie + " " + naz;
//    Console.WriteLine(tekst);
//}
//else
//{
//    Console.WriteLine("Imię i nazwisko jest za dlugie!");
//}
//Console.ReadKey();

////zagniezdzenie funkcji warunkowych
//double przychod, koszty;
//Console.WriteLine("przychod \n ");
//przychod = double.Parse(Console.ReadLine());
//Console.WriteLine("koszty \n ");
//koszty = double.Parse(Console.ReadLine());
//double dochod = przychod - koszty;
//if (dochod == 0)
//{
//    Console.WriteLine("Mamy zerowy dochod\n");
//}
//else
//{
//    if (dochod > 0)
//        Console.WriteLine("Mamy zysk\n");
//    else
//        Console.WriteLine("Mamy strate\n");
//}
//if (dochod != 0)
//{
//    if (dochod > 0)
//        Console.WriteLine("Zysk");
//    else
//        Console.WriteLine("Strata");
//}
//else
//{
//    Console.WriteLine("zerowy dochow");
//}
//Console.ReadKey();


////wielowarunkowy wariant instrukcji if | else
//Console.WriteLine("Wpisz nr dnia tygodnia\n");
//string nr_dnia = Console.ReadLine();
//if (nr_dnia == "1")
//    Console.WriteLine("Poniedziałek");
//else if (nr_dnia == "2")
//    Console.WriteLine("Wtorek");
//else if (nr_dnia == "3")
//    Console.WriteLine("Środa");
//else if (nr_dnia == "4")
//    Console.WriteLine("Czwartek");
//else if (nr_dnia == "5")
//    Console.WriteLine("Piątek");
//else if (nr_dnia == "6")
//    Console.WriteLine("Sobota");
//else if (nr_dnia == "7")
//    Console.WriteLine("Niedziela");
//else
//    Console.WriteLine("Nie ma takiego dnia tygodnia\n");
//Console.ReadKey();

//x = 1;
//y = (x > 0) ? ++x : --x; // jesli wyrazenie zostanie spelnione po znaku ? zostanie wykonane to po lewej, jesli nie, to co po : dwukropku
//Console.WriteLine(y);
//Console.ReadKey();

//// to samo tylko rozpisane:
//x = 1;
//if (x > 0)
//{
//    y = ++x;
//}
//else
//{
//    y = --x;
//}
//Console.WriteLine(y);
//Console.ReadKey();


////switch.case
//Console.WriteLine("Podaj liczbę z zakresu 0-2\n");
//int liczba = int.Parse(Console.ReadLine());
//switch (liczba)
//{
//    case 0:
//        Console.WriteLine("zero");
//        break;

//    case 1:
//        Console.WriteLine("jeden");
//        break;

//    case 2:
//        Console.WriteLine("dwa");
//        break;

//    default: // gdy nic innego nie pyknelo 
//        Console.WriteLine("Nieznana wartość");
//        break;
//}
//Console.ReadKey();

//double cena = 0.5;
//Console.WriteLine("Podaj porcję (S / M / L)\n");
//string porcja = Console.ReadLine();
//switch (porcja) // zmienna bool, char, string, int, enum.
//{
//    case "S":
//        cena += 4.5;
//        break;

//    case "M":
//        cena += 2.0;
//        goto case "S"; // o tyle wieksza od ceny S a nie od zadeklarowanej ceny 

//    case "L":
//        cena += 3.0;
//        goto case "S";

//    default: //opcjonalne
//        Console.WriteLine("Podano zły symbol\n");
//        break;
//}
//Console.WriteLine(cena);
//Console.ReadKey();

////petla
//for (int i = 1; i < 10; i += 1)
//{
//    Console.WriteLine(i);
//}
//for (int i = 10; i > 0; i -= 2)
//{
//    Console.WriteLine(i);
//}
//Console.ReadKey();


//for (int i = 1; i <= 5; i += 1)
//    for (int j = 1; j <= 5; j += 1)
//        Console.WriteLine("i = {0}, j = {1}", i, j);
//Console.ReadKey();

//for (int i = 1; i <= 5; i += 1)
//{
//    for (int j = 1; j <= 5; j += 1)
//        Console.WriteLine(j);
//    Console.WriteLine();
//}
//Console.ReadKey();

//for (int i = 0; i < 10;)
//{
//    Console.WriteLine(i);
//    i += 1;
//}

//int jj = 0;
//for (; jj < 10; jj += 1)
//{
//    Console.WriteLine(jj);
//}
//Console.ReadKey();


//decimal bbb = 0.1m;
//for (; bbb <= 1; bbb += 0.1m)
//{
//    Console.WriteLine(bbb);
//}
//Console.ReadKey();

//for (a = 0, b = -10, c = 1; a > (b + c); a--, b++, c++)
//{
//    Console.WriteLine(" a = {0} b = {1} c = {2}", a, b, c);
//}
//Console.ReadKey();

////petla WHILE

//int iu = 0;
//while (iu < 10)
//{
//    Console.WriteLine(iu);
//    iu += 1;
//}
//Console.ReadKey();

////petla WHILE i czas
//Console.WriteLine("Czas: {0}", DateTime.Now);
//Console.WriteLine("Ponownie pokazać aktualny czas? (t/n)");
//string odpowiedz = Console.ReadLine();
//while (odpowiedz != "n") // nie ma srednika  bo petla rusza !!!
//{
//    Console.WriteLine("Czas: {0}", DateTime.Now);
//    Console.WriteLine("Ponownie pokazać aktualny czas? (t/n)");
//    odpowiedz = Console.ReadLine();
//}
//Console.ReadKey();

/////* w pętli while warunek logiczny sprawdzany jest przed pierwszym
////wykonaniem pętli, a w do..while warunek logiczny testowany jest po pierwszym wykonaniu
////pętli*/

////do while sprawdza po pierwszej petli
//do
//{
//    Console.WriteLine("Czas: {0}", DateTime.Now);
//    Console.WriteLine("Ponownie pokazać aktualny czas? (t/n)");
//    odpowiedz = Console.ReadLine();
//} while (odpowiedz != "n"); // jest srednik, bo to ostatnie wyrazenie logiczne i element petli !!!
//Console.ReadKey();


////3 petle ten sam przyklad
//Console.WriteLine("Podaj dodatni wykładnik");
//int wykladnik = Convert.ToInt16(Console.ReadLine());
////petla FOR

//if (wykladnik > 0)
//{
//    potega = 1;
//    for (int i = 1; i <= wykladnik; i++)
//    {
//        potega = potega * 2;
//        Console.WriteLine("2 do {0,2} = {1,2}", i, potega);
//    }
//}
//Console.ReadKey();

////petla WHILE
//if (wykladnik > 0)
//{
//    potega = 1;
//    int i = 1;
//    while (i <= wykladnik)
//    {
//        potega = potega * 2;
//        Console.WriteLine("2 do {0,2} = {1,2}", i, potega);
//        i++;
//    }
//    Console.ReadKey();

//    //petla DO WHILE

//    i = 1;
//    do
//    {
//        potega = potega * 2;
//        Console.WriteLine("2 do {0,2} = {1,2}", i, potega);
//        i++;
//    }
//    while (i <= wykladnik);
//}
//Console.ReadKey();

////Polecenia break i continue

//    a = 0;
//    do
//    {
//        a++;
//        if (a == 5)
//            break; // przerwij pętle
//        Console.WriteLine(a);
//    } while (true);

//    for (int i = 1; i <= 3; i++)
//    {
//        Console.WriteLine("Liczby w {0} wierszu:", i);
//        for (int j = 1; j <= 5; j++)
//        {
//            if (j == 3) break;
//            Console.Write(j + ",");
//        }
//        Console.WriteLine();
//    }
//    Console.ReadKey();


////to co wyżej ale zamiast break jest contine

//for (int i = 1; i <= 3; i++)
//{
//    Console.WriteLine("Liczby w {0} wierszu:", i);
//    for (int j = 1; j <= 5; j++)
//    {
//        if (j == 3) break;
//        Console.Write(j + ",");
//    }
//    Console.WriteLine();
//}
//Console.ReadKey();

//for (int i = 1; i <= 6; i++)
//{
//    if (i == 4)
//        continue; // pomin dalsze instrukcje (nie drukuje 4) i wznow petle
//    Console.WriteLine(i);
//}
//Console.ReadKey();

//// PETLA FOR EACH->w rozdziale 4.dotyczy bowiem tablic

////3.a program do sprawdzania czy liczba jest parzysta czy ujemna
//Console.WriteLine("podaj liczbe calkowita\n");
//liczba = int.Parse(Console.ReadLine());
//if (liczba % 2 == 0) //sprawdza czy jest parzysta
//{
//    Console.WriteLine("{0} jest liczba parzysta", liczba);
//}
//else
//{
//    Console.WriteLine("{0} jest nieparzysta", liczba);
//}
//if (liczba < 0)
//{
//    Console.WriteLine("{0} jest uqjemna", liczba);
//}
//else
//{
//    Console.WriteLine("{0} nie jest liczba ujemna", liczba);
//}
//Console.ReadKey();


////3.b pobierz 2 liczby calkowite. znajdz i podaj parzyste liczby pomiedzy nimi
//Console.WriteLine("podaj 1 liczbą calkowita\n");
//x = int.Parse(Console.ReadLine());
//Console.WriteLine("podaj 2 liczbą calkowita\n");
//y = int.Parse(Console.ReadLine());
//Console.WriteLine("liczby parzyste");
//if (x <= y)
//{
//    for (int i = x; i <= y; i++)
//    {
//        if (i % 2 == 0)
//        {
//            Console.WriteLine(i + ",");
//        }
//    }
//}
//Console.ReadKey();

////3.b inne podejscie
//Console.WriteLine("podaj 1 liczbą calkowita\n");
//x = int.Parse(Console.ReadLine());
//Console.WriteLine("podaj 2 liczbą calkowita\n");
//y = int.Parse(Console.ReadLine());
//x = (x % 2 == 0) ? x : x + 1;
//y = (y % 2 == 0) ? y : y - 1;
//for (int i = x; i <= y; i += 2)
//{
//    Console.Write(i + ",");
//}
//Console.ReadKey();


//// 3c.
//nich codziennie będzie odkładał na spłatę zadłużenia 20 % swojego dziennego zarobku, Jane
//zarabia dziennie 50 zł, a Karol 40 zł.Napisz program, który przy pomocy pętli do .while
//sprawdzi po ilu dniach obaj koledzy uzbierają kwotę potrzebną do spłaty swojego długu oraz wypisze
//wartość uzbieranej kwoty w każdym dniu*/

//int iii = 1;
//double dlug = 80, zarobekJanka = 50, zarobekKarola = 40;
//double splata = 0;
//do
//{
//    splata += 0.2 * zarobekJanka + 0.2 * zarobekKarola;
//    Console.WriteLine("Dzień = {0} Spłata = {1}", iii++, splata);
//} 
//while (dlug > splata);
//Console.ReadKey();


////3.4 Napisz program, który wyświetla na ekranie konsoli „kwadrat” zbudowany ze znaku „*”. Liczbę wierszy(a tym samym kolumn) ma podać użytkownik.

////Console.WriteLine("podaj liczbę wierszy");
////int i = int.Parse(Console.ReadLine());
////for (int n = 1; n <= i; n++)
////{
////    for (int j = 1; j <= i; j++)
////    {
////        Console.Write("*"); // w Console.Write ! !
////    }
////    Console.WriteLine();
////}
////Console.ReadKey();

//// 3.1. czy rok byl przestepny
////int roki;
////Console.WriteLine("podaj rok do sprawdzenia ");
////roki = int.Parse(Console.ReadLine());
////if (rok % 4 == 0 || rok % 400 == 0)
////{
////    Console.WriteLine("{0} jest przestepnym rokiem", rok);
////}
////else
////{
////    Console.WriteLine("{0} NIE jest przestepnym rokiem", rok);
////}
////Console.ReadKey();


//// 3.2 2 liczby sprawdz czy druga jest dzielnikiem pierwszej

//Console.WriteLine("podaj liczbe  do sprawdzenia ");
//int l1 = int.Parse(Console.ReadLine());
//Console.WriteLine("podaj dzielnik do sprawdzenia ");
//int l2 = int.Parse(Console.ReadLine());
//if (l1 % l2 == 0)

//{
//    Console.WriteLine("{1} jest dzielnikiem {0}", l1, l2);
//}
//else
//{
//    Console.WriteLine("{1} NIE jest dzielnikiem {0}", l1, l2);
//}
//Console.ReadKey();


////3.3 podaj 3 liczby i wyswietl najwieksza

//Console.WriteLine("podaj liczbe  do sprawdzenia ");
//l1 = int.Parse(Console.ReadLine());
//Console.WriteLine("podaj liczbe do sprawdzenia ");
//l2 = int.Parse(Console.ReadLine());
//Console.WriteLine("podaj liczbe do sprawdzenia ");
//int l3 = int.Parse(Console.ReadLine());

//if (l1 > l2 && l2 > l3)

//{
//    Console.WriteLine(" {0} najwieksza", l1);
//}
//if (l2 > l1 && l2 > l3)
//{
//    Console.WriteLine("{1} najwieksza", l2);
//}
//if (l3 > l1 && l3 > l2)
//{
//    Console.WriteLine("{2}", l3);
//}
//if (l1 == l2 && l1 == l3)
//{
//    Console.WriteLine("rowne");
//}
//else
//{
//    Console.WriteLine(" blad");
//}
//Console.ReadKey();

////3.4
//Console.WriteLine("liczba");
//a = (int)double.Parse(Console.ReadLine());
//Console.WriteLine("liczba");
//b = (int)double.Parse(Console.ReadLine());
//Console.WriteLine("dzialanie");
//string dzialanie = Console.ReadLine();

//if (dzialanie == "*")
//{
//    wynik = a * b;
//    Console.WriteLine("{0}{2}(1} = {3}", a, b, dzialanie, wynik);
//}
//if (dzialanie == "+")
//{
//    wynik = a + b;
//    Console.WriteLine("{0}{2}(1} = {3}", a, b, dzialanie, wynik);
//}
//else
//{
//    Console.WriteLine("blad");
//}
//Console.ReadKey();


//* BMI
// < 18,5 – niedowaga,
// 18,5–24,99 – wartość prawidłowa,
// ≥ 25,0 – nadwaga*/

//Console.WriteLine("Podaj wzrost (m): ");
//wzrost = decimal.Parse(Console.ReadLine());
//Console.WriteLine("Podaj wage (kg): ");
//masa = decimal.Parse(Console.ReadLine());
//wynik = (int)(masa / (decimal)Math.Pow((double)wzrost, 2));
//Console.WriteLine("BMI:{0} wzrost:{1} waga:{2}", wynik, wzrost, masa);
//if (0 < wynik && wynik <= 18.5M)
//{
//    Console.WriteLine("niedowaga");
//}
//else if (18.5M < wynik && wynik <= 25)
//{
//    Console.WriteLine("prawidlowa");
//}
//else if (wynik > 25.0M)
//{
//    Console.WriteLine("nadwaga");
//}
//Console.ReadKey();

//////3.7 Dni tygodnia z liczby zwroc dzień switch.case (zamiast if.else).
//Console.WriteLine("Wpisz nr dnia tygodnia");
//var yyyyy = Console.ReadLine();
//var nrdnia = int.Parse(yyyyy);
//switch (nrdnia)
//{
//    case 1:
//        Console.WriteLine("Poniedziałek");
//        break;
//    case 2:
//        Console.WriteLine("Wtorek");
//        break;
//    case 3:
//        Console.WriteLine("Środa");
//        break;
//    case 4:
//        Console.WriteLine("Czwartek");
//        break;
//    case 5:
//        Console.WriteLine("Piątek");
//        break;
//    case 6:
//        Console.WriteLine("Sobota");
//        break;
//    case 7:
//        Console.WriteLine("Niedziela");
//        break;
//    default:
//        Console.WriteLine("Nie ma takiego dnia tygodnia");
//        break;
//}
//Console.ReadKey();

//2,00 3,99 0,00 zł
//4,00 4,79 350,00 zł
//4,80 5,00 550,00 zł*/

//double srednia;
//Console.WriteLine("podaj sreednia ocen\n");
//srednia = int.Parse(Console.ReadLine());
//double stypendium;
//if (4 <= srednia && srednia <= 4.79)
//    stypendium = 350.0;
//else if (4.8 > srednia && srednia <= 5.0) stypendium = 550; // rozne spoosby na odpowiedz z if 
//else
//{
//    stypendium = 0;
//}
//Console.WriteLine(stypendium);
//Console.ReadKey();

// 3.9 Program tworzacy figury ze znaków "*"
//Console.WriteLine("podaj liczbę wierszy");
//int i = int.Parse(Console.ReadLine());
//for (int n = 1; n <= i; n++)
//{
//    for (int j = 0;  j <= n; j++)
//    {
//        Console.Write("*\t"); // w Console.Write ! !
//    }
//    Console.WriteLine();
//}
//Console.ReadKey();

//3.10 Napisz program obliczający n! (n silnia), gdzie n jest podane przez użytkownika.
///* wykaz wybranych modyfikatorów typów dla literałów:
///*jeśli operator jest przed
///* program przeliczający temperaturę w stopniach Celsjusza na temperaturę w  stopniach Fahrenheita. 
///* oblicz wskaznik BMI = masa/wzrost kg/m */
///*Po wykonaniu przedstawionego niżej kodu programu zmienna gestoscZaludnienia
///*ZADANIA*/
///* Dwaj koledzy Janek i Karol zadłużyli się na 80 zł. Umówili się między sobą, że każdy z
///*3.6 BMI Z zadania 2.3 a potem komunikaty
///* 3.8 Pobierz od użytkownika wartość średniej ocen. Program ma wyświetlać informacje o wysokości przysługującego stypendium zgodnie z poniższą tabelą: Średnia ocen Kwota stypendium
//Console.WriteLine("podaj  liczbe");
//int liczba = int.Parse(Console.ReadLine());
//int s = 1;
//for (int i = 1;  i <= liczba; i++)
//{
//    s *= i;
//}
//Console.WriteLine(s);
//Console.ReadKey();

//3.11Napisz program obliczający ile kolejnych liczb całkowitych (rozpoczynając od wartości 1) należy dodać do siebie, aby suma przekroczyła wartość x.
//int sum = 0;
//int licz = 1;
//int ind = 0;
//Console.WriteLine("podaj wartosc sumy\n");
//int x =(int)double.Parse(Console.ReadLine());
//while (sum <= x)
//{
//    sum = sum + licz;
//    licz++;
//    ind += 1;
//}
//Console.WriteLine(sum);
//Console.WriteLine(ind);
//Console.ReadKey();

// 4.1 tablice
//int uczestnik1 = 19;
//int uczestnik2 = 34;
//int uczestnik3 = 23;
//int uczestnik4 = 54;
//int uczestnik5 = 31;
//double srednia = (uczestnik1 + uczestnik2 + uczestnik3 +
//uczestnik4 + uczestnik5) / 5.0;
//Console.WriteLine(srednia);
//Console.ReadKey();


//int[] uczestnicy = new int[] { 19, 34, 23, 54, 31 };
//albo int[] uczestnicy = {19, 34, 23, 54, 31 };
//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine(uczestnicy[i]);
//}
//Console.ReadKey();

//ALBO
//int ii = 0;
//do
//{
//    Console.WriteLine(uczestnicy[ii]);
//    ii++;
//} while (ii < 5);
//Console.ReadKey();


//int[] tablica = new int[3];
//tablica[0] = 19;
//tablica[1] = 34;
//tablica[2] = 23;

//albo int[] tablica = {19, 34, 23};
//for (int i = 0; i < uczestnicy.Length; i++)
//{
//    Console.WriteLine(uczestnicy[i]);
//}
//Console.ReadKey();


//Console.WriteLine("Ile chcesz wpisać imion?");
//int rozmiar = Convert.ToInt32(Console.ReadLine());
//string[] imiona = new string[rozmiar];
//for (int i = 0; i < imiona.Length; i++)
//{
//    Console.WriteLine("Podaj {0} imię", i + 1);
//    imiona[i] = Console.ReadLine();
//}
//for (int i = 0; i < imiona.Length; i++)
//{
//    Console.Write(imiona[i] + ", ");
//}
//Console.ReadKey();

//prezentowanie wyników od tyłu | od konca
//int[] uczestnicy = { 19, 34, 23, 54, 31 };
//for (int i = uczestnicy.Length - 1; i >= 0; i--)
//    Console.WriteLine(uczestnicy[i]);
//Console.ReadKey();

//int[] uczestnicy = { 19, 34, 23, 54, 31 };
//for (int i = 1; i <= uczestnicy.Length; i++)
//    Console.WriteLine(uczestnicy[i - 1]);
//Console.ReadKey();

/*przypisanie elementom jednej tablicy elementów tablicy drugiej, lecz w kolejności odwrotnej.*/
//int[] uczestnicy = new int[] { 19, 34, 23, 54, 31 };
//int[] odwrotnie = new int[uczestnicy.Length];
//// Wpisywanie elementów do tablicy odwrotnie
//for (int i = uczestnicy.Length - 1; i >= 0; i--)
//    odwrotnie[uczestnicy.Length - i - 1] = uczestnicy[i];
//// Wyświetlenie elementów tablicy odwrotnie
//for (int i = 0; i < odwrotnie.Length; i++)
//    Console.WriteLine(odwrotnie[i]);
//Console.ReadKey();

// PETLA foreach
/*Pętla foreach umożliwia jedynie odczyt kolejno wszystkich elementów tablicy.*/
//int[] uczestnicy = { 19, 34, 23, 54, 31 };
//foreach (int x in uczestnicy)
//{
//    Console.WriteLine(x);
//}
//Console.ReadKey();

//obliczanie sredniej przy użyciu tablicy.
//int[] uczestnicy = { 19, 34, 23, 54, 31 };
//int suma = 0;
//double srednia;
//Console.Write("Wiek uczestników: ");
//for (int i = 0; i < uczestnicy.Length; i++)
//{
//    Console.Write("{0}, ", uczestnicy[i]);
//    suma += uczestnicy[i];
//}
//srednia = (double)suma / uczestnicy.Length;
//Console.WriteLine();
//Console.WriteLine("Średnia: {0}", srednia);
//Console.ReadKey();

// znajdz max lkiczbe w tablicy
//int[] uczestnicy = { 19, 34, 23, 54, 31 };
//int max = uczestnicy[0]; 
//for (int i = 1; i < uczestnicy.Length; i++)
//{
//    if (uczestnicy[i] > max)
//    {
//        max = uczestnicy[i];
//    }
//}
//Console.WriteLine("Najstarszy uczestnik ma {0} lat(a)", max);
//Console.ReadKey();

//Tablice dwuwymiarowe = prostokątne = regularne
//int[,] tablica2d = new int[3, 5];
//int[, ,] tablica3d = new int[2, 2, 2];

using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;
///* wykaz wybranych modyfikatorów typów dla literałów:
///*jeśli operator jest przed
///* program przeliczający temperaturę w stopniach Celsjusza na temperaturę w  stopniach Fahrenheita. 
///* oblicz wskaznik BMI = masa/wzrost kg/m */
///*Po wykonaniu przedstawionego niżej kodu programu zmienna gestoscZaludnienia
///*ZADANIA*/
///* Dwaj koledzy Janek i Karol zadłużyli się na 80 zł. Umówili się między sobą, że każdy z
///*3.6 BMI Z zadania 2.3 a potem komunikaty
///* 3.8 Pobierz od użytkownika wartość średniej ocen. Program ma wyświetlać informacje o wysokości przysługującego stypendium zgodnie z poniższą tabelą: Średnia ocen Kwota stypendium
int[,] tablica2d = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } }; // 4,2  4weirsze i 2 kolumny
Console.WriteLine(tablica2d[2, 0]); //5
Console.WriteLine(tablica2d[2, 1]);//6
Console.WriteLine(tablica2d[1, 1]);//4
Console.WriteLine(" ");
foreach (int x in tablica2d)
{
Console.WriteLine(x);
}
Console.WriteLine(" ");

for (int a = 0; a < 4; a++)
{
    for (int b = 0; b < 2; b++)
    {
        Console.Write("{0,3}", tablica2d[a, b]);
    }
    Console.WriteLine();
}
//Console.WriteLine("Rozmiar: " + tablica2d.Length);
//Console.WriteLine(" ");

////GetLength(). Metoda ta zwraca liczbę elementów w danym wymiarze.
//for (int a = 0; a < tablica2d.GetLength(0); a++) // piwerwszy wiersz
//{
//    for (int b = 0; b < tablica2d.GetLength(1); b++) // druga kolumna
//    {
//        Console.Write("{0,3}", tablica2d[a, b]);
//    }
//}
//Console.WriteLine();
//Console.ReadKey();

/*tablice postrzępione -> tablicą, której elementy są tablicami (czyli jest „tablicą tablic”)
 * W tablicy postrzępionej liczba elementów w poszczególnych wierszach może byc rozna*/

// 3 sposoby:
//int[][] tab = new int[][]
//{
//new int[2],
//new int[4],
//new int[3]
//};

//int[][] tab = new int[3][];
//tab[0] = new int[2];
//tab[1] = new int[4];
//tab[2] = new int[3];


//int[][] tab =
//{
//new int[] {1,2},
//new int[] {3,4,5,6},
//new int[] {7,8,9}
//};
//Console.WriteLine(tab[0][0]); // wypisze 1
//Console.WriteLine(tab[1][2]); // wypisze 5
//Console.WriteLine(tab[2][2]); // wypisze 9
//Console.Write(" \n");
//Console.WriteLine(tab[0].Length); // wypisze 2
//Console.WriteLine(tab[1].Length); // wypisze 4
//Console.WriteLine(tab[2].Length); // wypisze 3
//Console.ReadKey();
//Console.Write(" \n");
//// dodaanie kolejnego poziomu zagnieżdżenia tablicy.
//int[][][] tabs =
//{
//new int[][]
//{
//new int[] {1,2},
//new int[] {3,4,5}
//}
//};
//Console.Write(tabs[0][1][2]); // wypisze 5 Dostęp do poszczególnych elementów takiej tablicy jak powyższym przykładzie wymaga wskazania trzech indeksów
//Console.ReadKey();
//Console.Write(" \n");

//int[][,] taby =
//{
//new int[,] { {1,2}, {3,4} },
//new int[,] { {5,6,7}, {8,9,10} }
//};
///*Wyświetlenie wartości elementu tej tablicy wymaga odwołania się w indeksie
//pierwszym do tablicy jednowymiarowej, a w indeksie drugim do tablicy dwuwymiarowej*/

//Console.WriteLine(taby[1][0, 2]); // wypisze 7 | drugi rzad index 2 czyli 3 pozycja
//Console.Write(" \n");
//Console.ReadKey();

/*Wyświetlanie zawartości całej tablicy postrzępionej umożliwia pętla foreach*/
//int[][] tabi =
//{
//new int[] {1,2},
//new int[] {3,4,5,6},
//new int[] {7,8,9}
//};
//foreach (int[] podtablica in tabi)
//{
//    foreach (int x in podtablica)
//    {
//        Console.Write("{0,2}", x);
//    }
//    Console.WriteLine();
//}
//Console.WriteLine();
//Console.ReadKey();

/*wyświetlenie elementów tablicy postrzępionej odbywa się przy pomocy pętli for oraz właściwości Length*/
//string[][] zespoly = {
//new string[] { "Adam", "Karol" },
//new string[] { "Ola", "Ela", "Jan" } };
//for (int i = 0; i < zespoly.Length; i++)
//{
//    for (int j = 0; j < zespoly[i].Length; j++)
//    {
//        Console.Write("{0,-10}", zespoly[i][j]);
//    }
//    Console.WriteLine();
//}
//Console.ReadKey();
//Console.WriteLine();

//metody klasy Array

/*copy*/
//int[] a = { 11, 22, 33, 44, 55, 66, 77, 88, 99 };
//int[] b = new int[10];
//Array.Copy(a, 2, b, 3, 5); // kopiowanie z a od indexu 2, do tablicy b, do indexu 5 z tablicy a | skomplikowane :)
//foreach (int x in b)
//{
//    Console.Write("{0}, ", x);
//}
//Console.ReadKey();
//Console.WriteLine("");

///*Reverse(): zamiast odwrocenia z uzycie petli for*/
//int[] tab = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//Array.Reverse(tab);
//foreach (int x in tab)
//    Console.Write("{0,2}", x);
//Console.ReadKey();
//Console.WriteLine("nastepnie: sortowanie tablicy");

///*Sort()*/
//int[] taby = { 4, 2, 6, 23, 1, 3, 7, 0 };
//Array.Sort(taby); // sortowanie tablicy
//for (int i = 0; i < taby.Length; i++)
//    Console.WriteLine(taby[i]);
//Console.ReadKey();

///*IndexOf(), która zwraca indeks pierwszego wystąpienia szukanego elementu
// LastIndexOf(), zrwaca ostatnie wystapienie */
////  elementy tablicy  0      1      2        3       4
//string[] imiona = { "Ala", "Ola", "Ela", "Tola", "Ela" };
//Console.WriteLine(Array.IndexOf(imiona, "Ela")); // wypisze 2
//Console.WriteLine(Array.IndexOf(imiona, "Iza")); // wypisze -1
//Console.ReadKey();
//Console.WriteLine();
///*właściwość Rank, która zwraca liczbę wymiarów danej tablicy*/

//////Operacje na tekstach
//string tekst = "Ala ma kota";
//Console.WriteLine(tekst[0]); // od 0: to bedzie  ‘A’
//Console.WriteLine(tekst[4]); //  ‘m’
//Console.WriteLine(tekst[7]); //  ‘k’

//Console.WriteLine("");
//Console.ReadKey();
////tekst po jednym znaku w każdej linii:
//foreach (char litera in tekst)
//{
//    Console.WriteLine(litera);
//}
//Console.WriteLine("od tylu");
//// od tylu
//for (int i = tekst.Length - 1; i >= 0; i--)
//{
//    Console.Write(tekst[i]);
//}
//Console.WriteLine();
//////policzenie, ile razy w danym tekście występuje konkretna litera (lub inny znak).
//int liczbaZnakow = 0;
//foreach (char litera in tekst)
//    if (litera == 'a') liczbaZnakow++;

//Console.WriteLine("Litera a wystąpiła {0} razy", liczbaZnakow);
//Console.ReadKey();
//Console.WriteLine();

//////Substring() pobieranie fragmentu tekstu
//string fragment;
//fragment = tekst.Substring(4, 6);
//Console.WriteLine(fragment); // wypisze "ma kot"
//Console.ReadKey();

/*Compare().Pozwala ona na porównanie dwóch tekstów*/
//int wynik;
//string tekst1 = "Kowalski";
//string tekst2 = "Nowak";
//wynik = String.Compare(tekst1, tekst2); // wypisze -1 bo zero to ok tekst ten sam
//Console.WriteLine(wynik);
//Console.ReadKey();
//Console.WriteLine();

///*Concat(): laczy ciagi znakow*/
//string tekstSklejony;
//string tekst10 = "Ala ma kota";
//string tekst20 = " i psa";
//tekstSklejony = string.Concat(tekst10, tekst20);
//Console.WriteLine(tekstSklejony);
//Console.ReadKey();

///*IndexOf(). by spr czy fragment znajduje sie w innym tekscie, zwroci zero gdy jest OK */
//string tekst = "być albo nie być";
//Console.WriteLine(tekst.IndexOf("być")); // wypisze 0

//////wszystkie wystąpienia szukanego fragmentu
//Console.WriteLine();
//int pozycja, start = 0;
//Console.WriteLine("0123456789012345"); // pomocniczo, aby numerować znaki
//Console.WriteLine(tekst);
//Console.WriteLine("szukany tekst \"być\" jest na pozycjach:");

//while ((pozycja = tekst.IndexOf("być", start)) >= 0)
//{
//    Console.Write("{0}, ", pozycja);
//    start = pozycja + 3; // dalsze szukanie 3 znaki dalej (bo "być" ma 3 znaki)
//}
//Console.ReadKey();

//////Insert() wstawia tekst do łancucha zankow
//string t = "Ala ma kota";
//string nowyTekst;
//nowyTekst = t.Insert(7, "kanarka i ");
//Console.WriteLine("  laczenie ");
//Console.WriteLine(nowyTekst);
//Console.ReadKey();

/*inne metody klasy String:
takich jak: Remove(), ToLower(), ToUpper(), Trim(), Join()*/


////4.3 Zadania do samodzielnego rozwiązania od 121strony

/*Zadanie 4.1.
Napisz program, który pozwoli zapełnić n–elementową tablicę jednowymiarową liczb
całkowitych wartościami podanymi przez użytkownika. Na początku działania programu
użytkownik podaje liczbę elementów tablicy, a następnie poszczególne wartości jej
elementów. Po wypełnieniu całej tablicy program powinien wypisać je w oknie konsoli*/

//Console.WriteLine("Podaj liczbe elementow w tablicy");
//int rozmiar = Convert.ToInt32(Console.ReadLine());
//int[] tablica = new int[rozmiar];   
//for (int x = 0; x < tablica.Length; x++)
//{
//    Console.WriteLine("Podaj {0} liczbe", x + 1);
//    tablica[x] = int.Parse(Console.ReadLine());
//}
//for (int x = 0; x < tablica.Length; x++)
//{
//    Console.Write(tablica[x] + ", ");
//}
//Console.ReadKey();


/*Zadanie 4.2. NIE WYSZŁO
Napisz program kopiujący z danej tablicy liczb całkowitych tab1 do nowej tablicy tab2
wyłącznie wartości dodatnie. Obie tablice mają być jednowymiarowe o rozmiarze równym 10
(czyli 10-elemetowe). Elementy pierwszej tablicy (tab1) należy wpisać w trakcie deklaracji
tej tablicy*/
//int[] tab1 = { -10, 9, -2, 4, -5, 6, -9, -7, 10, 11 };
//int[] tab2 = new int[tab1.Length];
//for (int x = 1; x <= tab1.Length; x++)
//{
//    if (tab1[x] > 0)
//    {
//        for (int y = 0; y <= tab2.Length; y++)
//        {
//            tab2[y] = tab1[x];
//        }
//    }
//        for (int y = 0; y <= tab2.Length; y++)
//        {
//            Console.WriteLine(tab2[y] + ", ");
//        }
//}
//Console.ReadKey();

/*Zadanie 4.3.
Napisz program wyświetlający informacje o wypełnionej przez użytkownika tablicy n-elementowej: NIE UMIEM WYPISAC POZYCJI DLA MAX I MIN WARTOSCI W TABELI

 wartość i numer pozycji największego elementu,
 wartość i numer pozycji najmniejszego elementu,
 średnia wartości wszystkich elementów tablicy,
 liczba dodatnich elementów tablicy*/
//int[,] tablica2d = { { 1, -2 }, { 3, -4 }, { 5, 8 }, { -7, 6 } };
//Console.WriteLine("wyswietlenie tablicy");
//for (int a = 0; a < 4; a++)
//{
//    for (int b = 0; b < 2; b++)
//    {
//        Console.Write("{0,3}", tablica2d[a, b]);
//    }
//    Console.WriteLine();
//}
//Console.WriteLine("sprawdzenie liczby dodatnich elementów tablicy");
//int count = 0;
//for (int a = 0; a < 4; a++)
//{
//    for (int b = 0; b < 2; b++)
//    {
//        if (tablica2d[a, b] > 0)
//        {
//            count += 1;
//        }
//    }
//}
//Console.WriteLine(" dodatnich elementów jest {0}", count);
//Console.WriteLine();
//Console.WriteLine("średnia wartości w tablicy 2d ");
//int suma = 0;
//double srednia;
//for (int a = 0; a < 4; a++)
//{
//    for (int b = 0; b < 2; b++)
//    {
//        Console.Write("{0}, ", tablica2d[a, b]);
//        suma += tablica2d[a, b];
//    }
//}
//srednia = (double)suma / tablica2d.Length;
//Console.WriteLine();
//Console.WriteLine(" Średnia: {0}", srednia);
//Console.WriteLine();
//Console.WriteLine("wartość i numer pozycji największego elementu w tablicy 2d ");
//int max = 0;
//for (int a = 0; a < 4; a++)
//{
//    for (int b = 0; b < 2; b++)
//    {

//        if (tablica2d[a, b] > max)
//        {
//            max = tablica2d[a, b];
//        }
//    }
//}
//Console.WriteLine(" max element w tablicy {0}", max);
//Console.WriteLine("{0,3}", tablica2d[2, 1]);
//Console.WriteLine();


//Console.WriteLine("wartość i numer pozycji najmniejszego elementu w tablicy 2d ");
//int min = 0;
//for (int a = 0; a < 4; a++)
//{
//    for (int b = 0; b < 2; b++)
//    {

//        if (tablica2d[a, b] < min)
//        {
//            min = tablica2d[a, b];
//        }
//    }
//}
//Console.WriteLine(" min element w tablicy {0}", min);
////Console.WriteLine("{}", tablica2d[1][3, 0]);
//Console.ReadKey();

//Console.WriteLine();
/*Zadanie 4.4.
Napisz program, który podaje, ile jest liczb pierwszych w tablicy 100 elementowej typu
int. Tablicę należy wypełnić losowymi wartościami. Wskazówka: Poniższy fragment
programu pokazuje działanie klasy Random (która zawiera generator liczb pseudolosowych) –
w pętli zostanie wyświetlonych 100 liczb wybranych losowo z zakresu 1 – 999 (o zakresie
decydują argumenty podane w wywołaniu metody Next()43).
Random rand = new Random();
for (int i = 0; i < 100; i++)
Console.Write("{0,8}", rand.Next(1, 1000))*/


//int[] elementy = new int[100];
//Random rand = new Random();
//int ind = 0;
//for (int i = 0; i < 100; i++)
//{
//    elementy[i] = rand.Next(1, 100);
//    Console.Write(elementy[i] + ", ");
//    if (elementy[i] == 0 || elementy[i] == 1)
//    {
//        Console.WriteLine(elementy[i] + " is not prime number");
//    }
//    else
//    {
//        for (int a = 2; a <= elementy[i] / 2; a++)
//        {
//            if (elementy[i] % a == 0)
//            {
//                Console.WriteLine(elementy[i] + " is not prime number");

//            }
//        }
//        ind += 1;
//        Console.WriteLine(elementy[i] + " is a prime number");

//    }
//}
//Console.WriteLine("{0}", elementy.Length);
//Console.WriteLine("liczb pierwszych jest : {0}", ind);
//Console.ReadKey();

/*Zadanie 4.5. UDAŁO SIĘ
Dana jest n-elementowa tablica liczb całkowitych tab1. Napisz program kopiujący
wartości elementów tablicy tab1 do tablicy tab2 (o tym samym rozmiarze) z przesunięciem o
jedną pozycje. To znaczy, że element w tablicy źródłowej o indeksie 0 powinien znaleźć się w
tablicy docelowej pod indeksem 1, element o indeksie 1 ma być w tablicy docelowej pod
indeksem 2 itd. Element ostatni tablicy źródłowej ma być elementem o indeksie 0 w tablicy
docelowej*/
int[] tab1 = {-10, 9, -2, 4, -5, 6, -9, -7, 10, 11 };
int[] tabela2 = new int[tab1.Length];
Array.Copy(tab1, 9, tabela2, 0, 1);
Array.Copy(tab1, 0, tabela2, 1, 9);
foreach (int x in tabela2)
{
    Console.Write("{0}, ", x);
}
Console.ReadKey();
Console.WriteLine("");

/*Zadanie 4.6.
Napisz program, który deklaruje i inicjalizuje dwuwymiarową tablicę liczb
rzeczywistych o rozmiarze 5 x 5. Program ma wyświetlić elementy tablicy (wiersz po
wierszu), a następnie wyświetlić sumę elementów znajdujących się na głównej przekątnej
tablicy (główna przekątna – od elementu o indeksach 0,0 do elementu o indeksach n,n)*/
int[,] rzeczywiste = { { 1, 2, 3, 4, 5 }, { 3, 4, 5, 6, 9 }, { 1, 2, 3, 4, 5 }, { 5, 6, 9, 9, 1 }, { 7, 8, 6, 8, 7 } };
Console.WriteLine("5x5 ");
int suma = 0;
for (int a = 0; a < 5; a++)
{
    for (int b = 0; b < 5; b++)
    {
        Console.Write("{0,4}", rzeczywiste[a, b]);
        if (a == b)
        {
            suma += rzeczywiste[a, b];
        }
    }
    Console.WriteLine();
}
Console.WriteLine(" suma po przekatnej to: {0}", suma);

/*Zadanie 4.8.
Uzupełnij poniższy kod programu o wszystkie dni tygodnia i przy użyciu pętli wyświetl
zawartość tablicy: w każdym wierszu dany dzień tygodnia w trzech językach (polskim,
angielskim, niemieckim).
string[,] dniTygodnia;
dniTygodnia = new string[2, 3]; // pamiętaj o zmianie rozmiaru tablicy
dniTygodnia[0, 0] = "poniedzialek";
dniTygodnia[1, 0] = "wtorek";
dniTygodnia[0, 1] = "monday";
dniTygodnia[1, 1] = "tuesday";
dniTygodnia[0, 2] = "montag";
dniTygodnia[1, 2] = "dienstag"*/

string[,] dniTygodnia;
dniTygodnia = new string[3, 3]; // pamiętaj o zmianie rozmiaru tablicy
dniTygodnia[0, 0] = "poniedzialek";
dniTygodnia[1, 0] = "wtorek";
dniTygodnia[0, 1] = "monday";
dniTygodnia[1, 1] = "tuesday";
dniTygodnia[0, 2] = "montag";
dniTygodnia[1, 2] = "dienstag";
dniTygodnia[2, 0] = "środa";
dniTygodnia[2, 1] = "Wednesday";
dniTygodnia[2, 2] = "Mittwoch";
for (int a = 0; a < 3; a++)
{
    for (int b = 0; b < 3; b++)
    {
        Console.Write("{0,2}, ", dniTygodnia[a, b]);
    }
    Console.WriteLine();
}

Console.WriteLine("operacje na tekstach \n");
/*Zadanie 4.9.
Napisz program obliczający liczbę wyrazów w łańcuchu znaków wprowadzonym przez
użytkownika. Należy przyjąć, że wyrazy to ciągi znaków rozdzielone spacją*/

//Console.WriteLine("Podaj wyrażenie: ");
//string wyrazenie =  Console.ReadLine();
//int zlicz = 1;
//foreach (char slowo in wyrazenie)
//    if (slowo == ' ') 
//    {
//        zlicz++;
//    }
//Console.WriteLine("{0} slow w wyrazeniu: {1}", zlicz, wyrazenie);
//Console.ReadKey();

/*Zadanie 4.10.
Napisać program, który pobierze datę w formacie DD-MM-RRRR, z której pobierze
miesiąc i wyświetli jego nazwę słownie*/
Console.WriteLine(DateTime.Now.ToString("MM/dd/yyyy"));
Console.WriteLine(DateTime.Now.ToString("MMMM"));

/*Zadanie 4.11. Na razie tylko dla jednej litery
Napisz program analizujący częstość występowania poszczególnych znaków w
łańcuchu znaków wprowadzonym przez użytkownika. Np. dla wprowadzonego tekstu
„abrakadabra” program powinien wyświetlić informacje: a – 5, b – 2, r – 2, k – 1, d – 1.*/

//Console.WriteLine("Zliczamy ilosc wystepowanie poszczegolnych znakow");
//string ciag = "abrakadabra";
//int liczbaZnakow = 0;
//int pozycja, start = 0;
//Console.WriteLine(ciag);
//Console.WriteLine("szukany tekst {0} jest na pozycjach:", ciag[0]);

//while ((pozycja = ciag.IndexOf(ciag[0], start)) >= 0)
//{
//    Console.Write("{0}, ", pozycja);
//    start = pozycja + 1;
//    liczbaZnakow++;
//}
//Console.WriteLine("\nLitera {1} wystąpiła {0} razy", liczbaZnakow, ciag[0]);

/*Zadanie 4.13.
Napisz program, który przeanalizuje dany łańcuch pod kątem wielokrotnego
występowania słów w tekście. Przykładowo dla zmiennej łańcuchowej o zawartości: „Kiedy
idzie się po miód z balonikiem, to trzeba się starać, żeby pszczoły nie wiedziały, po co się
idzie – odpowiedział Puchatek” – program powinien wypisać raport o słowach powielonych
w tym tekście: idzie – 2 razy, po – 2 razy, się – 3 razy.*/
string tekstowo = "Kiedy idzie się po miód z balonikiem, to trzeba się starać, żeby pszczoły nie wiedziały, po co się idzie – odpowiedział Puchatek";
int liczbaZnakow = 0;
int pozycja, start = 0;
Console.WriteLine(tekstowo);
Console.WriteLine("szukany tekst {0} jest na pozycjach:", tekstowo[0]);
foreach (char x in tekstowo)
{
    if (x == ' ')
    {
        x;
    }

}

while ((pozycja = tekstowo.IndexOf("Kiedy", start)) >= 0)
{
    Console.Write("{0}, ", pozycja);
    start = pozycja + 1;
    liczbaZnakow++;
}
Console.WriteLine("\nslowo {1} wystąpiła {0} razy", liczbaZnakow, "Kiedy");


/*5 Metody str 125*/

