using System.Text.RegularExpressions;

/*Regex*/
Console.WriteLine(Regex.Match("color", @"colou?r").Success); // prawda
Console.WriteLine(Regex.Match("colour", @"colou?r").Success); // prawda
Console.WriteLine(Regex.Match("colouur", @"colou?r").Success); // fałsz

Match m = Regex.Match("Dowolny ulubiony kolor", @"kolor?");
Console.WriteLine(m.Success); // prawda
Console.WriteLine(m.Index); // 4
Console.WriteLine(m.Length); // 6
Console.WriteLine(m.Value); // kolor
Console.WriteLine(m.ToString()); // kolor

Match m1 = Regex.Match("Tylko jeden kolor? Mam na myśli dwa kolory!", @"kolory?");
Match m2 = m1.NextMatch();
Console.WriteLine(m1); // kolor
Console.WriteLine(m2); // kolory

//albo z foreach
foreach (Match mm in Regex.Matches("Tylko jeden kolor? Mam na myśli dwa kolory!", @"kolory?"))
{
    Console.WriteLine(mm);
}

//kompilowanie
Regex r = new Regex(@"pomidory?", RegexOptions.Compiled);
Console.WriteLine(r.Match("pomidor")); // pomidor
Console.WriteLine(r.Match("pomidory")); // pomidory

//RegexOptions
Console.WriteLine(Regex.Match("a", "A", RegexOptions.IgnoreCase)); // a

Console.WriteLine(Regex.Match("a", "A", RegexOptions.IgnoreCase
| RegexOptions.CultureInvariant));

//IgnorePatternWhitespace ->  (?x)
Console.WriteLine(Regex.Match("a", @"(?i)A")); // a

Console.WriteLine(Regex.Match("AAAa", @"(?i)a(?-i)a")); // Aa

//znaki sterujace: \ * + ? | { [ () ^ $ . #
Console.WriteLine(Regex.Match("co takiego?", @"co takiego\?")); // co takiego? (prawidłowo)
Console.WriteLine(Regex.Match("co takiego?", @"co takiego?")); // co takiego (nieprawidłowo)

//Escape() i Unescape() metaznaki
Console.WriteLine(Regex.Escape(@"?")); // \?
Console.WriteLine(Regex.Unescape(@"\?")); // ?>


//zestawy znakow
/*
             [abcdef] Dopasowuje pojedynczy znak z listy [^abcdef]
            [a-f] Dopasowuje pojedynczy znak z danego zakresu [^a-f]
            \d Dopasowuje wszystko, co znajduje się w kategorii cyfr w standardzie Unicode. W trybie
            ECMAScript są to cyfry ze zbioru [0-9]
            \D
            \w Dopasowuje słowo (domyślnie w zależności od ustawienia
            CultureInfo.CurrentCulture, np. w języku polskim będzie to odpowiednik zapisu
            [a-zA-Z_0-9])
            \W
            \s Dopasowuje biały znak, tzn. wszystko, dla czego char.IsWhiteSpace zwraca true
            (włącznie ze spacjami Unicode). W trybie ECMAScript — [\n\r\t\f\v ]
            \S
            \p{kategoria} Dopasowuje znak z podanej kategorii \P
            . Dopasowuje dowolny znak, z wyjątkiem \n (tryb domyślny) \n
            . Dopasowuje dowolny znak (tryb SingleLine) \n
 */

//jeden znak -> nawias kwadratowy []

Console.Write(Regex.Matches("To jest to.", "[Tt]o").Count); // 2

//dopasowania dowolnego znaku -> wykluczone znaki umieścić w nawiasach kwadratowych i poprzedzić pierwszy symbolem ^:
Console.Write(Regex.Match("quiz qwerty", "q[^aeiou]").Index); // 5

//podania zakresu znaków za pomocą łącznika.
Console.Write(Regex.Match("b1-c4", @"[a-h]\d-[a-h]\d").Success); // prawda


//kwantyfikatory -> dopasowanie el podaną ilosc razy
/*
         * Zero lub więcej dopasowań
        + Jedno dopasowanie lub więcej dopasowań
        ? Zero dopasowań lub jedno dopasowanie
        {n} Dokładnie n dopasowań
        {n,} Przynajmniej n dopasowań
        {n,m} Od n do m dopasowań
 */
Console.Write(Regex.Match("cv15.docx", @"cv\d*\.docx").Success); // prawda
Console.Write(Regex.Match("cvjoint.doc", @"cv.*\.docx").Success); // prawda
Console.Write(Regex.Matches("wolno! naprawdę wooolno!", "wo+lno").Count); // 2

Regex bp = new Regex(@"\d{2,3}/\d{2,3}");
Console.WriteLine(bp.Match("Zwykle mam ciśnienie 160/110")); // 160/110
Console.WriteLine(bp.Match("Teraz mam ciśnienie zaledwie 115/75")); // 115/75

//Kwantyfikator zachłanny(max) kontra leniwy(min) razy stosowany
string html = "<i>Domyślnie</i> kwantyfikatory są <i>zachłannymi</i> bestiami";

// zachlanny
foreach (Match mx in Regex.Matches(html, @"<i>.*</i>"))
    Console.WriteLine(mx); // jedno dopasowanie

//leniwy -> Dowolny kwantyfikator można zdefiniować jako leniwy przez dodanie do niego przyrostka ?.
foreach (Match mo in Regex.Matches(html, @"<i>.*?</i>"))
    Console.WriteLine(mo);


//asercje o zerowej długości
//W poniższym przykładzie szukamy liczby, po której znajduje się słowo mil:
Console.WriteLine(Regex.Match("powiedzmy jakieś 25 mil dalej", @"\d+\s(?=mil)")); //25

//po dołączeniu .* do wyrażenia, jak w poniższym fragmencie kodu:
Console.WriteLine(Regex.Match("powiedzmy jakieś 25 mil dalej", @"\d+\s(?=miles).*")); // 25 mil dalej


//przewidywania
string regex = "(?i)dobra(?!.*(jednak|ale))";
Console.WriteLine(Regex.IsMatch("Dobra robota! Ale...", regex)); // fałsz
Console.WriteLine(Regex.IsMatch("Dobra robota! Dziękujemy!", regex)); // prawda


/*Konstrukcja(?<= expr) oznacza pozytywne przewidywanie wsteczne i wymaga, aby
 dopasowanie było poprzedzone podanym wyrażeniem. Z kolei przeciwna konstrukcja (?<!expr) oznacza
negatywne przewidywanie wsteczne i wymaga, aby dopasowanie nie było poprzedzone podanym wyrażeniem.*/

string regex1 = "(?i)(?<!jednak.*)dobrze";
Console.WriteLine(Regex.IsMatch("Jednak dobrze, sądziliśmy...", regex1)); // fałsz
Console.WriteLine(Regex.IsMatch("Bardzo dobrze, dziękujemy!", regex1)); // prawda

//kotwice Kotwice ^ i $ powodują dopasowanie określonego położenia 
/*
    ^ Dopasowanie początku ciągu tekstowego.

    $ Dopasowanie końca ciągu tekstowego.

Znak ^ ma dwa znaczenia zależne od kontekstu: kotwicę i znak negacji klasy.
Znak $ również ma dwa znaczenia zależne od kontekstu: kotwicę i znak grupy
zastępującej.

*/

Console.WriteLine(Regex.Match("Nie teraz", "^[Nn]ie")); // Nie
Console.WriteLine(Regex.Match("f = 0.2F", "[Ff]$")); // F
/*Jeżeli podamy RegexOptions.Multiline lub umieścimy (?m) w wyrażeniu regularnym, to:
• znak ^ dopasuje początek ciągu tekstowego lub wiersza (dokładnie po \n);
• znak $ dopasuje koniec ciągu tekstowego lub wiersza (dokładnie przed \n).*/

/*Granica słowa
Asercja granicy słowa \b spowoduje dopasowanie miejsca, w którym znaki słowa (\w) graniczą z:
• znakami nienależącymi do żadnego słowa (\W);
• początkiem lub końcem ciągu tekstowego (^ i $).
Wyrażenie \b jest często używane do dopasowywania całych słów. Spójrz na poniższy fragment
kodu*/

foreach (Match m3 in Regex.Matches ("Wesele na wzgórzu", @"\b\w+\b"))
Console.WriteLine (m3);
//wesele
//na
//wzgorzu

//granice slowa
int one = Regex.Matches("Wesele na wzgórzu", @"\bna\b").Count; // 1
int two = Regex.Matches("Wesele na wzgórzu", @"na").Count; // 2

//szukanie slowa znajdujacego sie przed wybraná sekwencjá znakow
string text = "Nie trać (sic) głowy";
Console.Write(Regex.Match(text, @"\b\w+\b\s(?=\(sic\))")); // trać

//Grupy -> seria podwyrażeń
Match m4 = Regex.Match("206-465-1918", @"(\d{3})-(\d{3}-\d{4})"); // jak nr tel 206-465-1918
Console.WriteLine(m4.Groups[1]); // 206
Console.WriteLine(m4.Groups[2]); // 465-1918

Console.WriteLine(m4.Groups[0]); // 206-465-1918
Console.WriteLine(m4); // 206-465-1918

//wyszukujemy w ciągu tekstowym wszystkie słowa, którezaczynają się i kończą tą samą literą:
foreach (Match m5 in Regex.Matches("pop pope peep", @"\b(\w)\w+\1\b"))
    Console.Write(m5 + " "); // pop peep
//967
