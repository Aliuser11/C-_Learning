//255 poczatek nowego 5 rozdziału
/*.NET Standard*/

/*

Wersje środowiska i C#
Kompilator C# automatycznie wybiera wersję języka na podstawie środowiska docelowego
projektu:
• Dla.NET 5 wybiera C# 9.
• Dla .NET Core 3.x, Xamarin i .NET Standard 2.1 wybiera C# 8.
• Dla .NET Core 2.x, .NET Framework i .NET Standard 2.0 oraz wcześniejszych wybiera C# 7.3.*/

//ASP.NET Core do witryn internetowych, REST API,
//WIndows Desktop

// od strony 268  platforma .NET
/*
 > SINGLETON
To register a service as a Singleton in .NET Core, use the AddSingleton method:
<services.AddSingleton<ILoggingService, LoggingService>();>
example: a logging services -> all components in application uses the same instance, facilitating centralized logging and resource sharing

 > SCOPED
Scoped lifetime creates a new instance of a service for each scope or logical operation within an application
To register a service as Scoped, use the AddScoped method:
<services.AddScoped<IDatabaseService, DatabaseService>();>
example:  when handling a web request, you may have a service that interacts with a database. In this scenario, using Scoped lifetime ensures that each request gets its own instance of the service, avoiding conflicts between multiple requests.

 > TRANSIENT
 Transient lifetime creates a new instance of a service every time it is requested
To register a service as Transient, use the AddTransient method:
<services.AddTransient<IUtilityService, UtilityService>();>
example: simple calculation services

summary:
Singleton
Use Singleton when you have stateless services or shared resources that need to be accessed consistently across the application.
Be cautious when using Singleton with services that maintain mutable state, as concurrent access can lead to unexpected behavior or race conditions.
Scoped
Use Scoped when you have stateful services or resources that need to be shared within a specific context, such as a web request or unit of work.
Scoped instances help ensure that each request or operation gets its own isolated instance, preventing interference between different contexts.
Transient
Use Transient for lightweight and stateless services that don’t maintain any internal state or shared resources.
Transient instances are suitable for services that perform simple calculations, generate random numbers, or provide general utility functions.
*/

//Metoda string.Format i złożone łańcuchy formatu str 272
//interpolacji wartości do literałów łańcuchowych:
using System;
using System.Text;

string s = $"Jest {DateTime.Now.DayOfWeek} rano i strasznie doskwiera mi upał.";
string composite = "Dziś rano w mieście {0} było {1} stopni Celsjusza.";
string s = string.Format(composite, "Perth", 35, DateTime.Now.DayOfWeek); // s == "Dziś rano w mieście Perth było 35 stopni Celsjusza."

string s = "Name=" + "Maria".PadRight(20) + " Credit Limit=" + 500.ToString("C").PadLeft(15); //Name=Maria Credit Limit= 500,00 zł

//algorytmom porównywania platformy.NET Framework/
///porównywanie kulturowe lub bez rozróżniania wielkości liter:
public bool Equals(string value, StringComparison comparisonType);
public static bool Equals(string a, string b,
StringComparison comparisonType);
public enum StringComparison
{
    CurrentCulture, // rozróżnia wielkość liter
    CurrentCultureIgnoreCase,
    InvariantCulture, // rozróżnia wielkość liter
    InvariantCultureIgnoreCase,
    Ordinal, // rozróżnia wielkość liter
    OrdinalIgnoreCase
}


Console.WriteLine(string.Equals("foo", "FOO",
StringComparison.OrdinalIgnoreCase)); // prawda
Console.WriteLine("ṻ" == "ǖ"); // fałsz
Console.WriteLine(string.Equals("ṻ", "ǖ",
StringComparison.CurrentCulture)); // ?

//Klasa StringBuilder: Na jej obiektach można wywoływać metody: Append, Insert, Remove i Replace
StringBuilder sb = new StringBuilder();
for (int i = 0; i < 50; i++) sb.Append(i).Append(",");
Console.WriteLine(sb.ToString()); //0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,

//Data i godzina. Struktura TimeSpan
public TimeSpan (int hours, int minutes, int seconds);
public TimeSpan (int days, int hours, int minutes, int seconds);
public TimeSpan (int days, int hours, int minutes, int seconds,
int milliseconds);
public TimeSpan (long ticks); // każde tyknięcie = 100 ns

//dy trzeba określić przedział czasu w jednej jednostce:
public static TimeSpan FromDays(double value);
public static TimeSpan FromHours(double value);
public static TimeSpan FromMinutes(double value);
public static TimeSpan FromSeconds(double value);
public static TimeSpan FromMilliseconds(double value);
Console.WriteLine(new TimeSpan(2, 30, 0)); // 02:30:00
Console.WriteLine(TimeSpan.FromHours(2.5)); // 02:30:00

TimeSpan.FromDays(10) - TimeSpan.FromSeconds(1); // 9.23:59:59
//własności Days, Hours, Minutes, Seconds oraz Milliseconds:
Console.WriteLine(nearlyTenDays.Days); // 9
Console.WriteLine(nearlyTenDays.Hours); // 23
Console.WriteLine(nearlyTenDays.Minutes); // 59
Console.WriteLine(nearlyTenDays.Seconds); // 59
Console.WriteLine(nearlyTenDays.Milliseconds); // 0

//własności Total… zwracają wartości typu double przedstawiające cały przedział czasu:
Console.WriteLine(nearlyTenDays.TotalDays); // 9,99998842592593
Console.WriteLine(nearlyTenDays.TotalHours); // 239,999722222222
Console.WriteLine(nearlyTenDays.TotalMinutes); // 14399,9833333333
Console.WriteLine(nearlyTenDays.TotalSeconds); // 863999
Console.WriteLine(nearlyTenDays.TotalMilliseconds); // 863999000

//Struktury DateTime i DateTimeOffset | Zapewniają dokładność do 100 ns oraz rozpiętość wartości od 0001 do 9999 lat.
public DateTime (int year, int month, int day,
int hour, int minute, int second, int millisecond);
//konstruktorom DateTime można przekazywać wyliczenie DateTimeKind, które ma następujące wartości: Unspecified, Local, Utc

//w przypadku DateTimeOffset dodatkowo określa się przesunięcie względem czasu UTC za pomocą wartości typu TimeSpan
public DateTimeOffset (int year, int month, int day,
int hour, int minute, int second, int millisecond,
TimeSpan offset); // imeSpan musi reprezentować całkowitą liczbę minut, a jeśli tak nie jest, zostaje zgłoszony wyjątek.

DateTimeOffset dt = new DateTime(2000, 2, 3);
Console.WriteLine(DateTimeOffset.UtcNow);
Console.WriteLine(DateTime.Today);
Console.WriteLine(DateTime.Now);


DateTime dt = new DateTime(2000, 2, 3, 10, 20, 30);
Console.WriteLine(dt.Year); // 2000
Console.WriteLine(dt.Month); // 2
Console.WriteLine(dt.Day); // 3
Console.WriteLine(dt.DayOfWeek); // Thursday
Console.WriteLine(dt.DayOfYear); // 34
Console.WriteLine(dt.Hour); // 10
Console.WriteLine(dt.Minute); // 20
Console.WriteLine(dt.Second); // 30
Console.WriteLine(dt.Millisecond); // 0
Console.WriteLine(dt.Ticks); // 630851700300000000
Console.WriteLine(dt.TimeOfDay); // 10:20:30 (zwraca obiekt typu TimeSpan)

//Daty i strefy czasowe 288




















