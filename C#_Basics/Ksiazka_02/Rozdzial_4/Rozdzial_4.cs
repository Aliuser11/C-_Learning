using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


//Zaawansowane elementy języka C#
namespace Zdarzenie
    { 
    internal class Program
    {
        private static void NewMain(string[] args)
        {
            Stock stock = new Stock("THPW");
            stock.Price = 27.10M;
            // rejestracja w zdarzeniu PriceChanged
            //stock.PriceChanged += stock_PriceChanged;
            stock.Price = 31.59M;



            void stock_PriceChanged(object sender, PriceChangedEventArgs e)
            {
                if ((e.NewPrice - e.LastPrice) / e.LastPrice > 0.1M)
                    Console.WriteLine("Uwaga: wzrost cen akcji o 10%!");
            }
        }
    }

    public class PriceChangedEventArgs : EventArgs
        {
            public readonly decimal LastPrice;
            public readonly decimal NewPrice;
            public PriceChangedEventArgs(decimal lastPrice, decimal newPrice)
            {
                LastPrice = lastPrice; NewPrice = newPrice;
            }
        }
    public class Stock
    {
        string symbol;
        decimal price;
        public Stock(string symbol) { this.symbol = symbol; }
        public event EventHandler PriceChanged;
        protected virtual void OnPriceChanged(EventArgs e)
        {
            PriceChanged?.Invoke(this, e);
        }
        public decimal Price
        {
            get { return price; }
            set
            {
                if (price == value) return;
                price = value;
                OnPriceChanged(EventArgs.Empty);
            }
        }
    }
}
namespace lambda
{

    /*Wyrażenia lambda*/
    class Wykonaj

    {
        static Func<int> Natural()
        {
            int seed = 0;
            Console.WriteLine(seed); 
            return () => seed++;

        }

        static void NewMain()
        {
            //Func<int, int> sqr = x => { return x * x; };
            //Transformer sqr = x => { return x * x; };
            //Console.WriteLine(sqr(3));
            //delegate int Transformer(int i);
            int factor = 2;
            Func<int, int> multiplier = n => n * factor;
            Console.WriteLine(multiplier(3));

            Func<int, int> multiplier2 = n => n * factor;
            factor = 10;
            Console.WriteLine(multiplier2(3)); // 30


            Func<int> natural = Natural();
            Console.WriteLine(natural()); // 0
            Console.WriteLine(natural()); // 1


        }
    }
}

namespace Try
{
    class Test
    {
        static void MainMain(string[] args)
        {
            try
            {
                byte b = byte.Parse(args[0]);
                Console.WriteLine(b);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("podaj argument.");
                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("to nie liczba");
            }
            catch (OverflowException)
            {
                Console.WriteLine("przekazano za duzo");
            }
            finally
            {
                Console.WriteLine("koniec");
            }
        }
    }
}


class Fibonacci
{

    static void Main()
    {

        IEnumerable<int> Fibs(int fibCount)
        {
            for (int i = 0, prevFib = 1, curFib = 1; i < fibCount; i++)
            {
                yield return prevFib;
                int newFib = prevFib + curFib;
                prevFib = curFib;
                curFib = newFib;
            }

        }
        foreach (int fib in Fibs(6))
            Console.WriteLine(fib + " ");
        Console.WriteLine();



        IEnumerable<int> EvenNumbersOnly(IEnumerable<int> sequence)
        {
            foreach (int x in sequence)
                if ((x % 2) == 0)
                    yield return x;
        }

        foreach (int fib in EvenNumbersOnly(Fibs(6)))
            Console.WriteLine(fib);



    }
}