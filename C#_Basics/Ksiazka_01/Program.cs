decimal masa, wzrost, wynik;

int p = 2;
Console.WriteLine("Podaj wzrost (m): ");
wzrost = decimal.Parse(Console.ReadLine());

Console.WriteLine("Podaj wage (kg): ");
masa = decimal.Parse(Console.ReadLine());

wynik = masa / (decimal)Math.Pow((double)wzrost, 2);

if (0 < wynik && wynik <= 18.5M)
{
    Console.WriteLine(wynik);
    Console.WriteLine("niedowaga");
}
else if (18.5M < wynik && wynik <= 25)
{
    Console.WriteLine(wynik);
    Console.WriteLine("prawidlowa");
}
else if (wynik > 25.0M)
{
    Console.WriteLine(wynik);
    Console.WriteLine("nadwaga");
}

Console.ReadKey();


