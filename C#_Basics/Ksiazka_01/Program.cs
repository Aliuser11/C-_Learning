decimal masa, wzrost, wynik;

int p = 2;
Console.WriteLine("Podaj wzrost (m): ");
wzrost = decimal.Parse(Console.ReadLine());

Console.WriteLine("Podaj wage (kg): ");
masa = decimal.Parse(Console.ReadLine());

wynik = masa / (decimal)Math.Pow((double)wzrost, 2);

Console.WriteLine("BMI:{0} wzrost:{1} waga:{2}", wynik, wzrost, masa);
if (0 < wynik && wynik <= 18.5M)
{
    Console.WriteLine("niedowaga");
}
else if (18.5M < wynik && wynik <= 25)
{
    Console.WriteLine("prawidlowa");
}
else if (wynik > 25.0M)
{
    Console.WriteLine("nadwaga");
}

Console.ReadKey();


