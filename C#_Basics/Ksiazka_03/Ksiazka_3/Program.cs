using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Zadania
{

    private int zadania;

    public int GetZadania()
    {
        return zadania;
    }

    private void SetZadania(int value)
    {
        zadania = value;
    }

    public Zadania(int a)
    {
        a = 1;
    }
    public void MAxMin()
    {

    }
    public static int Kolejnosc(Zadania[] tab)
    {
        int highest = 0;
        for (int i = 0; i < tab.Length; i++)
        {
            if (tab[i].GetZadania() > highest)
            {
                highest = tab[i].GetZadania();
            }
        }
        return highest;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Zadania[] tab = new Zadania[5];
            tab[0] = new Zadania(50);
            tab[1] = new Zadania(10);
            tab[2] = new Zadania(0);
            tab[3] = new Zadania(4);
            tab[4] = new Zadania(30);
            int bo = Kolejnosc();
            Console.WriteLine("{ 0}", bo);
        }

        private static int Kolejnosc()
        {
            throw new NotImplementedException();
        }
    }
}

