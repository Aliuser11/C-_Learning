﻿//using Microsoft.Win32;
//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Schema;

///* wykaz wybranych modyfikatorów typów dla literałów:
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
///*jeśli operator jest przed
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

////zadania do samodzielnego rozwiązania 2.7
///* program przeliczający temperaturę w stopniach Celsjusza na temperaturę w  stopniach Fahrenheita. 
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


///* oblicz wskaznik BMI = masa/wzrost kg/m */
//decimal masa, wzrost;
//Console.WriteLine("Podaj wzrost (m): ");
//wzrost = decimal.Parse(Console.ReadLine());
//Console.WriteLine("Podaj wage (kg): ");
//masa = decimal.Parse(Console.ReadLine());
//wynik = (int)(masa / (decimal)Math.Pow((double)wzrost, 2));
//Console.WriteLine(wynik);
//Console.ReadKey();


///*Po wykonaniu przedstawionego niżej kodu programu zmienna gestoscZaludnienia
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

///*ZADANIA*/
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
///* Dwaj koledzy Janek i Karol zadłużyli się na 80 zł. Umówili się między sobą, że każdy z
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


///*3.6 BMI Z zadania 2.3 a potem komunikaty
//*  < 18,5 – niedowaga,
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

///* 3.8 Pobierz od użytkownika wartość średniej ocen. Program ma wyświetlać informacje o wysokości przysługującego stypendium zgodnie z poniższą tabelą: Średnia ocen Kwota stypendium
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
Console.WriteLine("podaj  liczbe");
int liczba = int.Parse(Console.ReadLine());
int s = 1;
for (int i = 1;  i <= liczba; i++)
{
    s *= i;
}
Console.WriteLine(s);
Console.ReadKey();

//// /*str 90 zadania 3.10 - 3.15
////rozdzial 4 od strony 91*/




