using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

//Zaawansowane elementy języka C#
//namespace Rozdzial_4
//{
//    internal class Program
//    {
//        //delegaty
//        delegate int Transformer(int x); //zgodny z metodami o zwrocie int i jednym przyjmowanym argumencie
//        int Square(int x) => x * x; // ta metoda może mieć przypisanie zmiennej typu dlegacyjnego
//        int[] values = { 1, 2, 3 };
//        Transform(values, Square); // podłączenie metody Square
//        foreach (int i in values)        
//        Console.Write(i + " "); // 1 4 9

//        int Square(int x) => x * x;
//        int Cube(int x) => x * x * x;
//        delegate int Transformer(int x);
//    }

//    static void Main(string[] args)
//    {
//        Transformer t = new Transformer(Square); ; // egzemplarz delegatu
//        int result = t(3);
//        Console.WriteLine(result);
//    }
//    void Transform(int[] values, Transformer t)
//    {
//        for (int i = 0; i < values.Length; i++)
//            values[i] = t(values[i]);
//    }

//}

/*Zdarzenia*/ //s174
public delegate void PriceChangedHandler(decimal oldPrice,
decimal newPrice);
public class Stock
{
    string symbol;
    decimal price;
    public Stock(string symbol) { this.symbol = symbol; }
    public event PriceChangedHandler PriceChanged;
    public decimal Price
    {
        get { return price; }
        set
        {
            if (price == value) return; // koniec pracy, jeśli nic się nie zmieniło
            decimal oldPrice = price;
            price = value;
            if (PriceChanged != null) // jeśli lista wywołań nie jest pusta,
            PriceChanged(oldPrice, price); // następuje uruchomienie zdarzenia
        }
    }
}
//177